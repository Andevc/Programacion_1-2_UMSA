using System;

namespace E1_Libro
{
	public class Principal
	{
		public static void Main(){

			Console.WriteLine("\n\n\tDatos Estudiante: Cristhian Andres Escobar Herrera");
			Console.WriteLine("\tCI: 6908109 L.P. ");

			//A) Instanciar 2 Libros de forma distinta y mostrarlos.
			Libro l1 = new Libro();
			Libro l2 = new Libro("Psicologia Oscura", "Azul Oscuro");

			l1.mostrar();
			l2.mostrar();
			// B) Sobrecargar el método “mostrar” para mostrar las páginas que tengan la palabra “compromiso”
			
			l1.mostrar("compromiso");
			l2.mostrar("compromiso");

			//C) Sobrecargar al operador ! (true/false) para verificar si la página de número x no esta vacía.
			Console.WriteLine("--x-------------------------x--");
			if( !l2){
				Console.WriteLine("\t-->La pag. no esta vacia");
			}else{
				Console.WriteLine("\t-->La pag. esta vacia");
			}
			Console.WriteLine("--x-------------------------x--");
			//D) Sobrecargar al operador (++) para contar el número de palabras que hay en cada página de libro.
			l1++;
			l2++;			
			Console.ReadKey();
		}
	}
}
