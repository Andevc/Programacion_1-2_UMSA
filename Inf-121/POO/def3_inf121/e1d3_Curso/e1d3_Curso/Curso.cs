using System;
namespace e1d3_Curso
{
   public class Curso
   {
      protected int id, nroEstudiantes, ciProfesor;
      protected string nomDirector, nroDistrito, ciudad, nomProfesor;
      protected string[,] estudiantes = new string[3,50];
      public Curso(int id, string ciudad, string nroDistrito, string nomDirector, string nomProfesor, int ciProfesor, int nroEstudiantes)
      {
         this.id = id;
         this.ciudad = ciudad;
         this.nroDistrito = nroDistrito;
         this.nomDirector = nomDirector;
         this.nomProfesor = nomProfesor;
         this.ciProfesor = ciProfesor;
         this.nroEstudiantes = nroEstudiantes;
         for (int i = 0; i < this.nroEstudiantes; i++){
            Console.WriteLine("-x- Introduzca Datos del Estudiante {0} -x-",i+1);
            Console.Write("\t- Nombre: ");
            estudiantes[0,i] = Console.ReadLine();
            Console.Write("\t- CI: ");
            estudiantes[1,i] = Console.ReadLine();
            Console.Write("\t- Edad: ");
            estudiantes[2,i] = Console.ReadLine();
         }
      }
      public void mostrar(){
         Console.WriteLine(
            "\n\tId: "+this.id+
            "\n\tCiudad: "+this.ciudad+
            "\n\tNro Distrito: "+this.nroDistrito+
            "\n\tNombre Director: "+this.nomDirector+
            "\n\tNombre Profesor: "+this.nomProfesor+
            "\n\tCi Profesor: "+this.ciProfesor+
            "\n\tNro Estudiantes: "+this.nroEstudiantes
         );
         for (int i = 0; i < this.nroEstudiantes; i++){
            Console.WriteLine("\t| "+estudiantes[0,i]+"\t| "+estudiantes[1,i]+"\t| "+estudiantes[2,i]+"\t|");
         }
      }              
      public void mayEstudiantes(Curso y){
         int c1 = 0, c2 = 0;
         for (int i = 0; i < nroEstudiantes; i++){ if(int.Parse(estudiantes[2,i]) >= 18){ c1++; } }
         for (int i = 0; i < y.nroEstudiantes; i++){ if(int.Parse(y.estudiantes[2,i]) >= 18){ c2++; } }
         if( c1 >  c2){
            Console.WriteLine("\n\tEl curso del Profesor: {0} tiene mas estudiantes de mayor edad",this.nomProfesor);
         }else{
            Console.WriteLine("\n\tEl curso del Profesor: {0} tiene mas estudiantes de mayor edad",y.nomProfesor);
         }
      }
      public void ciudadEst(int x){
         if(this.ciudad == "Santa Cruz de la Sierra" ){
            bool sw = false;
            for (int i = 0; i < this.nroEstudiantes; i++){
               if( int.Parse(estudiantes[1,i]) == x){
                  Console.WriteLine("\tEl estudiante de nombre {0} esta en Santa Cruz de la Sierra", this.estudiantes[0,i]);
                  sw = true;
               }
            }
            if(!sw){ Console.WriteLine("\tEl CI {0} no esta en Santa Cruz de la Sierra",x);}
         }         
      }
      public bool esPrimo(int x){
         int k = 2;
         while ( x % k != 0 && k <= (int)x/2) { k++; }
         if(k > (int)x/2){ return true;} 
         return false;
      }
      public bool esCapicua(int x){
         int d = 0, y = 0, p = x;
         while(x != 0){ d = x % 10; x = x / 10; y = (y*10)+d; }
         if( p == y){ return true; }
        return false; 
      }
      public void eliminarEst(){
         for (int i = 0; i < this.nroEstudiantes; i++){
            if( esCapicua(int.Parse(estudiantes[1,i])) || esPrimo(int.Parse(estudiantes[2,i]))){
               eliminar(i); this.nroEstudiantes--;
            }
         }
      }
      public void eliminar(int i){
         for (int j = i+1; j < nroEstudiantes; j++){
            estudiantes[0,j-1] = estudiantes[0,j];
            estudiantes[1,j-1] = estudiantes[1,j];
            estudiantes[2,j-1] = estudiantes[2,j];      
         }
      }     
      public int nEstudiantes{
         get { return nroEstudiantes; }
         set { nroEstudiantes = value; }
      }    
      public bool menEstudiantes(Curso x){
         if (this.nroEstudiantes <= x.nroEstudiantes) { return true; }
         return false;
      }  
      public void agregarEst(int x){
         for (int i = this.nroEstudiantes; i < this.nroEstudiantes+x; i++){
            Console.WriteLine("-x- Introduzca Datos del Estudiante  a Agregar -x-");
            Console.Write("\t- Nombre: "); estudiantes[0,i] = Console.ReadLine();
            Console.Write("\t- CI: "); estudiantes[1,i] = Console.ReadLine();
            Console.Write("\t- Edad: "); estudiantes[2,i] = Console.ReadLine();  
         }
         nEstudiantes = nEstudiantes + x ;
      }
   }
}