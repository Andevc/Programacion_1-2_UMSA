public class Principal {
	public static void main(String[] args) {
		System.out.println("");
		System.out.println("\tDatos Estudiante: Cristhian Andres Escobar Herrera");
		System.out.println("\tCI: 6908109 L.P.");
		// a) Instanciar 2 Maestros de manera diferente y un objeto sindicato. 
		Maestros m1 = new Maestros();
		Maestros m2 = new Maestros(2500);
		Sindicato s1 = new Sindicato();
		
		m1.mostrarMae();
		m2.mostrarMae();
		
		s1.mostarSind();

		// b) Afiliar a ambos maestros al sindicato si es que no existen. 
		s1.maeAfiliados(m1);
		s1.maeAfiliados(m2);
		s1.mostarSind();

		// c) Mostrar el sueldo del maestro afiliado con el cargo de “Presidente”
		s1.sPresi(m1);
		s1.sPresi(m2);

	}

}	
		

		

		