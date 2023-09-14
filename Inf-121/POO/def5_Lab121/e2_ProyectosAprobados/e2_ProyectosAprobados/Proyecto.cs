using System;
using System.IO;
namespace e2_ProyectosAprobados {
   [Serializable]
   public class Proyecto {
      private string codProy, nombre;
      private int costo;
      public Proyecto() { }
      public string CodProy { get {return  this.codProy; } set { this.codProy = value; } }
      public string Nombre { get {return  this.nombre;} set { this.nombre = value; } }
      public int Costo { get {return  this.costo; } set { this.costo = value; } }
      public void leeProyecto(){
         Console.Write("\t- Cod. Proy: "); this.codProy = Console.ReadLine();
         Console.Write("\t- Nombre: "); this.nombre = Console.ReadLine();
         Console.Write("\t- Costo: "); this.costo = int.Parse(Console.ReadLine());
      }
      public void mostProyecto(){
         Console.WriteLine( "\t Cod Proyecto: "+ this.codProy+ "\t| Nombre: "+ this.nombre+ "\t\t| Costo: "+ this.costo );
      }
      public void rProyecto(BinaryReader j){
         this.codProy = j.ReadString();
         this.nombre = j.ReadString();
         this.costo = j.ReadInt32();
      }
      public void wProyecto(BinaryWriter j){
         j.Write(this.codProy);
         j.Write(this.nombre);
         j.Write(this.costo);
      }
   }
}
