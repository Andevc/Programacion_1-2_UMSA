using System;
namespace e3_DeliveryApp {
   public class Persona { 
      protected string nombre, apellido;
      protected int edad, CI;
      public Persona(string nombre,string apellido, int edad, int CI){
         this.nombre = nombre;
         this.apellido = apellido;
         this.edad = edad;
         this.CI = CI;
      }
      public void mostrar(){
         Console.WriteLine(
            "\t\t- Nombre: "+this.nombre+
            "\n\t\t- Apellido: "+this.apellido+
            "\n\t\t- Edad: "+this.edad+
            "\n\t\t- CI: "+this.CI
         );
      }
   }
}
