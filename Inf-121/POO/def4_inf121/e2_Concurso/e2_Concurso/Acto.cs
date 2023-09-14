using System;
namespace e2_Concurso {
   public class Acto {
      private int puntaje;
      private Mascota m;
      public Acto(string tipo, string nombre, int edad,int puntaje){ 
         this.puntaje = puntaje; 
          m = new Mascota(tipo,nombre,edad);
      }
      public void mostActo(){
         Console.WriteLine("\tActo: \n\t- Puntaje: "+this.puntaje);
         m.mostrar();
      }
      public int Puntaje { get => puntaje; set => puntaje = value; }
      public Mascota M { get => m; set => m = value; }
   }
}








