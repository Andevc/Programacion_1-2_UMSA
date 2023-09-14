public class Main {

	public static void main(String[] args) {
		System.out.println("");
		System.out.println("Datos Estudiante: Cristhian Andres Escobar Herrera");
		System.out.println("CI: 6908109 L.P.");

		// a) Instanciar 2 estudiantes de manera diferente y mostrarlos. 
		Estudiante e1 = new Estudiante(73.5);
		Estudiante e2 = new Estudiante();
		e1.mostrar();
		e2.mostrar();

		// b) De los 2 Estudiantes mostrar al estudiante con más promedio
		if (e1.mpromedio(e2) == true) {
			System.out.println("\t"+ e1.getNombre() + " tiene el mayor promedio con " + e1.getPromedio());
		} else {
			System.out.println("\t"+ e2.getNombre() + " tiene el mayor promedio con " + e2.getPromedio());
		}
		// c) Actualizar el promedio a 90 del estudiante con matrícula x
		e1.upProm(e2, 1844255);
		e1.mostrar();
		e2.mostrar();
	}

}
