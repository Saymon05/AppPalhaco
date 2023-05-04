namespace AppPalhaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palhaco palhaco = new Palhaco();
            palhaco.Nome = textBox1.Text;
            palhaco.Altura = Convert.ToDouble(textBox2.Text);
            palhaco.Endereco = textBox3.Text;
            palhaco.Telefone = textBox4.Text;
            palhaco.Email = textBox5.Text;
            palhaco.Cpf = textBox6.Text;
            palhaco.Identidade = textBox7.Text;

            palhaco.FalarSobreVc();
        }
    }
}