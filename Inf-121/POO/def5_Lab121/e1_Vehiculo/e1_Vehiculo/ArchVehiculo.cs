using System;
using System.IO;
namespace e1_Vehiculo {
   public class ArchVehiculo {
      private string na;
      public ArchVehiculo( string na) { this.na = na; }
      public void crear(){ if (File.Exists(na)) { File.Delete(na); } }
      public void adicionar(){
         string sw;
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         Console.WriteLine("--x-- Agregar Vehiculo --x--");
         try {
            do {
               Vehiculo regVh = new Vehiculo();
               regVh.leer();
               write.Seek(0,SeekOrigin.End);
               regVh.wVehiculo(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : ");
               sw = Console.ReadLine();  
            } while (sw == "s");
         }
         catch( Exception ){ Console.WriteLine(""); }
         finally { file.Close(); }
      }
      public void listar(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine(
            "----------------------------------------\n"+
            "|          Registro Vehiculos          |\n"+
            "----------------------------------------\n"
         );
         try {
            while (true) {     
               Vehiculo regVh = new Vehiculo();
               regVh.rVehiculo(read);
               regVh.mostrarV();
            }
         }
         catch (Exception) { Console.WriteLine("\n--x-- FIN --x--\n"); }
         finally { file.Close(); }
      }
      // B)
      public void mostVehiculoPlaca(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("- Estos vehiculos tienen la placa con terminacion impar: \n ");
         try {
            while (true) {
               Vehiculo regVh = new Vehiculo();
               regVh.rVehiculo(read);
               int nplaca = int.Parse(regVh.Placa.Substring(regVh.Placa.LastIndexOf('-') + 1)) % 10;
               if(nplaca % 2 != 0){ regVh.mostrarV(); }
            }
         }
         catch (Exception) { Console.WriteLine("");}
         finally{ file.Close(); }
      }


      public void Modificar( string marca ){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         Stream fileAux = File.Open("aux.dat",FileMode.OpenOrCreate);

         BinaryReader read = new BinaryReader(file);
         BinaryWriter write = new BinaryWriter(fileAux);

         try
         {
            while(true){
               Vehiculo ch = new Vehiculo();
               ch.rVehiculo(read);
               if( ch.Marca == marca) {
                  ch.leer();
               }
               write.Seek(0,SeekOrigin.End);
               ch.wVehiculo(write);
            }
         }
         catch(Exception){ Console.WriteLine("Fin Modificaion"); }
         finally
         {
            file.Close();
            fileAux.Close();
            if(File.Exists(na)){  File.Delete(na); }
            if(File.Exists("aux.dat")){
               File.Move("aux.dat",na);
            }
         }
      }

      // C) 
      public void contModelo(string x){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         int c = 0;
         try {
            while (true) {
               Vehiculo regVh = new Vehiculo();
               regVh.rVehiculo(read);
               if( regVh.Modelo == x){ c++;}  
            }
         }
         catch (Exception) { Console.WriteLine(""); }
         finally{ file.Close(); }
         Console.WriteLine("- El Modelo {0} tiene {1} vehiculos iguales \n",x,c);
      }
   }
}
