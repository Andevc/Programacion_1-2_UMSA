using System;
namespace e1d3_Curso
{
   public class CPreparatoria : Curso
   {
      protected string modulo;
      public CPreparatoria(string modulo,int nroEstudiantes) : base(
         1234,
         "Cochabamba",
         "3",
         "Daniel Choque",
         "Freddy Gamboa",
         284756,
         nroEstudiantes)
      { this.modulo = modulo; }
      public void mostrar(){
         base.mostrar();
         Console.WriteLine("\tModulo: "+this.modulo);
      }
   }
}
