using System;
using System.IO;
namespace e2_ProyectosAprobados {
   public class ArchProyecto {
      private string na;
      public ArchProyecto(string na) { this.na = na; }
      public void crear(){ if(File.Exists(na)) {File.Delete(na); } }
      public void adicionar(){
         string sw;
         Stream file = File.Open(na, FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         try{
            do {
               Proyecto proy = new Proyecto();
               proy.leeProyecto();
               write.Seek(0,SeekOrigin.End);
               proy.wProyecto(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : "); sw = Console.ReadLine();  
            } while (sw == "s");
         }
         catch (Exception) { Console.WriteLine("--x-- FINISH --x-- "); }
         finally { file.Close(); }
      }
      public void listar(){
         Stream file = File.Open(na, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine(
            "-----------------------------------\n"+
            "|            Proyectos            |\n"+
            "-----------------------------------\n");
         try{
            while (true) {
               Proyecto proy = new Proyecto();
               proy.rProyecto(read);
               proy.mostProyecto();
            }
         }
         catch(Exception ){ Console.WriteLine("\n--x-- End List --x--\n"); }
         finally { file.Close(); }
      }
      public string buscProy(String x){
         string cProy = "";
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         try {
            while (true) {
               Proyecto proy = new Proyecto();
               proy.rProyecto(read);
               if(proy.Nombre == x){ cProy = proy.CodProy; }
            }
         }
         catch (Exception){ Console.Write(""); }
         finally{ file.Close(); }
         return cProy;
      }
      public string buscNProy(String x){
         string nProy = "";
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         try {
            while (true) {
               Proyecto proy = new Proyecto();
               proy.rProyecto(read);
               if(proy.CodProy == x){ nProy = proy.Nombre; }
            }
         }
         catch (Exception){  }
         finally{ file.Close(); }
         return nProy;
      }

      

   }
}
