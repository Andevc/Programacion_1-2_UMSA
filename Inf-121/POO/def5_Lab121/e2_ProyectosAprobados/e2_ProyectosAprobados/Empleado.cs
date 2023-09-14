using System;
using System.IO;
namespace e2_ProyectosAprobados {
   [Serializable]
   public class Empleado {
      private string codEmp, nombre, anioNac;
      public Empleado() { }
      public string CodEmp { get {return this.codEmp; } set { this.codEmp = value;}  }
      public string Nombre { get {return this.nombre; } set { this.nombre = value;}  }
      public string AnioNac { get {return this.anioNac;}  set { this.anioNac = value;} }

      public void leeEmpleado(){
         Console.Write("\t- Cod. Empleado: "); this.codEmp = Console.ReadLine();
         Console.Write("\t- Nombre: "); this.nombre = Console.ReadLine();
         Console.Write("\t- Año Nac: "); this.anioNac = Console.ReadLine();
      }

      public void mostEmpleado(){
         Console.WriteLine("\t Nombre: {1}  \t| Cod. Empleado: {0} \t| Año Nac: {2}",this.codEmp,this.nombre,this.anioNac);
      }
      public void rEmpleado(BinaryReader j ){
         this.codEmp = j.ReadString();
         this.nombre = j.ReadString();
         this.anioNac = j.ReadString();
      }
      public void wEmpleado(BinaryWriter j ){
         j.Write(this.codEmp);
         j.Write(this.nombre);
         j.Write(this.anioNac);
      }
   }
}
