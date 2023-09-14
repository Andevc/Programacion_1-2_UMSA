using System;
namespace E3_Veterinaria
{
	public class Propietario
	{
		private string nombre, ci;
		private int nroMascotas;
		private string[,] Mascotas = new string[100,3];
		// Mascotas[col 1] = Nombre Mascotas; Mascotas[col 2] = Tipo; Mascotas[col 3] = Codigo;
		public Propietario(){
			nombre = "David";
			ci = "13579";
			nroMascotas = 3;
			Mascotas[0,0] = "Jack"; Mascotas[0,1] = "Canina"; Mascotas[0,2] = "101";
			Mascotas[1,0] = "Kia" ; Mascotas[1,1] = "Felina"; Mascotas[1,2] = "102";
			Mascotas[2,0] = "Tom" ; Mascotas[2,1] = "Felina"; Mascotas[2,2] = "103";
		}
		public void mostrar(){
			Console.WriteLine("--X---------------------------------X--");
			Console.WriteLine(
				"\n\tNombre: {0} \n\tCI: {1} \n\tNro Mascotas {2}", this.nombre,this.ci, this.nroMascotas);
			for (int i = 0; i < nroMascotas; i++){
				Console.WriteLine("\t| "+Mascotas[i,0]+"\t| "+Mascotas[i,1]+"\t| "+Mascotas[i,2]+"\t|");
			}
		}
		public void mostrar(string x){
			if( ci == x){
				Console.WriteLine("--X---------------------------------X--\n\t\tMascotas\n");
				for (int i = 0; i < nroMascotas; i++){
					if(Mascotas[i,1] == "Felina"){
						Console.WriteLine("\t| "+Mascotas[i,0]+"\t| "+Mascotas[i,1]+"\t| "+Mascotas[i,2]+"\t|");
					}
				}	
			}
		}
		public string verfNomProp(string x){
			if( x == this.nombre){ return this.ci; }
			return "";
		}		
    } 
}

/* public int NroMascotas { get; set; }
		public string[,] Mascota { get; set; }
		public static Propietario operator =(Propietario x, Veterinaria y){
			int can = 0, fel = 0;
			Console.WriteLine("--X---------------------------------X--");
			if(y.verfNum("67563422")){
				
				for (int i = 0; i < x.nroMascotas; i++)
				{
					if(x.Mascotas[i,1] == "Canina"){ can++;}
					else{ fel++;}
				}
				Console.WriteLine("\t-Hay {0} caninos y {1} felinos",can,fel);
			}else{
				Console.WriteLine("\t-No existe el propietario de dicho celular");
			}
			Console.WriteLine("--X---------------------------------X--");
			return x;
		}*/
