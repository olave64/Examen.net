using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace appExamen.net
{
    public class CRUD
    {
        readonly String url = "http://localhost:3000/api/productos";
        public async Task<String> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }


        //----------------------ELIMINAR PRODUCTO------------------------\\
        public async Task DeleteProducto(int id)
        {
            using (var deleteP = new HttpClient())
            {
                var response = await deleteP.DeleteAsync(url + "?id=" + id);
            }
        }
        

        
        //-------------------------ACTUALIZAR PRODUCTO-----------------------\\
        public  async Task<string> UpdateProducto(int id, string nombre,int cantidad,string tipo)
        {
            string content = "";
            var client = new HttpClient();
            var response = await client.PutAsync(url + "?id=" + id + "&nombreP=" + nombre + "&cantidadP=" + cantidad + "&tipoP=" + tipo, new StringContent(content));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
        //-------------------------CREAR PRODUTO-------------------------\\
        public  async Task<string> CrearProducto(string nombre,int cantidad, string tipo)
        {
            string content = "";
            var client = new HttpClient();
            var response = await client.PostAsync(url + "?nombreP=" + nombre + "&cantidadP=" + cantidad + "&tipoP=" + tipo, new StringContent(content));
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
