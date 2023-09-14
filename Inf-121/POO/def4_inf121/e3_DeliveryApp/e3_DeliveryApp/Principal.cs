using System;
namespace e3_DeliveryApp {
   public class Principal { 
      public static void Main() { 
         Console.WriteLine("\n\t Datos Estudiante: Cristhian Andres Escobar Herrera");
         Console.WriteLine("\t CI: 6908109 L.P.\n");
         DeliveryApp apk1 = new DeliveryApp("Delivery App"); 
         
         Pedido p1 = new Pedido( "Leo","Diario",22,14532,"moto",5, "Zoyla","Vaca",25,78434,"Satelite", 1,25,"Pendiente","11/05/2023" );
         Pedido p2 = new Pedido( "Victor","Tazo",30,13764,"carro",4, "Ines","Oria",30,24781,"Sagarnaga", 2,45,"Completado","02/03/2023" );
         Pedido p3 = new Pedido( "Elvis","Nieto",28,19374,"moto",5, "Susana","Tito",39,84792,"Zona Sur", 3,20,"Completado","11/05/2023" );
         
         apk1.adiPedido(p1); apk1.adiPedido(p2); apk1.adiPedido(p3); apk1.mostDelivery();
         // a)
         Console.WriteLine("-----------------------------------------");
         apk1.mostP("11/05/2023");
         // b)
         Console.WriteLine("-----------------------------------------");
         apk1.ordPedidos(); apk1.mostDelivery();
         // c)
         Console.WriteLine("-----------------------------------------");
         apk1.repEstrellas();
         // d)
         Console.WriteLine("-----------------------------------------");
         apk1.delPedido(); apk1.mostDelivery();

         Console.ReadKey();
      }
   }
}
