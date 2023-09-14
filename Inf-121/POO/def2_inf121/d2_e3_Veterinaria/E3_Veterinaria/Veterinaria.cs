using System;
namespace E3_Veterinaria
{
	public class Veterinaria
	{
		private string nombre;
		private int nroPropietarios;
		private string[,] Prop = new string[100,3];
		// Prop[col 1] = CI; Prop[col 2] = Celular; Prop[col 3] = Direccion;
		public Veterinaria(){
			nombre = "patitas";
			nroPropietarios = 3;
			Prop[0,0] = "12345"; Prop[0,1] = "12345678"; Prop[0,2] = "Irpavi";
			Prop[1,0] = "13579"; Prop[1,1] = "67563422"; Prop[1,2] = "Sopocachi";
			Prop[2,0] = "67890"; Prop[2,1] = "21533563"; Prop[2,2] = "Miraflores";
		}
		public Veterinaria(string nombre){
			this.nombre = nombre;
			nroPropietarios = 2;
			Prop[0,0] = "24680"; Prop[0,1] = "187394867"; Prop[0,2] = "Llojeta";
			Prop[1,0] = "10293"; Prop[1,1] = "193298342"; Prop[1,2] = "Av. Avaroa";			
		}
		public void mostrar(){
			Console.WriteLine("--X---------------------------------X--\n\t\tVeterinaria");
			Console.WriteLine("\n\tNombre: {0} \n\tNro Propietarios {1}", this.nombre, this.nroPropietarios);
			for (int i = 0; i < nroPropietarios; i++){
				Console.WriteLine("\t| "+Prop[i,0]+"\t| "+Prop[i,1]+"\t| "+Prop[i,2]+"\t|");
			}
		}
		public void mostrar(string x){
			for (int i = 0; i < nroPropietarios; i++){
				if(Prop[i,2] == x){
					Console.WriteLine("--X---------------------------------X--");
					Console.WriteLine("\t-El propietario tiene el CI: {0} y numero de Celular: {1}", this.Prop[i,0],Prop[i,1]);
				}
			}	
		}
		public static Veterinaria operator >(Veterinaria x, Propietario y){
			for (int i = 0; i < x.nroPropietarios; i++){
				if (x.Prop[i,0] == y.verfNomProp("David")){
					x.Prop[i,0] = x.Prop[i+1,0];
					x.Prop[i,1] = x.Prop[i+1,1];
					x.Prop[i,2] = x.Prop[i+1,2];
					x.nroPropietarios--;
				}
			}
			return x;
		}
		public static Veterinaria operator <(Veterinaria x, Propietario y){return x;}
		
	}
}

/* public bool verfNum(string x){
			for (int i = 0; i < nroPropietarios; i++){
				if( Prop[i,1] == x){return true;}
			}
			return false;
		} */
