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
        String url = "http://localhost:3000/api/productos";
        public Contenedor()
        {
            InitializeComponent();
        }

       

        private  void Contenedor_Load(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private async void actualizarDGV() {
            String respuesta = await GetHttp();
            List<Producto> listaProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
            DGVproductos.DataSource = listaProductos;
        }
        public async Task<String> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void DGVproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnas = DGVproductos.ColumnCount;
            StringBuilder sb = new StringBuilder();
            String[] hhh = new string[columnas];
            int i = 0;
            foreach (DataGridViewCell item in DGVproductos.CurrentRow.Cells)
            {

                hhh[i] = item.FormattedValue.ToString();
                //sb.Append(item.Value.ToString());
               i++;
            }
            //__________________________________


            Id.Text = hhh[0];
            Nombre.Text = hhh[1];
            Cantidad.Text = hhh[2];
            Tipo.Text = hhh[3];
            

        }
        //----------------------ELIMINAR PRODUCTO------------------------\\
        public async Task DeleteProducto(int id)
        {
            using (var deleteP = new HttpClient())
            {
                var response = await deleteP.DeleteAsync(url+"?id=" + id);
                
            }
        }


        //-------------------------CREAR PRODUTO-------------------------\\

        private static async Task<string> crearProducto(string url, string content)
        {
            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(content));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        //-------------------------ACTUALIZAR PRODUCTO-----------------------\\
        private static async Task<string> updateProducto(string url, string content)
        {

            var client = new HttpClient();
            var response = await client.PutAsync(url, new StringContent(content));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        private async  void Nuevo_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            int cantidad = int.Parse(Cantidad.Text);
            string tipo = Tipo.Text;
            await crearProducto(url+"?nombreP="+nombre+"&cantidadP="+cantidad+"&tipoP="+tipo, "");
            actualizarDGV();

        }

        private async void Borrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Id.Text);
            await DeleteProducto(id);
            actualizarDGV();
        }


        

        private async void Actualizar_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(Id.Text);
                String nombre = Nombre.Text;
                int cantidad = int.Parse(Cantidad.Text);
                string tipo = Tipo.Text;
                await updateProducto(url + "?id=" + id + "&nombreP=" + nombre + "&cantidadP=" + cantidad + "&tipoP=" + tipo, "");
                actualizarDGV();
            }
            catch(Exception)
            {
                MessageBox.Show("No se a selecionado ningun producto");
            
            }    

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Id.Text = null;
            Nombre.Text = null;
            Cantidad.Text = null;
            Tipo.Text = null;
        }
    }


    

    
}
