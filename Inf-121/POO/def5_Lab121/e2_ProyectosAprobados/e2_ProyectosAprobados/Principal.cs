using System;
namespace e2_ProyectosAprobados {
   public class Principal {
      public static void Main(){
         Console.WriteLine("\n- Datos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("- CI: 6908109 L.P. \n");

         ArchEmpleado archEmpl = new ArchEmpleado("empleados.dat");
         ArchProyecto archProy = new ArchProyecto("proyectos.dat");
         ArchProyApro archPrAp = new ArchProyApro("proyAprob.dat");

         //archEmpl.crear(); archProy.crear(); archPrAp.crear();

         //archEmpl.adicionar();  archProy.adicionar(); archPrAp.adicionar(); 

         archEmpl.listar(); archProy.listar(); archPrAp.listar();
         // B)
         archPrAp.mostEmplProy(archProy,archEmpl, "Diseño Ui/Ux Movil");
         // C)
         archPrAp.proyAprobado(archProy, archEmpl);
         // D)
         archPrAp.mostListEmpl(archProy,archEmpl, "Estrategia MKT");


      }
   }
}
