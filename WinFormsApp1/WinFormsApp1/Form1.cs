using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valor_inicial = 1000;
        int valor_adicional = 999; 

        //***************VARIAVEIS PARA CONSULTA*****************   

        //long valor_enorme = 9223372036854755808; //VARIAVEL DE NUMEROS INTEIROS COM MAIOR CAPACIDADE  -> long = -9.223.372.036.854.775.808 a 9.223.372.036.854.775.808
        //short valor_menor = 32767;               //VARIAVEL DE NUMEROS INTEIROS COM MENOR CAPACIDADE  -> short = -2.147.483.648 a 2.147.483.648                //
        //byte valor_pequeno = 255;                //VARIAVEL DE NUMEROS INTEIROS COM MAIOR CAPACIDADE  -> byte = 0 a 255
        //float valor1 = 11.5f;
        //double valor2 = 20.3;
        //decimal valor3 = 30.7m;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Você possui inicialmente" + " " + "R$" + valor_inicial.ToString() +",00";

            label2.Text = (valor_inicial >= 2000 && valor_inicial <= 5000) ? "Valor de investimento alcançado!" : label2.Text = "Valor fora da faixa de investimento!" ;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor_total = valor_inicial + valor_adicional;
            label1.Text = "Você possui um total de" + " " + "R$" + valor_total.ToString() + ",00";


            label2.Text = (valor_total >= 2000 && valor_total <= 5000) ? "Valor de investimento alcançado!" : label2.Text = "Valor fora da faixa de investimento!";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}