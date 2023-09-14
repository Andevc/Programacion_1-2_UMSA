using System;
namespace E3_Veterinaria
{
	public class Principal
	{
		public static void Main(){
			Console.WriteLine("\n\n\tDatos Estudiante: Cristhian Andres Escobar Herrera");
			Console.WriteLine("\tCI: 6908109 L.P.");
			//a) 
			Veterinaria v1 = new Veterinaria();
			Veterinaria v2 = new Veterinaria("vet cuida");
			Propietario p1 = new Propietario();
			// b) 
			v1.mostrar();
			v2.mostrar();
			p1.mostrar();
			p1.mostrar("13579");
			v1.mostrar("Miraflores");
			//c) 
			v1 = v1 > p1; 
			v1.mostrar();
			//d)
			Console.ReadKey();
		}	
	}
}
