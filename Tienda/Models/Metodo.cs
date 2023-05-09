using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda.Models
{
	public class Metodos
	{

		public void InsertarProducto(string producto, int cantidad, TiendaContext tienda)
		{
			var registro = new Producto();
			registro.Cantidad = cantidad;
			registro.Producto1 = producto;
			tienda.Productos.Add(registro);
			Console.WriteLine("Producto agregado exitosamente");
			tienda.SaveChanges();

		}

		public void EliminarProducto(int ID, TiendaContext tienda)
		{
			var Producto = tienda.Productos.Find(ID);

			if (Producto != null)
			{
				tienda.Productos.Remove(Producto);
				Console.WriteLine("Producto eliminado exitosamente");
				tienda.SaveChanges();
			}


		}

		public void ActualizarProducto(int cantidad, int ID, TiendaContext tienda)
		{
			var Producto = tienda.Productos.Find(ID);
			if (Producto != null)
			{
				Producto.Cantidad = cantidad;
				Console.WriteLine("Producto modificado exitosamente");
				tienda.SaveChanges();
			}
		}

		public void ListarProductos(TiendaContext tienda)
		{
			int cantidadProductos = tienda.Productos.Count();

			if (cantidadProductos == 0)
				Console.WriteLine($"No hay productos cargados en la tienda");

			foreach (var item in tienda.Productos.ToList())
			{
				Console.WriteLine($"ID:{item.Id}");
				Console.WriteLine($"Nombre:{item.Producto1}");
				Console.WriteLine($"Cantidad:{item.Cantidad}");
			}

		}


	}
}
