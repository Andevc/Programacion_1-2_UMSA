using System;
using System.IO;
namespace e1_Vehiculo {
   [Serializable]
   public class Vehiculo {
      private string placa, marca, modelo;
      private int kilometraje;
      public Vehiculo(){  }
      public string Placa { get {return this.placa;}  set {this.placa = value;}  }
      public string Marca { get {return this.marca;}  set {this.marca = value;}  }
      public string Modelo { get {return this.modelo;}  set {this.modelo = value;}  }
      public int Kilometraje { get {return this.kilometraje;}  set {this.kilometraje = value;}  }
      public void leer(){
         Console.Write("Placa: "); this.placa = Console.ReadLine();
         Console.Write("Marca: "); this.marca = Console.ReadLine();
         Console.Write("Modelo: "); this.modelo = Console.ReadLine();
         Console.Write("Kilometraje: "); this.kilometraje = int.Parse(Console.ReadLine());
      }
      public void mostrarV(){
         Console.WriteLine(
            "\tPlaca: {0} \t| Marca: {1}    \t| Modelo: {2} \t| Kilometraje: {3}",
            this.placa, this.marca,this.modelo, this.kilometraje
            );
      }
      public void rVehiculo(BinaryReader j){
         this.placa = j.ReadString();
         this.marca = j.ReadString();
         this.modelo = j.ReadString();
         this.kilometraje = j.ReadInt32();
      }
      public void wVehiculo(BinaryWriter j ){
         j.Write(this.placa);
         j.Write(this.marca);
         j.Write(this.modelo);
         j.Write(this.kilometraje);
      }  
   }
}

