namespace GUI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label = new Label();
            textBoxInput = new TextBox();
            buttonEncrypt = new Button();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(12, 9);
            Label.Name = "Label";
            Label.Size = new Size(106, 20);
            Label.TabIndex = 0;
            Label.Text = "Введите текст:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 32);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(285, 142);
            textBoxInput.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(12, 180);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(285, 36);
            buttonEncrypt.TabIndex = 2;
            buttonEncrypt.Text = "Шифруемся!!!!!!";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(12, 222);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(285, 165);
            textBoxOutput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 398);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonEncrypt);
            Controls.Add(textBoxInput);
            Controls.Add(Label);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private TextBox textBoxInput;
        private Button buttonEncrypt;
        private TextBox textBoxOutput;
    }
}
