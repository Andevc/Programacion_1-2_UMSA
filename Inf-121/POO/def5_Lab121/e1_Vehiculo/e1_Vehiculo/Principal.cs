using System;
namespace e1_Vehiculo {
   public class Principal {
      public static void Main() {
         
         Console.WriteLine("\n\t- Datos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\t- CI: 6908109 L.P.");
         
         ArchVehiculo archVh = new ArchVehiculo("archVehiculo.dat");

         //archVh.crear();

         //archVh.adicionar();

         archVh.listar();

         //archVh.Modificar("Toyota");

         //archVh.mostVehiculoPlaca();



         //archVh.contModelo("Corolla");
         

      }
   
   }
}
