namespace GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxInput.Text = Properties.Settings.Default.SavedText;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SavedText = textBoxInput.Text;

            Properties.Settings.Default.Save();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Пожалуйста, введите текст для замены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string encryptedText = Logic.GetEncryptedText(inputText);

            textBoxOutput.Text = encryptedText;

            MessageBox.Show("Зашифрованно!!!!! \nДерши результат:\n" + encryptedText, "Успех WAAAAAAAAAAHH!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
