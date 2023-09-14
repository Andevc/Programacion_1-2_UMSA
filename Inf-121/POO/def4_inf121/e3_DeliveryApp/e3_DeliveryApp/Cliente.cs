using System;
namespace e3_DeliveryApp {
   public class Cliente : Persona {
      private string ubicacion;
      public Cliente(string nom, string ap,int ed, int ci , string ubicacion) : 
      base(nom,ap,ed,ci) 
      { this.ubicacion = ubicacion; }
      public void mostC(){
         Console.WriteLine("\tCliente: ");
         this.mostrar();
         Console.WriteLine("\t\t- Ubicacion: "+this.ubicacion);
      }
   }
}
