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
    }
}
