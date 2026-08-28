using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase08mdb
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            CargarFormulariosEnTabs();
        }
        private void CargarFormulariosEnTabs()
        {
            //Instanciamos el Form1 y lo preparamos para incrustarlo
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (tabControl1.TabPages.Count > 0)
            {
                tabControl1.TabPages[0].Controls.Add(f1);
                f1.Show();
            }

            //Instanciamos el Form2 y lo preparamos para la segunda pestaña
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;

            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages[1].Controls.Add(f2);
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void modificar1_Click(object sender, EventArgs e)
        {

        }

        private void modificar1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
