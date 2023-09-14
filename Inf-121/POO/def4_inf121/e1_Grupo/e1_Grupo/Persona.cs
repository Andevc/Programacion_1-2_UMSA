using System;
namespace e1_Grupo {
   public class Persona {
      private string nombre;
      private int edad, estatura;
      public Persona(string nombre, int edad, int estatura) {
         this.nombre = nombre;
         this.edad = edad;
         this.estatura = estatura;
      }
      public void mostrar(){
         Console.WriteLine(
            "\tPersona: "+
            "\n\t- Nombre: "+this.nombre+
            "\n\t- Edad: "+this.edad+
            "\n\t- Estatura: "+this.estatura+"\n"
         );
      }
      public int Estatura { get => estatura; set => estatura = value;  }
      public int Edad { get => edad; set => edad = value; }      
   }
}
