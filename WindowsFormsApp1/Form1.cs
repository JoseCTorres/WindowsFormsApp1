using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btnguardar : Form
    {
        public btnguardar()
        {
            InitializeComponent();
        }
        Contacto n = new Contacto();
        private void button1_Click(object sender, EventArgs e)
        {
            n.Nombre = textNOMBRE.Text;
            n.Telefono = textTELEFONO.Text;
            n.FechaNacimiento = DateTime.Parse(textFNCIMIENTO.Text);
            MessageBox.Show(n.ToString() );
        }

        private void textinfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}   
