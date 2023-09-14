package defensa5_Persistencia;

import java.io.IOException;

public class Principal {

	public static void main(String[] args) throws ClassNotFoundException, IOException {
		
		ArchPrestamo archPres = new ArchPrestamo("prestamo.dat");

		archPres.crear();
		archPres.adicionar();
		

	}

}
