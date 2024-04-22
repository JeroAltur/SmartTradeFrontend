using SmartTradeFrontend.Services;

namespace SmartTradeFrontend.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string imagenes { get; set; }
        public double HuellaAmbiental { get; set; }
        public int id_valoracion { get; set; }
        public double valor { get; set; }
        public int ventas { get; set; }
    }
}
