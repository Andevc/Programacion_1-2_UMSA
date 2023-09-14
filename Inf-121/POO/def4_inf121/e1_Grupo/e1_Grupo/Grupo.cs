using System;
namespace e1_Grupo{
   public class Grupo{
      private string nombreGrupo;
      private int np;
      private Persona[] p = new Persona[50];
      public Grupo(string nombreGrupo) {
         this.nombreGrupo = nombreGrupo;
         this.np = 0;
      }
      public void mostrar(){
         Console.WriteLine("Nombre: {0}",this.nombreGrupo);
         for (int i = 0; i < this.np; i++){ p[i].mostrar(); }
      }
      public void agregarP(Persona x){ p[this.np] = x; np++; }
      public int estProm(){
         int s = 0;
         for (int i = 0; i < this.np; i++) { s = s + p[i].Estatura; }
         return s / this.np;
      }
      public int edadProm(){
         int s = 0;
         for (int i = 0; i < this.np; i++) { s = s + p[i].Edad; }
         return s / this.np;
      }

      public void mayEst(){
         int x = estProm();
         Console.WriteLine("Estas personas tienen estatura mayor al promedio: \n");
         for (int i = 0; i < this.np; i++) {
            if(p[i].Estatura > x){ p[i].mostrar();}
         }
      }
      public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
      public int Np { get => np; set => np = value; }
      
   }
}
