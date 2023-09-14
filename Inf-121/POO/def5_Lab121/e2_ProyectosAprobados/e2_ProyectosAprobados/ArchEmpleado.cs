using System;
using System.IO;
namespace e2_ProyectosAprobados {
   public class ArchEmpleado {
      private string na;
      public ArchEmpleado(string na) { this.na = na; }
      public void crear(){ if(File.Exists(na)) {File.Delete(na); } }
      public void adicionar(){
         string sw;
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         try {
            do {
               Empleado empl = new Empleado();
               empl.leeEmpleado();
               write.Seek(0,SeekOrigin.End);
               empl.wEmpleado(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : "); sw = Console.ReadLine();               
            } while (sw == "s");  
         }
         catch (Exception) { Console.WriteLine("--x-- FINISH --x-- "); }
         finally { file.Close(); }
      }
      public void listar(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine(
            "-----------------------------------\n"+
            "|             Empleados           |\n"+
            "-----------------------------------\n");
         try {
            while (true) {
               Empleado empl = new Empleado();
               empl.rEmpleado(read);
               empl.mostEmpleado();
            }
         }
         catch(Exception ){ Console.WriteLine("\n--x-- End List --x--\n"); }
         finally { file.Close(); }
      }
      public string buscEmpl(String x){
         string nomEmpl = "";
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         try {
            while (true) {
               Empleado empl = new Empleado();
               empl.rEmpleado(read);
               if(empl.CodEmp == x){ nomEmpl = empl.Nombre; }
            }
         }
         catch (Exception){ }
         finally{ file.Close(); }
         return nomEmpl;
      }

      public void verfEmpleado(string codEmp){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         try {
            while(true){
               Empleado empl = new Empleado();
               empl.rEmpleado(read);
               if(empl.CodEmp == codEmp){ if(verfEdad(empl.AnioNac) ){ empl.mostEmpleado(); } }
            }
         }
         catch (Exception) {  }
         finally{ file.Close(); }
      }
      public bool verfEdad(string fecha){
         if((2023-int.Parse(fecha.Substring(fecha.LastIndexOf(' ') + 1))) < 35){ return true; }
         return false;
      }


      
   }
}
