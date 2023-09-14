using System;
namespace e1d3_Curso
{
   public class CPreparatoriaTecnico : CPreparatoria
   {
      private string especialidad;
      public CPreparatoriaTecnico(string especialidad, int nroEstudiantes) : base("VideoJuegos", nroEstudiantes)
      { this.especialidad = especialidad; }
      public void mostrarCPT(){
         Console.WriteLine("\n--x---------------------------------------------x--\n\t\tCurso Preparatoria Tecnica");
         base.mostrar();
         Console.WriteLine("\tEspecialidad: "+this.especialidad);
      }
   }
}
