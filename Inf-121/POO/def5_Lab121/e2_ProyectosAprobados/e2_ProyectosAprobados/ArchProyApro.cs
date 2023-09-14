using System;
using System.IO;
namespace e2_ProyectosAprobados {
   public class ArchProyApro {
      private string na;
      public ArchProyApro(string na) { this.na = na; }
      public void crear(){ if(File.Exists(na)) {File.Delete(na); } }
      public void adicionar(){
         string sw; 
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryWriter write = new BinaryWriter(file);
         try {
            do {
               ProyectosAprobados proyAprob = new ProyectosAprobados();
               proyAprob.leeProyAprobados();
               write.Seek(0,SeekOrigin.End);
               proyAprob.wProyAprobados(write);
               Console.WriteLine("\n--x-- Desea Continuar s/n --x--");
               Console.Write(" : "); sw = Console.ReadLine();  
            } while (sw == "s");
         }
         catch(Exception ){ Console.WriteLine("\n--x-- End List --x--\n"); }
         finally { file.Close(); }  
      }
      public void listar(){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine(
            "-----------------------------------\n"+
            "|       Proyectos Aprobados       |\n"+
            "-----------------------------------\n");
         try {
            while (true) {
               ProyectosAprobados proyAprob = new ProyectosAprobados();
               proyAprob.rProyAprobados(read);
               proyAprob.mostProyAprobados();
            }
         }
         catch(Exception) {Console.WriteLine("\n--x-- End List --x--\n");}
         finally{ file.Close(); }
      }
      public void mostEmplProy(ArchProyecto archP,ArchEmpleado archE,string x){
         Stream file = File.Open(na,FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("El Proyecto \"{0}\" tiene como empleados: \n",x);
         try {
            while (true) {
               ProyectosAprobados proyAprob = new ProyectosAprobados();
               proyAprob.rProyAprobados(read);
               if(proyAprob.CodProy == archP.buscProy(x)){
                  Console.WriteLine("\t- Al empleado de Nombre:  {0}\n",
                  archE.buscEmpl(proyAprob.CodEmp));
               }
            }
         }
         catch(Exception) {Console.WriteLine("");}
         finally { file.Close(); }
      }
      public void proyAprobado(ArchProyecto archP, ArchEmpleado archE){
         Stream file = File.Open(na, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("Los proyectos Aprobados en \"Mayo\" son: \n ");
         try {
            while (true) {
               ProyectosAprobados proyAprob = new ProyectosAprobados();
               proyAprob.rProyAprobados(read);
               if( proyAprob.Fecha.Contains("Mayo")){
                  Console.WriteLine("\t- El Proyecto: \"{0}\" con el Empleado de Nombre: {1} \n", 
                     archP.buscNProy(proyAprob.CodProy),archE.buscEmpl(proyAprob.CodEmp)        
                  );
               }
            }
         }
         catch (System.Exception) { Console.WriteLine(""); }
         finally{ file.Close(); }
      }

      public void mostListEmpl( ArchProyecto archP, ArchEmpleado archE, string x){
         Stream file = File.Open(na, FileMode.OpenOrCreate);
         BinaryReader read = new BinaryReader(file);
         Console.WriteLine("El proyecto \"{0}\" tiene a los Emplados: \n",x);
         try{
            while(true){
               ProyectosAprobados proyAprob = new ProyectosAprobados();
               proyAprob.rProyAprobados(read);
               if(proyAprob.CodProy == archP.buscProy(x)){ archE.verfEmpleado(proyAprob.CodEmp); }
            }
         }
         catch(Exception){Console.WriteLine(""); }
         finally { file.Close(); }
      }
   }
}
