using System;
using System.IO;
namespace e3_Estacion {
   public class ArchEstacion {
      private string na;
      public ArchEstacion(string na) { this.na = na; }
      public void crear(){ if(File.Exists(na)){ File.Delete(na); }}
      public void adicionar(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         try {
            Estacion est1 = new Estacion();
            Estacion est2 = new Estacion("Estacion España");
            write.Seek(0,SeekOrigin.End);
            est1.wEstacion(write);
            est2.wEstacion(write);
         }
         catch (Exception) {  Console.WriteLine(); }
         finally{ file.Close(); }
      }
      public void listar(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine(
            "-----------------------------------\n"+
            "|           ESTACIONES            |\n"+
            "-----------------------------------\n");
         try {
            while(true){
               Estacion est1 = new Estacion();
               Estacion est2 = new Estacion("Estacion España");
               est1.rEstacion(read); est2.rEstacion(read);
               Console.WriteLine("Estacion 1"); est1.mostEstacion();
               Console.WriteLine("Estacion 2"); est2.mostEstacion();
            }
         }
         catch (Exception) { Console.WriteLine(""); }
         finally { file.Close(); }
      }
      public void mostPlaca(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         int may1 = 0, may2 = 0;
         string pl1 = "", pl2 = "";
         try {
            Estacion est1 = new Estacion();
            Estacion est2 = new Estacion("Estacion España");
            est1.rEstacion(read); est2.rEstacion(read);
            for (int i = 0; i < est1.NroBuses; i++) {
               if(may1 < est1.Buses[i].NroPasajeros){ may1 = est1.Buses[i].NroPasajeros; pl1 = est1.Buses[i].Placa; }
            }
            for (int i = 0; i < est2.NroBuses; i++) {
               if(may2 < est2.Buses[i].NroPasajeros){ may2 = est2.Buses[i].NroPasajeros; pl2 = est2.Buses[i].Placa; }
            }
            if (may1 > may2) { Console.WriteLine("\t- La placa del bus con mas Buses es: {0}",pl1); }
            else { Console.WriteLine("\t- La placa del bus con mas Buses es: {0}",pl2); }
         }
         catch (System.Exception) { Console.WriteLine(); }
         finally{ file.Close(); }
      }
      public void verfPasajero(string nomPj, string busY){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         bool sw = false;
         try {
            Estacion est1 = new Estacion();
            Estacion est2 = new Estacion("Estacion España");
            est1.rEstacion(read); est2.rEstacion(read);
            for (int i = 0; i < est1.NroBuses; i++) {
               if(est1.Buses[i].Placa == busY){ 
                  for (int j = 0; j < est1.Buses[i].NroPasajeros; j++) { if( est1.Buses[i].Pasajeros[j] == nomPj){ sw = true;} }
               }
            }
            for (int i = 0; i < est2.NroBuses; i++) {
               if(est2.Buses[i].Placa == busY){ 
                  for (int j = 0; j < est2.Buses[i].NroPasajeros; j++) { if( est2.Buses[i].Pasajeros[j] == nomPj){ sw = true;} }
               }
            }
            if(sw){ Console.WriteLine("\t- El pasajero {0} esta en el bus de placa {1}",nomPj,busY); }
            else{ Console.WriteLine("\t- El pasajero no existe"); }
         }
         catch (Exception) { Console.WriteLine(""); }
         finally{ file.Close(); }
      }
   }
}


/*       public void adiPjBus(string nomConductor, int n){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Stream fileAux = File.Open("aux.dat",FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(fileAux);
         try {
            Estacion est1 = new Estacion();
            Estacion est2 = new Estacion("Estacion España");
            est1.rEstacion(read); est2.rEstacion(read);
            for (int i = 0; i < est1.NroBuses; i++) { 
               if( est1.Buses[i].Conductor == nomConductor){ est1.Buses[i].NroPasajeros = est1.Buses[i].NroPasajeros + n; } 
            }
            for (int i = 0; i < est2.NroBuses; i++) { 
               if( est2.Buses[i].Conductor == nomConductor){ est2.Buses[i].NroPasajeros = est2.Buses[i].NroPasajeros + n;} 
            }
            est1.wEstacion(write);
            est2.wEstacion(write);
         }
         catch (Exception) { Console.WriteLine(); }
         finally{ 
            file.Close(); 
            fileAux.Close();
         }
      } */