using System;
namespace e2_Concurso {
   public class Principal {
      public static void Main() {
         Console.WriteLine("\n\t Datos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\t CI: 6908109 L.P.\n");
         // a)
         Concurso c1 = new Concurso("Concurso de mascotas");
         Acto a1 = new Acto("Perro","Jack",5,76);
         Acto a2 = new Acto("Gato","Tom",4,36);
         Acto a3 = new Acto("Gato","Sasi",5,70);
         c1.adiActo(a1); c1.adiActo(a2);
         c1.adiActo(a3); 
         Console.WriteLine("--x------------------------------x--");
         c1.mostConcurso();
         // b)
         Console.WriteLine("--x------------------------------x--");
         Console.WriteLine("Mascota Ganadora es: ");
         c1.mascotaWin();
         // c)
         Console.WriteLine("--x------------------------------x--");
         Console.WriteLine("Concurso Ordenado Por Puntaje");
         c1.ordConcurso(); c1.mostConcurso();
         // d)
         Console.WriteLine("--x------------------------------x--");
         Acto a4 = new Acto("Perro","Rocky",3,80);
         c1.addActo(a4); c1.mostConcurso();
         // e)
         Console.WriteLine("--x------------------------------x--");
         Concurso c2 = new Concurso("");
         c1.movActo(c2); c2.mostConcurso();

         Console.ReadKey();
      }
   }
}
