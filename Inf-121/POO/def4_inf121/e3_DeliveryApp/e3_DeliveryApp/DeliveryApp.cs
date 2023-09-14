using System;
namespace e3_DeliveryApp {
   public class DeliveryApp {
      private string nombre;
      private int np;
      private Pedido[] P = new Pedido[50];
      public DeliveryApp(string nombre) {
         this.nombre = nombre;
         this.np = 0;
      }
      public void mostDelivery(){
         Console.WriteLine(this.nombre);
         for (int i = 0; i < this.np; i++) { Console.WriteLine("\n\tPedido:"); P[i].mostPedido(); }
      }
      public void adiPedido(Pedido x){ P[this.np] = x; np++; }

      public void mostP(string x){
         for (int i = 0; i < this.np; i++){ if(P[i].Fecha == x){ P[i].mostPedido(); } }
      }
      public void ordPedidos(){
         for (int i = 0; i < this.np; i++) {
            for (int j = 0; j < this.np; j++) {
               if(P[i].Peso > P[j].Peso){ Pedido aux = P[i]; P[i] = P[j]; P[j] = aux; }
            }
         }
      }
      public void repEstrellas(){
         for (int i = 0; i < this.np; i++){
            if(P[i].R.NroEstrellas == 5){ P[i].R.mostR(); }
         }
      }
      public void delPedido(){
         for (int i = 0; i < this.np; i++){
            if(P[i].Curso == "Completado"){  
               for (int j = i+1; j < this.np; j++) { P[j-1] = P[j]; }
               this.np--;
            }
         }
      }
   }
}
