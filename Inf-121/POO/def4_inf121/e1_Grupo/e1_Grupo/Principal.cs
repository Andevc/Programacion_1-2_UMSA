using System;
namespace e1_Grupo{
   public class Principal{
      public static void Main(){
         Console.WriteLine("\n\t Datos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\t CI: 6908109 L.P.\n");
         // a) 
         Grupo g1 = new Grupo("DKBza");
         Persona p1 = new Persona("Pepe", 21, 175);
         Persona p2 = new Persona("Marco", 19, 170);
         Persona p3 = new Persona("Nacho", 20, 180);
         Persona p4 = new Persona("Luis", 21, 170);
         Persona p5 = new Persona("Pedro", 18, 180);
         g1.agregarP(p1); g1.agregarP(p2); g1.agregarP(p3);
         g1.agregarP(p4); g1.agregarP(p5);
         g1.mostrar();
         // b)
         Console.WriteLine("\nLa estatura Promedio es de: "+g1.estProm()+"\n");
         Console.WriteLine("La estatura Promedio es de: "+g1.edadProm()+"\n");
         // c)
         g1.mayEst();

      }
   }
}
