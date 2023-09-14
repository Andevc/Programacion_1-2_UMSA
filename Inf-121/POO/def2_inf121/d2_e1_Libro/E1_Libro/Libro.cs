using System;
namespace E1_Libro
{
	public class Libro
	{
		private string nombre, colorTapa;
		private int nroPaginas;
		private string[]paginas = new string[50];
		public Libro()
		{
			nombre = "Libro Negro del Emprendedor";
			colorTapa = "Gris Oscuro";
			nroPaginas = 5;
			paginas[0] = "El compromiso en el camino hacia el éxito empresarial. ";
			paginas[1] = "Emprender con un meotivo, pero sin una motivacion. ";
			paginas[2] = "No ser un Luchador. ";
			paginas[3] = "El compromiso es una de las claves para superar los obstáculos. ";
			paginas[4] = "Una visión crítica y realista sobre el mundo de los negocios ";
		}
		public Libro(string nombre, string colorTapa)
		{
			this.nombre = nombre;
			this.colorTapa = colorTapa;
			nroPaginas = 5;
			paginas[0] = "El compromiso con nuestra propia protección ante la manipulacion ";
			paginas[1] = "Explorar aspectos para manipular y controlar personas ";
			paginas[2] = "Tener compromiso con una actitud crítica y reflexiva. ";
			paginas[3] = "El compromiso con la ética y la responsabilidad es esencial. ";
			paginas[4] = "";		
		}

		public string[] Paginas{ get { return this.paginas;} }
		public void mostrar(){
			Console.WriteLine("\n--x---------------------------------x--");
			Console.WriteLine(
				"\n\tNombre: "+this.nombre+
				"\n\tColor Tapa: "+this.colorTapa+
				"\n\tNro Paginas: "+this.nroPaginas
			);
			for (int i = 0; i < this.nroPaginas; i++)
			{
				Console.WriteLine("\t   "+paginas[i]);
			}
		}
		public void mostrar(string x){
			Console.WriteLine("--x---------------------------------x--");
			for (int i = 0; i < this.nroPaginas; i++)
			{
				bool verificarPal = paginas[i].Contains(x);
				if(verificarPal){
					Console.WriteLine("\t- La pagina "+(i+1)+" tiene la palabra "+x);
				}
			}
		}
		public static int contP(string w){
			string[] contp = w.Split(' ');
			int c = contp.Length-1;
        	return c;
		}
		public bool verfPag(int x){
			if( this.paginas[x] != ""){
				return true;
			}
			return false;			
		}
		public static bool operator !(Libro x){
			if(x.verfPag(4)){
				return true;
			}
			return false;
		}
		public static Libro operator ++(Libro x){
			Console.WriteLine("--x------------------------------------x--");
			for (int i = 0; i < x.nroPaginas; i++)
			{
				int np = contP(x.paginas[i]); 
				Console.WriteLine("\t- La pagina "+(i+1)+" tiene "+np+" palabras.");
			}
			Console.WriteLine("--x------------------------------------x--");
			return x;
		}
	}	
}


