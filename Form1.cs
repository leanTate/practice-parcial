namespace arbol_genealogico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona(TxtName.Text, TxtLastname.Text, Convert.ToInt32(TxtAge.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frame2 NewFrame = new frame2();
            NewFrame.Show();
            this.Hide();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}