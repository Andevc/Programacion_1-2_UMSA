using System;
namespace e2d3_Materia{
   public class MCatedra : Materia
   {
      protected int nroAulas;
      public MCatedra() : base()
      { Console.Write("\t- Nro Aulas: "); this.nroAulas = int.Parse(Console.ReadLine()); }

      public MCatedra(string x): base("") { nroAulas = 4; }
      public void mostrarC(){
         base.mostrar();
         Console.WriteLine("\t- Nro Aulas"+this.nroAulas);
      }
      public int NAulas{
         get { return nroAulas; }
         set { nroAulas = value; }
      }
      
   }
}
