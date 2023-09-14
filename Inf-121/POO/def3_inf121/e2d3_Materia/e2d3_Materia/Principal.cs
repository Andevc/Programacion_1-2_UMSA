using System;
namespace e2d3_Materia
{
   public class Principal{
      public static void eliminar(Materia[] x, int pos, int y){
         for (int i = pos+1; i < y; i++){ x[i-1] = x[i]; }
      }
      public static void Main(){
         Console.WriteLine("\n\tDatos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\tCI: 6908109 L.P.");
         MProgramacionOrientadaObjetos poo = new MProgramacionOrientadaObjetos();
         // A)
         MLaboratorio[] n = new MLaboratorio[20];
         MCatedra[] m = new MCatedra[20];
         int n1 = 3 , m1 = 4;
         for (int i = 0; i < n1; i++){  
            Console.WriteLine("--x----------------------x--");
            Console.WriteLine("\t\tDatos Materia Laboratorio {0} ",i+1);
            n[i] = new MLaboratorio(); 
         }
         //for (int i = 0; i < n1; i++) { n[i].mostrarLab(); }
         for (int i = 0; i < m1; i++){  
            Console.WriteLine("--x----------------------x--");
            Console.WriteLine("\t\tDatos Materia Catedra {0} ",i+1);
            m[i] = new MCatedra(); 
         }
         //for (int i = 0; i < m1; i++) { m[i].mostrarC(); }
         Console.WriteLine("--x------------------------------------x--");
         //B)
         for (int i = 0; i < m1; i++){
            if (m[i].NAulas > 1)
            { Console.WriteLine("\t- El Docente {0} dicta mas de una materia",m[i].NomDoc); }
         }
         //C)
         poo.mayMaterias(n,m,n1,m1);
         Console.WriteLine("--x------------------------------------x--");
         // D)
         int x = 12345;
         for (int i = 0; i < n1; i++){ if(n[i].idDoc == x){ eliminar(n,i, n1); n1--;  }}  
         for (int i = 0; i < n1; i++){ n[i].mostrarLab(); }
         // E)
         Console.WriteLine("--x------------------------------------x--");
         Console.WriteLine("\t Temas POO");
         poo.mostTema();
         Console.ReadKey();
      }      
   }
}
