using System;
namespace e2_Concurso {
   public class Concurso {
      private string nombre; 
      private int na;
      private Acto[] A = new Acto[50]; 
      public Concurso(string nombre) {
         this.nombre = nombre; 
         this.na = 0; 
      }
      public void adiActo(Acto x){ A[this.na] = x; na++; }

      public void mostConcurso(){
         Console.WriteLine( "Concurso: "+ "\n- Nombre: "+this.nombre+"\n");
         for (int i = 0; i < this.na; i++) { A[i].mostActo(); }
      }

      public void mascotaWin(){
         int may = 0, pos = 0;
         for (int i = 0; i < this.na; i++) 
         { if(A[i].Puntaje > may){ may = A[i].Puntaje; pos = i; } }
         A[pos].M.mostrar();
      }

      public void ordConcurso(){
         for (int i = 0; i < this.na; i++) {
            for (int j = i+1; j < this.na; j++) {
               if(A[i].Puntaje > A[j].Puntaje){ Acto aux = A[i]; A[i] = A[j]; A[j] = aux; }
            }
         }
      }
      public void addActo(Acto x){ adiActo(x); ordConcurso(); }
      public void movActo(Concurso x){
         for (int i = 0; i < this.na; i++)
         { if(A[i].M.Edad < 5){ x.A[x.na] = A[i]; x.na++; } }
      }
   }
}
