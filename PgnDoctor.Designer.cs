namespace PgnDoctor
{
    partial class MainForm
    {
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button runButton;
        private Label labelInput;
        private Label labelOutput;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            runButton = new Button();
            labelInput = new Label();
            labelOutput = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextBox.Location = new Point(12, 43);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(938, 169);
            inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            outputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputTextBox.Location = new Point(12, 270);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(938, 241);
            outputTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            runButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            runButton.Location = new Point(443, 228);
            runButton.Name = "runButton";
            runButton.Size = new Size(75, 36);
            runButton.TabIndex = 2;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += RunButton_Click;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInput.Location = new Point(12, 20);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(85, 21);
            labelInput.TabIndex = 3;
            labelInput.Text = "Input PGN:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(12, 246);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(98, 21);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "Output PGN:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 523);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(runButton);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "MainForm";
            Text = "PGN Doctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
