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
        private string ConvertToValidPgn(string pgn)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < pgn.Length)
            {
                if (pgn[i] == '+' || pgn[i] == '#' || ((pgn[i] == 'O' || pgn[i] == 'o') && i + 1 < pgn.Length && pgn[i + 1] != '-'))
                {
                    sb.Append(pgn[i]);
                    if (i + 1 < pgn.Length && pgn[i + 1] != ' ')
                    {
                        sb.Append(' ');
                    }

                }
                else if (Char.IsDigit(pgn[i]))
                {
                    sb.Append(pgn[i]);
                    if (i > 0 && pgn[i - 1] != '+' && pgn[i - 1] != '#' && !Char.IsDigit(pgn[i - 1]) && i + 1 < pgn.Length && pgn[i + 1] != ' ' && pgn[i + 1] != '.' && pgn[i + 1] != '-' && pgn[i + 1] != '+' && pgn[i + 1] != '#' && pgn[i + 1] != '/')
                        sb.Append(' ');
                }
                else
                {
                    sb.Append(pgn[i]);
                }
                i++;
            }

            return sb.ToString();
        }

    }
}
