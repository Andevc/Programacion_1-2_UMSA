using System;
namespace E2_caja
{
	public class Objeto
	{
		private string nombre, costo;
		public Objeto()
		{
			nombre = "Lapiz";
			costo = "5";
		}
		public Objeto(string nombre, string costo)
		{
			this.nombre = nombre;
			this.costo = costo;
		}
		public void mostrar(){
			Console.WriteLine("--x-----------------------------x--");
			Console.WriteLine("\t\tObjeto");
			Console.WriteLine("\n\tNombre: {0} \n\tCosto: {1}",this.nombre,this.costo);
			Console.WriteLine("--x-----------------------------x--");
			
		}
		public string Nombre
		{
			get { return this.nombre; }
			set { nombre = value; }
		}
	}
}





