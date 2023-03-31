using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.G_Barbearia
{
    public partial class frm_CriarConta : Form
    {
        public frm_CriarConta()
        {
            InitializeComponent();
        }

        conexao chamar = new conexao();

        private bool verSenha(string senha)
        {
            bool checar;
            if(senha.Trim().Length > 3)
            {
                checar = true;
            }
            else
            {
                MessageBox.Show("Digite uma senha mais forte");
                checar = false;
            }
            return checar;
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
           try {
                if(txt_nome.Text !=""  && txt_password.Text != "" )
                {
                    bool name = chamar.existeNome(txt_nome.Text);
                    bool pass = chamar.existeSenha(txt_password.Text);

                    if (!name && !pass && verSenha(txt_password.Text))
                    {

                        chamar.inserir(txt_nome.Text, txt_password.Text);
                        MessageBox.Show("Dados Salvos com sucesso","Verificação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        frm_Login l = new frm_Login();
                        l.Show();
                    }

                }
                if (txt_nome.Text == "" && txt_password.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos devidamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login ch = new frm_Login();
            ch.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_entrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_Login ch = new  frm_Login();
            ch.Show();
        }
    }
}
