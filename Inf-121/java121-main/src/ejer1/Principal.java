package ejer1;

import java.io.IOException;

public class Principal {

	public static void main(String[] args) throws ClassNotFoundException, IOException {
		
		ArchJuez regJuez = new ArchJuez("archJuez.dat");
		
		regJuez.Crear();
		
		regJuez.Adicionar();
		
		regJuez.Listar();
		
		regJuez.modificar("juan");
		
		regJuez.Eliminar("pepe");
		

	}

}
