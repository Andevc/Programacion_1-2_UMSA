package ejercicio2_lab5;

import java.util.Scanner;

public class empleado implements java.io.Serializable{
	Scanner lee=new Scanner(System.in);
	private String codEmp;
	private String nombre;
	private String añoNac;
     public empleado(){
    	 codEmp="";
    	 nombre="";
    	 añoNac="";
     }
     public void leere() {
       System.out.println("\t\nIngrese el codigo del proyecto");
  	   this.codEmp=lee.next();
  	   System.out.println("\t\nIngrese el nombre del proyecto");
  	   this.nombre=lee.next();
  	   System.out.println("\t\nIngrese el costo del proyecto");
  	   this.añoNac=lee.next();
     }
     public void mostrare() {
    	 System.out.println("\n\tCODIGO DEL PROYECTO: "+this.codEmp+
	              "\n\tCODIGO DEL EMPLEADO: "+this.nombre+
	              "\n\tFECHA DEL PROYECTO APROBADO: "+this.añoNac);
     }
}
