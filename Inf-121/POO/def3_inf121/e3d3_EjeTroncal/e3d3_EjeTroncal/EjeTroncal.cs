using System;
namespace e3d3_EjeTroncal
{
   public class EjeTroncal
   {
      protected double superficie;
      protected string poblacion, zona, nomGobernador, nroProvincias, ciudadCapitalina;
      protected int nroLinTeleferico;
      public EjeTroncal(double superficie, string poblacion,string zona, string nomGobernador, string nroProvincias, string ciudadCapitalina, int nroLinTeleferico)
      {
         this.superficie = superficie;
         this.poblacion = poblacion;
         this.zona = zona;
         this.nomGobernador = nomGobernador;
         this.nroProvincias = nroProvincias;
         this.ciudadCapitalina = ciudadCapitalina;
         this.nroLinTeleferico = nroLinTeleferico;
      }
      public void mostrar(){
         Console.WriteLine("--x--------------------------------------------------x--");
         Console.WriteLine(
            "\n\tPoblacion: "+this.poblacion+
            "\n\tSuperficie: "+this.superficie+
            "\n\tZona: "+this.zona+
            "\n\tNombre Gobernador: "+this.nomGobernador+
            "\n\tNro Provincias: "+this.nroProvincias+
            "\n\tCiudad Capital: "+this.ciudadCapitalina
            );
      }     
      public string tamPoblcion
      {
         get { return poblacion; }
         set { poblacion = value; }
      }
      public void incPoblacion(){
         double pblacion = int.Parse(poblacion)+ (int.Parse(poblacion) * 0.15);
         tamPoblcion = pblacion.ToString();
      }
      public void maySuperficie(EjeTroncal y, EjeTroncal z){
         if( this.superficie > y.superficie && this.superficie > z.superficie)
         { incPoblacion(); mostrar();}
         else if (y.superficie > this.superficie && this.superficie > z.superficie )
         { y.incPoblacion(); y.mostrar();}
         else if (z.superficie > this.superficie && z.superficie > y.superficie)
         { z.incPoblacion(); z.mostrar();}
      }
      public bool verfTeleferico(){
         if( this.nroLinTeleferico > 0){ return true; }
         return false;
      }
   }
}
