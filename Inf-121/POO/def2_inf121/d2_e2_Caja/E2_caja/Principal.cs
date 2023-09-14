using System;
namespace E2_caja
{
	public class Principal
	{
		public static void Main(){
			Console.WriteLine("\n\n\tDatos Estudiante: Cristhian Andres Escobar Herrera");
			Console.WriteLine("\tCI: 6908109 L.P.");
			// a)
			Caja c1 = new Caja();
			Caja c2 = new Caja("Azul Oscuro","buen estado");
			Caja c3 = new Caja("Morado Oscuro","mal estado",5);
			Objeto ob1 = new Objeto();
			Objeto ob2 = new Objeto("Linterna","15");
			c1.mostrar();
			c2.mostrar();
			c3.mostrar();
			ob1.mostrar();
			ob2.mostrar();
			//b)
			c3--;
			c3.mostrar();
			//c)
			c1 = c3-c1;
			c1.mostrar();
			c3.mostrar();
			//d)
			Console.WriteLine("\n--x-----------------------------x--");
			c1 = c1 == ob1; 
			Console.WriteLine("\n--x-----------------------------x--");
			Console.WriteLine("\n\n");
			Console.ReadKey();
		}
	}
}
