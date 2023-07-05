using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PgnDoctor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inputTextBox.Click += InputTextBox_Click;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string pgn = inputTextBox.Text;
            string validPgn = ConvertToValidPgn(pgn);
            outputTextBox.Text = validPgn;

            if (!string.IsNullOrEmpty(validPgn))
            {
                Clipboard.SetText(validPgn);
                MessageBox.Show("Output PGN has been copied to the clipboard.", "Conversion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InputTextBox_Click(object sender, EventArgs e)
        {
            inputTextBox.SelectAll();
        }
        private string ConvertToValidPgn(string input)
        {
            return AddSpaces(input);
        }

        public static string AddSpaces(string input)
        {
            string output = Regex.Replace(input, @"([+#])(?!\s)", "$1 ");
            output = Regex.Replace(output, @"-o(?![\s+#])|(?<!-o)-O(?![\s+#])|(?<!-o)(?<!-O)-o(?![\s+#])", "-O ");
            output = Regex.Replace(output, @"(?<!\s)(1-0|0-1|1/2-1/2)(?!\s)", " $1");
            output = Regex.Replace(output, @"=([a-zA-Z])(?![+#\s])", "=$1 ");
            output = Regex.Replace(output, @"(?<![+\sOo])(\d)(\d+)(?=\.\s)|(?<=\d)(?=[A-Za-z])", "$1 $2");
            return output;
        }
    }
}


