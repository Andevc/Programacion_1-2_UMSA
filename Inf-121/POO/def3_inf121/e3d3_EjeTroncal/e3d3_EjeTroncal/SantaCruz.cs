using System;
namespace e3d3_EjeTroncal
{
   public class SantaCruz : EjeTroncal
   {
      private int nroAnillos;
      public SantaCruz() : base(325.6,"34122","Llanos","Alan","15","",0 )
      { nroAnillos = 5; }      
      public int NroAnillos{
         get { return nroAnillos; }
         set { nroAnillos = value; }
      }
      public void anlillosIncre(int x){ NroAnillos = NroAnillos+x; } 

      public void mostrarSc(){
         base.mostrar();
         Console.WriteLine("\t Nro Anillos: "+ this.nroAnillos);
      }     
   }
}
