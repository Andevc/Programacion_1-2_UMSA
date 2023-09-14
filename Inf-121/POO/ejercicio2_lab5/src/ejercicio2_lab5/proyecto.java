package ejercicio2_lab5;
import java.util.Scanner;
public class proyecto implements java.io.Serializable{
	Scanner lee=new Scanner(System.in);
   private String codProy; 
   private String nombre;
   private int costo;
   public proyecto() {
		codProy="";
		nombre="";
		costo=0;
	}
   public void leerp(){
	   System.out.println("\t\nIngrese el codigo del proyecto");
	   this.codProy=lee.next();
	   System.out.println("\t\nIngrese el nombre del proyecto");
	   this.nombre=lee.next();
	   System.out.println("\t\nIngrese el costo del proyecto");
	   this.costo=lee.nextInt();
   }
   public void mostrarp() {
	   System.out.println("\n\tCODIGO DEL PROYECTO"+this.codProy+
			              "\n\tNOMBRE DEL PROYECTO"+this.nombre+
			              "\n\tCOSTO DEL PROYECTO"+this.costo);
   }
public String getCodProy() {
	return codProy;
}
public void setCodProy(String codProy) {
	this.codProy = codProy;
}
public String getNombre() {
	return nombre;
}
public void setNombre(String nombre) {
	this.nombre = nombre;
}
public int getCosto() {
	return costo;
}
public void setCosto(int costo) {
	this.costo = costo;
}
   

}
