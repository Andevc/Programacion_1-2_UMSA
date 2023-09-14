using System;
using System.IO;
namespace e3_Estacion {
   [Serializable]
   public class Bus {
      private string placa, conductor;
      private int nroPasajeros;
      private string[] pasajeros = new string[35];
      public Bus(string placa, string conductor, int nroPasajeros) {
         this.placa = placa;
         this.conductor = conductor;
         this.nroPasajeros = nroPasajeros;
         for (int i = 0; i < this.nroPasajeros; i++) { pasajeros[i] =  addPj(); }
      }
      public string Placa { get { return this.placa; }  set {  this.placa = value;} }
      public string Conductor { get { return this.conductor; }  set {  this.conductor = value;} }
      public int NroPasajeros { get { return this.nroPasajeros; }  set {  this.nroPasajeros = value;} }
      public string[] Pasajeros { get { return this.pasajeros; }  set {  this.pasajeros = value;} }
      public void mostBus(){
         Console.WriteLine( "\t\tPlaca: {0} \t| Conductor: {1} \t| Nro Pj: {2}",this.placa,this.conductor,this.nroPasajeros);
         Console.Write("\t\tPasajeros:  "); for (int i = 0; i < this.nroPasajeros; i++) { Console.Write(" {0} |",pasajeros[i]); }
         Console.WriteLine("\n");
      }
      public void rBus(BinaryReader j ){
         this.placa = j.ReadString(); this.conductor = j.ReadString(); this.nroPasajeros = j.ReadInt32();
         for (int i = 0; i < this.nroPasajeros; i++) { this.pasajeros[i] = j.ReadString(); }
      }
      public void wBus(BinaryWriter j){
         j.Write(this.placa); j.Write(this.conductor); j.Write(this.nroPasajeros);
         for (int i = 0; i < this.nroPasajeros; i++) { j.Write(this.pasajeros[i]); }
      }
      public string addPj(){
         Random rnd = new Random();
         string[] pasajeros = new string[]{"Pepe","Max","Sofia","Kate","Jhon","Carlos","Luis","Carla","Astrid","Sebas"};
         return pasajeros[rnd.Next(pasajeros.Length)];
      }
   }
}
