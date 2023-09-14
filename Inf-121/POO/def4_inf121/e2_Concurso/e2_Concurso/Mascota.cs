using System;
namespace e2_Concurso {
   public class Mascota {
      private string tipo, nombre;
      private int edad;
      public Mascota(string tipo, string nombre, int edad) {
         this.tipo = tipo;
         this.nombre = nombre;
         this.edad = edad;
      }
      public int Edad { get => edad; set => edad = value; }
      public void mostrar(){
         Console.WriteLine(
            "\t- Tipo: "+this.tipo+
            "\n\t- Nombre: "+this.nombre+
            "\n\t- Edad: "+this.edad+"\n"
         );
      }
   }
}
