

using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Linq;
using System;
using Tienda.Models;

bool flag = true;
//clase Metodos que contiene los métodos para insertar, eliminar, modificar y listar productos
Metodos met = new Metodos();
var Tienda = new TiendaContext();


while (flag)
{
	Console.WriteLine("Bienvenido al gestor de bases de datos");
	Console.WriteLine("1. Insertar productos");
	Console.WriteLine("2. Actualizar productos");
	Console.WriteLine("3. Eliminar productos");
	Console.WriteLine("4. Listar productos");
	Console.WriteLine("5. Salir");

	Console.WriteLine();
	Console.Write("Ingrese opción:");
	int opcion = Convert.ToInt32(Console.ReadLine());

	switch (opcion)
	{
		case 1:
			Console.Write("Ingrese nombre del producto:");
			string Producto = Console.ReadLine();
			Console.Write("Ingrese cantidad:");
			int Cantidad = Convert.ToInt32(Console.ReadLine());
			met.InsertarProducto(Producto, Cantidad, Tienda);
			Console.Clear();
			break;

		case 2:
			Console.Write("Ingrese ID del producto a modificar:");
			int ID = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese cantidad a modificar del producto:");
			int Cantidad2 = Convert.ToInt32(Console.ReadLine());

			met.ActualizarProducto(Cantidad2, ID, Tienda);
			Console.Clear();
			break;


		case 3:
			Console.Write("Ingrese ID del producto a eliminar:");
			int ID2 = Convert.ToInt32(Console.ReadLine());
			met.EliminarProducto(ID2, Tienda);
			Console.Clear();
			break;

		case 4:
			Console.Clear();
			met.ListarProductos(Tienda);
			Console.WriteLine();
			break;

		case 5:
			flag = false;
			break;
	}
}
