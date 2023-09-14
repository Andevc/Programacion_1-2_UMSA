using System;
namespace e3_DeliveryApp{
   public class Repartidor : Persona {
      private string vehiculo;
      private int nroEstrellas;
      public Repartidor(string nom, string ap,int ed, int ci ,string vehiculo, int nroEstrellas) : 
      base(nom,ap,ed,ci){
         this.vehiculo = vehiculo;
         this.nroEstrellas = nroEstrellas;
      }
      public void mostR(){
         Console.WriteLine("\tRepartidor: ");
         this.mostrar();
         Console.WriteLine( "\t\t- Vehiculo: "+this.vehiculo+ "\n\t\t- Estrellas: "+this.nroEstrellas );
      }
      public int NroEstrellas { get => nroEstrellas; set => nroEstrellas = value; }
   }
}


