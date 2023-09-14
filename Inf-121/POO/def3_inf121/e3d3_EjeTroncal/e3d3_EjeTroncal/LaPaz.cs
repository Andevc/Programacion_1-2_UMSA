using System;
namespace e3d3_EjeTroncal
{

   public class LaPaz : EjeTroncal
   {
      private int nroNevados;
      private string[] nevado = new string[20];
      public LaPaz() : base(472, "10130","Andina","Pepe","20","Murillo",10)
      {
         nroLinTeleferico = 10;
         nroNevados = 4;
         nevado[0] = "Illimani";
         nevado[1] = "Mururata";
         nevado[2] = "Illampu";
         nevado[3] = "Huayna Potosi";
      }
      public void mNevados(){
         Console.WriteLine("--x--------------------------------------x--");
         Console.WriteLine("--x-- Nevados --x--");
         for (int i = 0; i < nroNevados; i++){ Console.WriteLine("\t-"+nevado[i]); }
      }
   }
}
