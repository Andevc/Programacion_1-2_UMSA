using System;
namespace e2d3_Materia {
   public class MProgramacionOrientadaObjetos :  MCatedra
   {
      private string[] temas = new string[5];
      public MProgramacionOrientadaObjetos() : base("")
      {
         temas[0] = "Clases y Objetos";
         temas[1] = "Consturctores y Destructores";
         temas[2] = "Polimorfismo";
         temas[3] = "Sobrecarga de operadores";
         temas[4] = "Herencia simple";
      }
      public void mostTema(){
         for (int i = 0; i < 3; i++) { Console.Write("\t| "+this.temas[i]); }
         Console.WriteLine();
      }
   }
}
