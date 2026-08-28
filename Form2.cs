using clase08mdb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace clase08mdb
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public Form2()
        {
            InitializeComponent();
            //usando la clase conexión
            // creo un nuevo objeto de tipo Conexión y lo asigno a cn
            conexion cn = new conexion();
            //acceso a la función conec de la clase conexión
            cn.conec();
            //agrego la variable scn a la cadena conexión
            sCn = cn.cadena;
            //creo la conexión pensándolo como argumento la cadena
            conn = new SqlConnection(sCn);
            //abro la conexión
            conn.Open();

        }

        private void insertar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textcod2.Text) ||
            string.IsNullOrWhiteSpace(textnom2.Text) ||
            string.IsNullOrWhiteSpace(textapel2.Text) ||
            string.IsNullOrWhiteSpace(textedad2.Text))
            {
                MessageBox.Show("Error: Todos los campos son obligatorios. No pueden haber campos vacíos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay vacíos
            }
            try
            {
                // creo la variable que contendrá la consulta sql de inserción
                string inserparticipante;
                inserparticipante = "INSERT INTO Participantes(Codigo,Nombres,Apellidos,Edad)";
                inserparticipante += "VALUES(@carnet,@nombre,@apellido,@edad)";
                insert1 = new SqlCommand(inserparticipante, conn);
                insert1.Parameters.Add(new SqlParameter("@carnet", SqlDbType.VarChar));
                insert1.Parameters["@carnet"].Value = textcod2.Text;
                insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                insert1.Parameters["@nombre"].Value = textnom2.Text;
                insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                insert1.Parameters["@apellido"].Value = textapel2.Text;
                insert1.Parameters.Add(new SqlParameter("@edad", SqlDbType.Int));
                insert1.Parameters["@edad"].Value = textedad2.Text;
                insert1.ExecuteNonQuery();
                //Limpiamos los textBox
                textcod2.Text = "";
                textnom2.Text = "";
                textapel2.Text = "";
                textedad2.Text = "";
                MessageBox.Show("Registro agregado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar:" + ex.Message);
            }

        }

        private void buscar2_Click(object sender, EventArgs e)
        {
          TabControl tabPrincipal = (TabControl)this.Parent.Parent;
          TabPage pestaña1 = tabPrincipal.TabPages[0];
            foreach (Control c in pestaña1.Controls)
            {
                if (c is Form1 f1)
                {
                    f1.AsignarCodigo(textcod2.Text);
                    
                }
            }
            
            tabPrincipal.SelectedIndex = 0;
        }
    }
}
