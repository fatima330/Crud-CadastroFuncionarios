using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Certifique-se de adicionar esta diretiva para a classe Form

namespace Crud
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=DESKTOP-74OKNPT\SQLDEV";
        private string strSql = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                strSql = "INSERT INTO Funcionarios (Id, Nome, CEP, Bairro, Cidade, UF, Telefone) VALUES (@Id, @Nome, @CEP, @Bairro, @Cidade, @UF, @Telefone)";

                using (sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    using (SqlCommand comando = new SqlCommand(strSql, sqlCon))
                    {
                        // Defina os parâmetros - substitua esses valores pelos valores reais
                        comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = int.Parse(txtId.Text);
                        comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                        comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = mskCEP.Text;
                        comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                        comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                        comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtUF.Text;
                        comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;



                        // Execute o comando
                        //sqlCon.Open(); //() metodo
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso");

                    }
                }
            }
            catch (Exception ex) //avisa se der algum erro
            {
                // Lidar com exceções aqui...
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally { sqlCon.Close(); }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Funcionarios where Id=@Id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstIdBuscar.Text;

            try
            {
                if (tstIdBuscar.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar um Id!");
                }
                sqlCon.Open(); // abrir o banco

                SqlDataReader dr = comando.ExecuteReader(); //tem a funcionalidade de retornar valores ja cadstrados no banco

                if (dr.Read())
                {
                    txtId.Text = Convert.ToString(dr["Id"]);
                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    mskCEP.Text = Convert.ToString(dr["CEP"]);
                    txtBairro.Text = Convert.ToString(dr["Bairro"]);
                    txtCidade.Text = Convert.ToString(dr["Cidade"]);
                    txtUF.Text = Convert.ToString(dr["UF"]);
                    mskTelefone.Text = Convert.ToString(dr["Telefone"]);
                }
                else
                {
                    throw new Exception("Id não cadastrado!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update Funcionarios set Id=@Id, Nome=@Nome, CEP=@CEP, Bairro=@Bairro, Cidade=@Cidade, UF=@UF, Telefone=@Telefone where Id=@IdBuscar";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tstIdBuscar.Text;

            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = int.Parse(txtId.Text);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = mskCEP.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse funcionario?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operaçao cancelada");
            }

            else
            {
                strSql = "delete from Funcionarios where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstIdBuscar.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionario deletado com sucesso!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    sqlCon.Close();
                 }
            }
        }

    }
}

