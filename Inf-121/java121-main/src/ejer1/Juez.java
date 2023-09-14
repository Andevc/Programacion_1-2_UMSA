package ejer1;
import java.util.*;

public class Juez implements java.io.Serializable {
	
	private String nombre, licencia;
	private int nroCaso;
	private String[] codCasos = new String[50];
	

	
	public void LeeJuez( ) {
		
		System.out.println("--x-- Juez --x--");
		Scanner lee = new Scanner(System.in);
			System.out.print("Nombre: "); this.nombre = lee.next();
			System.out.print("Licencia: "); this.licencia = lee.next();
			System.out.print("Nro Caso: "); this.nroCaso = lee.nextInt();
			for (int i = 0; i < this.nroCaso; i++) {
				System.out.print("Cod. Casos: "); this.codCasos[i] = lee.next();
			}
		
	}
	
	public void MostJuez() {
		System.out.println("Nombre: " + this.nombre );
		System.out.println("Licencia: " + this.licencia );
		System.out.println("Nro Caso: " + this.nroCaso );
		for (int i = 0; i < this.nroCaso; i++) {
			System.out.println("Cod. Casos: " + this.codCasos[i] );
		}
	}
	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getLicencia() {
		return licencia;
	}

	public void setLicencia(String licencia) {
		this.licencia = licencia;
	}

	public int getNroCaso() {
		return nroCaso;
	}

	public void setNroCaso(int nroCaso) {
		this.nroCaso = nroCaso;
	}

	public String[] getCodCaso() {
		return codCasos;
	}

	public void setCodCaso(String[] codCaso) {
		this.codCasos = codCaso;
	}	
}
