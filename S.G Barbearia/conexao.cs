using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace S.G_Barbearia
{
    class conexao
    {
        MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=DB_BARBEARIA");
        private MySqlConnection conetar = new MySqlConnection("server='localhost';user='root';password='';database='DB_BARBEARIA'");
        public MySqlCommand cmd;
        public MySqlDataAdapter adaptador;
        DataTable tabela;
        public static string pegar;
        public static string pegarsenha;
        public int id;
        public string nome;
        public string senha;
      
        bool name;
        bool pass;
        public bool existeNome(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select nome from TB_ADMIN where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                MessageBox.Show("já existe este nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name = true;
            }
            catch
            {

                name = false;
            }
            finally
            {
                conetar.Close();
            }
            return name;
        }
        public void verificarNome(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select * from TB_ADMIN where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                this.senha = tabela.Rows[0]["senha"].ToString();

            }
            catch
            {

                MessageBox.Show("Este Usuário não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conetar.Close();
            }

        }
        public void verificarSenha(string var)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select senha from TB_ADMIN where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.senha = tabela.Rows[0]["senha"].ToString();


            }
            catch
            {



            }
            finally
            {
                conetar.Close();
            }


        }
        public bool existeSenha(string senha)
        {

            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select senha from TB_ADMIN where senha = @senha", conetar);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.senha = tabela.Rows[0]["senha"].ToString();
                MessageBox.Show("já existe esta senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass = true;
            }
            catch
            {

                pass = false;
            }
            finally
            {
                conetar.Close();
            }



            return pass;
        }
        public void inserir(string nome, string senha)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("insert into TB_ADMIN(nome,senha) values(@nome,@senha)", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conetar.Close();
            }
        }
        public void status(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select * from TB_ADMIN where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.id = int.Parse(tabela.Rows[0]["id"].ToString());
                conetar.Close();
                conetar.Open();
                cmd = new MySqlCommand("select * from TB_ADMIN where id = @id", conetar);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                this.senha = tabela.Rows[0]["senha"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conetar.Close();
            }
        }
        public void eliminar(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("delete from TB_ADMIN where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conetar.Close();
            }
        }
        public void atualizar(string nome,  string senha)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("update TB_ADMIN set nome = @nome,data_nascimento = data_nascimento,telefone = @telefone,senha = @senha,sexo = @sexo, id_provincia = @id_provincia where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conetar.Close();
            }
        }


        public void excluir(string nom)
        {
            try
            {
                DialogResult confirma = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Eliminar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirma == DialogResult.Yes)
                {

                    conector.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conector;
                    string este = nom;
                    //bunifuDataGridView1.Rows.RemoveAt(l);
                    cmd.CommandText = "DELETE FROM selecionados where produtos='" + este + "'";
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conector.Close();
            }

        }

    }
}
 