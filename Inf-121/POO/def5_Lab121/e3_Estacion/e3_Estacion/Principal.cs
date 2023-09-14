using System;
namespace e3_Estacion {
   public class Principal {
      public static void Main() {

         Console.WriteLine("\n\tDatos Estudiantes: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\tCI: 6908109 L.P.");

         ArchEstacion aEst = new ArchEstacion("ArchEstacion.dat");
         aEst.crear();
         aEst.adicionar();
         aEst.listar();
         aEst.mostPlaca();
         aEst.verfPasajero("Jhon","APK-345");

         Console.WriteLine("\n\n");
         
      }
   }
}
