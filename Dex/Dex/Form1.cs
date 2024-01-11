namespace Dex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            field1.Text=""
            field2.Text = ""
            field3.Text = ""
            field4.Text = ""
            field5.Text = ""
            picturebox1.image = Nothing 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
       dim outFile as New IO.streamwriter("data.txt")

    }
}