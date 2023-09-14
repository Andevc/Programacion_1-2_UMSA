using System;
namespace e1d3_Curso
{
   public class Principal
   {
      public static void Main(){
         Console.WriteLine("\n\n\tDatos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\tCI: 6908109 L.P.\n\n");
         // A)         
         CSecundaria cs = new CSecundaria('A', "Quimica",2);
         CPreparatoriaTecnico cpt = new CPreparatoriaTecnico("Desarrollo de Software",4);
         cs.mostrarCS();
         cpt.mostrarCPT();
         // B)
          cs.mayEstudiantes(cpt);
         // C)
         int ci = 123456;
         cs.ciudadEst(ci);
         cpt.ciudadEst(ci);
         // D) 
         cpt.eliminarEst();
         cpt.mostrarCPT();
         // E)
         int k = 3;
         if (cs.menEstudiantes(cpt)){ cs.agregarEst(k); cs.mostrarCS();}
         else{ cpt.agregarEst(k); cpt.mostrarCPT(); } 
         Console.ReadKey();
      }
   }
}
