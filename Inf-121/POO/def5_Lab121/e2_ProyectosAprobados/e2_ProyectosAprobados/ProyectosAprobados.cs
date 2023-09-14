using System;
using System.IO;
namespace e2_ProyectosAprobados {
   [Serializable]
   public class ProyectosAprobados {
      private string codEmp, codProy, fecha;
      public ProyectosAprobados() { }

      public string CodEmp { get {return this.codEmp; }  set {this.codEmp = value; }  }
      public string CodProy { get {return this.codProy; }  set {this.codProy = value; }  }
      public string Fecha { get {return this.fecha;  } set {this.fecha = value; }  }

      public void leeProyAprobados(){
         Console.Write("\t- Cod Emp: "); this.codEmp = Console.ReadLine();
         Console.Write("\t- Cod Proy: "); this.codProy = Console.ReadLine();
         Console.Write("\t- Fecha: "); this.fecha = Console.ReadLine();
      }
      public void mostProyAprobados(){
         Console.WriteLine( "\t Cod Emp: "+this.codEmp+ "\t| Cod Proy: "+this.codProy+ "\t| Fecha: "+this.fecha );
      }
      public void rProyAprobados(BinaryReader j ){
         this.codEmp = j.ReadString();
         this.codProy = j.ReadString();
         this.fecha = j.ReadString();
      }
      public void wProyAprobados(BinaryWriter j ){
         j.Write(this.codEmp);
         j.Write(this.codProy);
         j.Write(this.fecha);
      }
   }
}
