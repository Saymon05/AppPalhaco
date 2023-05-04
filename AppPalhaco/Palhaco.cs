using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPalhaco
{
    public class Palhaco
    {
        private String nome = "";
        private double altura = 0;
        private String endereco = "";
        private String telefone = "";
        private String email = "";
        private String cpf = "";
        private String identidade = "";

        public string Nome { get => nome; set => nome = value; }
        public double Altura { get => altura; set => altura = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Identidade { get => identidade; set => identidade = value; }
        
        public void FalarSobreVc()
        {
            String str;
            str = "Nome: " + Nome + "\n" + "Altura: " + Altura + "\n" +
            "Endereço: " + Endereco + "\n" + "Telefone: " + telefone + "\n" +
            "E-mail: " + email + "\n" + "CPF: " + Cpf + "\n" + "Identidade: " + identidade + "\n";
            MessageBox.Show(str, "DADOS DO PALHAÇO!");
        }

    }
}
