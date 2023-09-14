using System;
namespace e3d3_EjeTroncal
{
   public class Principal
   {
      public static void Main()
      {
         Console.WriteLine("\nDatos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("CI: 6908109 L.P. ");
         LaPaz lp = new LaPaz();
         SantaCruz sc = new SantaCruz();
         Cochabamba cb = new Cochabamba();
         lp.mostrar();
         sc.mostrarSc();
         cb.mostrar();
         lp.maySuperficie(sc,cb);
         lp.mNevados();
         sc.anlillosIncre(5);
         sc.mostrarSc();
         Console.WriteLine("--x-----------------------x--");
         if(lp.verfTeleferico()){ Console.WriteLine("\t- La Paz tiene teleferico");}
         if(sc.verfTeleferico()){ Console.WriteLine("\t- Santa Cruz tiene teleferico");}
         if(cb.verfTeleferico()){ Console.WriteLine("\t- Cochabamba tiene teleferico");}  
         Console.ReadKey();
      }
   }
}
