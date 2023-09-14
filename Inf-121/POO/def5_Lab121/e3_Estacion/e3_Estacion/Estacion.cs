using System;
using System.IO;
namespace e3_Estacion {
   [Serializable]
   public class Estacion {
      private string nombre, ubicacion;
      private int nroBuses;
      private Bus[] buses = new Bus[50];
      public Estacion() {
         this.nombre = "Estacion Central";
         this.ubicacion = "Centro de la Ciudad";
         this.nroBuses = 5;
         buses[0] = new Bus("ABC-123","Juan Lopez",5);
         buses[1] = new Bus("CDE-456","Diego Ramirez",5);
         buses[2] = new Bus("FGH-789","Alan Brito",6);
         buses[3] = new Bus("IJK-012","Laura Rodriguez",7);
         buses[4] = new Bus("LMN-345","Ana Gomez",4);
      }
      public Estacion(string nombre) {
         this.nombre = nombre;
         this.ubicacion = "Plaza España";
         this.nroBuses = 6;
         buses[0] = new Bus("OPQ-123","Andres Ruiz",4);
         buses[1] = new Bus("RST-456","Luis Torrez",5);
         buses[2] = new Bus("UVW-789","Javier Ortega",6);
         buses[3] = new Bus("XYZ-012","Laura Rodriguez",8);
         buses[4] = new Bus("APK-345","Carmen Gomez",4);
         buses[5] = new Bus("FLS-782","Jorge Delgado",6);
      }
      public string Nombre { get { return this.nombre;  }  set { this.nombre = value; }  }
      public string Ubicacion { get { return this.ubicacion;  }  set { this.ubicacion = value; }  }
      public int NroBuses { get { return this.nroBuses;  }  set { this.nroBuses = value; }  }
      public Bus[] Buses { get { return this.buses;  }  set { this.buses = value; }  }
      public void mostEstacion(){
         Console.WriteLine("\tNombre: {0} \t| Ubicacion: {1}",this.nombre,this.ubicacion);
         Console.WriteLine("\tBuses: "); for (int i = 0; i < this.nroBuses; i++) { buses[i].mostBus(); }
      }
      public void rEstacion(BinaryReader j){
         this.nombre = j.ReadString(); this.ubicacion = j.ReadString(); this.nroBuses = j.ReadInt32();
         for (int i = 0; i < this.nroBuses; i++) { this.buses[i].rBus(j); }
      }
      public void wEstacion(BinaryWriter j ){
         j.Write(this.nombre); j.Write(this.ubicacion); j.Write(this.nroBuses);
         for (int i = 0; i < this.nroBuses; i++) { this.buses[i].wBus(j); }
      }
   }
}
