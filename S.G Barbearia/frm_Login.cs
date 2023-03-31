using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace S.G_Barbearia
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        int counter = 0;
        int len = 0;
        string text;
        int count = 0;
        private void Login_Load(object sender, EventArgs e)
        {
            text = labelMensagem.Text;
            len = text.Length;
            labelMensagem.Text = "";
            timer1.Start();
        }

        frm_CriarConta ch;
        private void lb_criar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ch = new frm_CriarConta();
            ch.Show();
        }

        conexao chamar = new conexao();
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_password.Text != "")
            {
                chamar.verificarNome(txt_nome.Text);
                chamar.verificarSenha(txt_password.Text);
                if (txt_password.Text == chamar.senha)
                {
                    conexao.pegar = txt_nome.Text;
                    conexao.pegarsenha = chamar.senha;
                    this.Hide();
                    Form1 conf = new Form1();
                    conf.Show();
                }
                else
                {
                    MessageBox.Show("Senha Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            txt_nome.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txt_nome.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelMensagem.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                labelMensagem.Show();
                timer1.Stop();

            }
            count++;
        }
    }
}
