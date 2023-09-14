package ejercicio2_lab5;

import java.util.Scanner;

public class ProyectosAprobados implements java.io.Serializable{
	Scanner lee=new Scanner(System.in);
    private String codEmp;
    private String codProy;
    private String fecha;
	public ProyectosAprobados() {
		codEmp="";
		codProy="";
		fecha="";
	}
	 public void leerap(){
		   System.out.println("\t\nIngrese el codigo del proyecto");
		   this.codProy=lee.next();
		   System.out.println("\t\nIngrese el codigo del empleado");
		   this.codEmp=lee.next();
		   System.out.println("\t\nIngrese la fecha del proyecto aprobado");
		   this.fecha=lee.next();
	   }
	   public void mostrarap() {
		   System.out.println("\n\tCODIGO DEL PROYECTO: "+this.codProy+
				              "\n\tCODIGO DEL EMPLEADO: "+this.codEmp+
				              "\n\tFECHA DEL PROYECTO APROBADO: "+this.fecha);
	   }

}
