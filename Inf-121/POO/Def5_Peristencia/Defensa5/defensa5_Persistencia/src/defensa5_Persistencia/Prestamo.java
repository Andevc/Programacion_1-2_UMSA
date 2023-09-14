package defensa5_Persistencia;

import java.util.*;

public class Prestamo implements java.io.Serializable {

     private String nombre, fechaPrestamo, fechaDevolucion;
     private int ci, montoPrestamo, montoDevolucion;

     public String getNombre() {
          return nombre;
     }

     public String getFechaPrestamo() {
          return fechaPrestamo;
     }

     public String getFechaDevolucion() {
          return fechaDevolucion;
     }

     public int getCi() {
          return ci;
     }

     public int getNomtoPrestamo() {
          return montoPrestamo;
     }

     public int getMontoDevolucion() {
          return montoDevolucion;
     }

     public Prestamo() {
     }

     public void mostPrestamo() {
          System.out.println(
                    "\t| " + this.ci + "\t| " + this.nombre + "\t| " + this.montoPrestamo + "\t | " + this.fechaPrestamo +
                              "\t| " + this.montoDevolucion + "\t | " + this.montoDevolucion);
     }

     public void leerReg() {
          Scanner sc = new Scanner(System.in);
          System.out.print("CI: ");
          this.ci = sc.nextInt();
          
          System.out.print("Nombre: ");
          this.nombre = sc.next();

          System.out.print("Monto Prestamo: ");
          this.montoPrestamo = sc.nextInt();
          System.out.print("Fecha Prestamo: ");
          this.fechaPrestamo = sc.next();
          System.out.print("Monto Devolucion: ");
          this.montoDevolucion = sc.nextInt();
          System.out.print("Fecha Devolucion: ");
          this.fechaDevolucion = sc.next();
     }

}
