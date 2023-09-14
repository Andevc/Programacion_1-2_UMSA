using System;
namespace e2d3_Materia{
   public class Materia{
      protected string sigla, nombre, paralelo, tipo, carreraPerteneciente, modalidad, nomDocente;
      protected int cargaHoraria, idDocente ;
      public Materia(){  
         Console.Write("\n\t- Sigla: "); sigla = Console.ReadLine();
         Console.Write("\t- Nombre: "); nombre = Console.ReadLine();
         Console.Write("\t- Tipo: "); tipo = Console.ReadLine();
         Console.Write("\t- Carrera: "); carreraPerteneciente = Console.ReadLine();
         Console.Write("\t- Modalidad: "); modalidad = Console.ReadLine();
         Console.Write("\t- Docente: "); nomDocente = Console.ReadLine();
         Console.Write("\t- Carga Horaria: "); cargaHoraria = int.Parse(Console.ReadLine());
         Console.Write("\t- Id Docente: "); idDocente = int.Parse(Console.ReadLine());
      }
      public Materia(string x){
         sigla = "121";
         nombre = "POO";
         tipo = "Troncal";
         carreraPerteneciente = "Informatica";
         modalidad = "Precencial";
         nomDocente = "Pepe";
         cargaHoraria = 50;
         idDocente = 139382;
      }
      public void mostrar(){
         Console.Write(
            "\n\t- Sigla: "+this.sigla+
            "\n\t- Nombre: "+this.nombre+
            "\n\t- Tipo: "+this.tipo+
            "\n\t- Carrera: "+this.carreraPerteneciente +
            "\n\t- Modalidad: "+this.modalidad+
            "\n\t- Docente: "+this.nomDocente+
            "\n\t- Carga Horaria: "+this.cargaHoraria+
            "\n\t- Id Docente: "+this.idDocente );
      }
      public string NomDoc{
         get { return nomDocente; }
         set { nomDocente = value; }
      }
      public int idDoc{
         get { return idDocente; }
         set { idDocente = value; }
      }
      public void mayMaterias( Materia[] x, Materia[] y, int n, int m){
         int fis = 0, mat = 0, est = 0, inf = 0;
         fis = contMateria(x,"Fisica",n) + contMateria(y,"Fisica",m);
         mat = contMateria(x,"Matematica",n) + contMateria(y,"Matematica",m);
         est = contMateria(x,"Estadistica",n) + contMateria(y,"Estadistica",m);
         inf = contMateria(x,"Informatica",n) + contMateria(y,"Informatica",m);
         if(mMat(fis)){Console.WriteLine("\t- La Carrera de Fisica tiene {0} materias",fis);}
         if(mMat(mat)){Console.WriteLine("\t- La Carrera de Matematica tiene {0} materias",mat);}
         if(mMat(est)){Console.WriteLine("\t- La Carrera de Estadistica tiene {0} materias",est);}
         if(mMat(inf)){Console.WriteLine("\t- La Carrera de Informatica tiene {0} materias",inf);}
      }
      public int contMateria(Materia[] v, string w, int n){
         int c = 0;
         for (int i = 0; i < n; i++){ if (v[i].carreraPerteneciente == w) { c++; } }
         return c;
      }
      public bool mMat(int x){ if(x > 1){ return true;} return false; }      
   }
}
