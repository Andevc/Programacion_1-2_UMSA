using System;
namespace e2d3_Materia{
   public class MLaboratorio :Materia
   {
      private int nroLab, cantidadCompu;
      private string requerimientos;
      public MLaboratorio() : base(){
         Console.Write("\t- Nro Lab: "); this.nroLab = int.Parse(Console.ReadLine());
         this.cantidadCompu = 20;
         this.requerimientos = "Tener R.U.";
      }
      public void mostrarLab(){
         Console.WriteLine("--x------------------------x--\n\tMateria Laboratorio");
         base.mostrar();
         Console.WriteLine(
            "\n\t- Nro Lab: "+this.nroLab+
            "\n\t- Cantidad PC: "+this.cantidadCompu+
            "\n\t- Requerimientos: "+this.requerimientos+"\n"
         );
      }     
   }
}
