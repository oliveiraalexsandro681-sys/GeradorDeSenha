    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace GeradorDeSenhas
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

            private async void button1_Click(object sender, EventArgs e)
            {
                string nome = txtNome.Text;
                string emeail = txtEmail.Text;
                string senha = txtSenha.Text;

                Random gerador = new Random();

                int gere = gerador.Next(000000, 999999);
                if (nome == "" && emeail ==  "")
                {
                    MessageBox.Show($"Digite o seu nome e email");
                return;
                }
            else
            {
                MessageBox.Show($"Digite as informações acima");
            }
            MessageBox.Show($"Olá, {nome}, obrigado pelas informaçõe.");
                MessageBox.Show("");
                MessageBox.Show("Gerando senha....");
                await Task.Delay(3000);
                MessageBox.Show("");
                MessageBox.Show($"Olá, {nome}, a sua senha é {gere} .");

            }
        }
    }
