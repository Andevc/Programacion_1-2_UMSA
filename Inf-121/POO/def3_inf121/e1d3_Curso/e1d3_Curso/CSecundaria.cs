using System;
namespace e1d3_Curso
{
   public class CSecundaria : Curso
   {
      private char paralelo;
      private string nomMateria;
      public CSecundaria(char paralelo, string nomMateria, int nroEstudiantes) : base(
         3333,
         "Santa Cruz de la Sierra", 
         "5", 
         "Vitor Apaza", 
         "Simon Vargas", 
         847365, 
         nroEstudiantes)
      {
         this.paralelo = paralelo;
         this.nomMateria = nomMateria;
      }
      public void mostrarCS(){
         Console.WriteLine("\n--x---------------------------------------------x--\n\t\tCurso Secundaria");
         base.mostrar();
         Console.WriteLine("\tParalelo: {0} \n\tNombre Materia: {1}",this.paralelo,this.nomMateria);
      }
   }
}
