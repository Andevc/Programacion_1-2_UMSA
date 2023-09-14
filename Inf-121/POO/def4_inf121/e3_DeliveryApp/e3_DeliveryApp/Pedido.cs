using System;
namespace e3_DeliveryApp{
   public class Pedido {
      private int nroPedido, peso;
      private string curso, fecha;
      private Cliente c;
      private Repartidor r;
      public Pedido(
         string nomR, string apR, int edadR, int ciR,string autoR , int estrellas,
         string nomC, string apC, int edadC, int ciC, string ubi,
         int nroPedido, int peso, string curso, string fecha
      ){ 
         this.nroPedido = nroPedido;
         this.peso = peso;
         this.curso = curso;
         this.fecha = fecha;
         c = new Cliente(nomC,apC, edadC, ciC,ubi);
         r = new Repartidor(nomR,apR,edadR,ciR,autoR, estrellas);  
      }
      public void mostPedido(){
         Console.WriteLine(
            "\t- Nro Pedido: "+this.nroPedido+ "\n\t- Peso: "+this.peso+
            "\n\t- Curso: "+this.curso+ "\n\t- Fecha: "+this.fecha+"\n"
         );
         c.mostC(); r.mostR(); 
      }
      public int Peso { get => peso; set => peso = value; }
      public Repartidor R { get => r; set => r = value; }
      public string Curso { get => curso; set => curso = value; }
      public string Fecha { get => fecha; set => fecha = value; }
   }
}


