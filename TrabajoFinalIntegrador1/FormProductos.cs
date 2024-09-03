using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FormProductos : Form
    {
        string url = "https://fakestoreapi.com";
        private Productos produc;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            FormCrear fCrear = new FormCrear();
            fCrear.ShowDialog();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            FormActualizar fActualizar = new FormActualizar();
            fActualizar.ShowDialog();
        }

        private void btConsumirApi_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> producto = client.Get<List<Productos>>(request);
            GrillaProductos.DataSource = producto;
        }

        private void tbBuscarID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscarID.Text, out int productoId))
            {
 
                List<Productos> producto = new List<Productos>(){Productos.GetProductos(url, productoId)};
                GrillaProductos.DataSource = producto;
            }
        }
    }
}
