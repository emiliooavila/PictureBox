namespace EmilioAvila_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen= new OpenFileDialog();
            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation= abrirImagen.FileName;
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
