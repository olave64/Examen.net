using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appExamen.net
{

    public partial class Contenedor : Form
    {
        readonly CRUD crud = new CRUD(); 
        public Contenedor()
        {
            InitializeComponent();
        }



        private void Contenedor_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private async void ActualizarDGV()
        {
            String respuesta = await crud.GetHttp();
            List<Producto> listaProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
            DGVproductos.DataSource = listaProductos;
        }
       
        private void DGVproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnas = DGVproductos.ColumnCount;
            //StringBuilder sb = new StringBuilder();
            String[] hhh = new string[columnas];
            int i = 0;
            foreach (DataGridViewCell item in DGVproductos.CurrentRow.Cells)
            {

                hhh[i] = item.FormattedValue.ToString();
                //sb.Append(item.Value.ToString());
                i++;
            }
            
            Id.Text = hhh[0];
            Nombre.Text = hhh[1];
            Cantidad.Text = hhh[2];
            Tipo.Text = hhh[3];


        }

       

        private async void Nuevo_Click(object sender, EventArgs e)
        {

            Id.Text = null;

            try
            {
                string nombre = Nombre.Text;
                int cantidad = int.Parse(Cantidad.Text);
                string tipo = Tipo.Text;
                if (nombre == "" || tipo == "")
                {
                    MessageBox.Show("Error los campos nombre, cantidad tipo son obligatorio");
                }
                else
                {
                    await crud.CrearProducto(nombre,cantidad,tipo);
                    Resetear();
                    ActualizarDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de valores incorrectos");
            }

        }

        private async void Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Id.Text);

                DialogResult confirmacion = MessageBox.Show("Desea eliminar el producto con ID = "+id, "Confirmacion", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes) {
                    await crud.DeleteProducto(id);
                    Resetear();
                    ActualizarDGV();
                }
          
            }
            catch (Exception)
            {
                MessageBox.Show("No hay un producto seleccionado");
            }

        }

        private async void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Id.Text);
                String nombre = Nombre.Text;
                int cantidad = int.Parse(Cantidad.Text);
                string tipo = Tipo.Text;
                await crud.UpdateProducto(id,nombre,cantidad,nombre);
                Resetear();
                ActualizarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("No se a selecionado ningun producto");

            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Resetear();
        }

        private void Resetear()
        {
            Id.Text = null;
            Nombre.Text = null;
            Cantidad.Text = null;
            Tipo.Text = null;
        }
    }

}

