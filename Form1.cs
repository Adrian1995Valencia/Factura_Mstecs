using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Factura_Mstecs
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cmb_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmb_Productos.SelectedIndex;
            nom = cmb_Productos.SelectedItem.ToString();
            precio = cmb_Productos.SelectedIndex;

            switch (cod)
            {
                case 0: lcodigo.Text = "0011"; break;
                case 1: lcodigo.Text = "0022"; break;
                case 2: lcodigo.Text = "0044"; break;
                case 3: lcodigo.Text = "0055"; break;
                case 4: lcodigo.Text = "0066"; break;
                case 5: lcodigo.Text = "0077"; break;
                default: lcodigo.Text = "0033"; break;
            }
            switch (nom)
            {
                case "Laptop": lnombre.Text = "Laptop"; break;
                case "Mouse": lnombre.Text = "Mouse"; break;
                case "Teclado": lnombre.Text = "Teclado"; break;
                case "Monitor": lnombre.Text = "Monitor"; break;
                case "USB": lnombre.Text = "USB"; break;
                case "Audifonos": lnombre.Text = "Audifonos"; break;
                default: lnombre.Text = "Cargador"; break;
            }
            switch (precio)
            {
                case 0: lprecio.Text = "8500"; break;
                case 1: lprecio.Text = "600"; break;
                case 2: lprecio.Text = "1200"; break;
                case 3: lprecio.Text = "2500"; break;
                case 4: lprecio.Text = "300"; break;
                case 5: lprecio.Text = "700"; break;
                default: lnombre.Text = "450"; break;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(griewlista);

            file.Cells[0].Value = lcodigo.Text;
            file.Cells[1].Value = lnombre.Text;
            file.Cells[2].Value = lprecio.Text;
            file.Cells[3].Value = textcantidad.Text;
            file.Cells[4].Value = (float.Parse(lprecio.Text) * float.Parse(textcantidad.Text)).ToString();

            griewlista.Rows.Add(file);
            lcodigo.Text = lnombre.Text = lprecio.Text = textcantidad.Text = "";

            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = griewlista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(griewlista.Rows[i].Cells[4].Value.ToString());
            }

            tpagar.Text = costot.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    griewlista.Rows.Remove(griewlista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void textefectivo_TextChanged(object sender, EventArgs e)
        {
            try {
                devolu.Text = (float.Parse(textefectivo.Text) - float.Parse(tpagar.Text)).ToString();
            }
            catch { }
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("Empresa MSTECS "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");


            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac : 456543 ");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: Alejandro Gómez");
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in griewlista.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(tpagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textefectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(devolu.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            this.Close();
        }

        private void lcliente_Click(object sender, EventArgs e)
        {
            Agregar_Cliente obj = new Agregar_Cliente();
            obj.Visible = true;
            this.Visible = false;
           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
