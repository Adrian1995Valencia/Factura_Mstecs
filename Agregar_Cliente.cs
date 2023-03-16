using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura_Mstecs
{
    public partial class Agregar_Cliente : Form
    {
        public Agregar_Cliente()
        {
            InitializeComponent();
        }

        private void Agregar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            int n = GridViewcliente.Rows.Add();
            GridViewcliente.Rows[n].Cells[0].Value = textBoxid.Text;
            GridViewcliente.Rows[n].Cells[1].Value = textBoxnombre.Text;
            GridViewcliente.Rows[n].Cells[2].Value = textBoxapellido.Text;
            textBoxid.Text = " ";
            textBoxnombre.Text = " ";
            textBoxapellido.Text = " ";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            GridViewcliente.Rows.RemoveAt(GridViewcliente.CurrentCell.RowIndex);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal obj = new MenuPrincipal();
            obj.Visible = true;
            this.Visible = false;
        }
    }
}
