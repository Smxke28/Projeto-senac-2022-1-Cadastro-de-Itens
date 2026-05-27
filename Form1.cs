using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Autozização de conexão com o BD

namespace cadastro
{   //aqui iremos criar variaveis
    public partial class Form1 : Form
    {
        MySqlConnection conexão;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        string strSql;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexão = new MySqlConnection("Server = localhost; dataBase = FormularioCad; Uid = root; Pwd = 1234");

                strSql = "SELECT * FROM FormularioCad";

                da = new MySqlDataAdapter(strSql, conexão);

                DataTable dt = new DataTable();
                
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();
                conexão=null;
                conexão=null;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //tratamento de excessoes
            try
            {
                conexão = new MySqlConnection("Server = localhost; dataBase = FormularioCad; Uid = root; Pwd = 1234");

                strSql = "INSERT INTO FormularioCad (nome, telefone) VALUES (@NOME, @TELEFONE)";

                comando = new MySqlCommand(strSql, conexão);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txt_telefone.Text);

                conexão.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();
                conexão=null;
                conexão=null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //try
          // {
     
                //conexão = new MySqlConnection("Server = localhost; dataBase = formulariocad; Uid = root; Pwd = juan2002");

                //strSql = "UPDADE formulariocad SET NOME = @NOME, TELEFONE = @TELEFONE";

                //comando = new MySqlCommand(strSql, conexão);
                //comando.Parameters.AddWithValue("@ID", txt_id.Text);
                //comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                //comando.Parameters.AddWithValue("@TELEFONE", txt_telefone.Text);

                //conexão.Open();

                //comando.ExecuteNonQuery();
          
           // }
            //cattch
            }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexão = new MySqlConnection("Server = localhost; dataBase = FormularioCad; Uid = root; Pwd = 1234");

                strSql = "DELETE FROM FormularioCad WHERE ID = @ID";

                comando = new MySqlCommand(strSql, conexão);
                comando.Parameters.AddWithValue("@ID", txt_id.Text);

                conexão.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();
                conexão=null;
                conexão=null;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexão = new MySqlConnection("Server = localhost; dataBase = FormularioCad; Uid = root; Pwd = 1234");

                strSql = "SELECT * FROM FormularioCad WHERE ID = @ID ";

                comando = new MySqlCommand(strSql, conexão);
                comando.Parameters.AddWithValue("@ID", txt_id.Text);

                conexão.Open();

                dr = comando.ExecuteReader();

                while(dr.Read())
                {
                    txt_nome.Text = Convert.ToString(dr["nome"]);
                    txt_nome.Text = Convert.ToString(dr["telefone"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();
                conexão=null;
                conexão=null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
