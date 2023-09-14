public class Principal {

	public static void main(String[] args) {
		System.out.println("");
		System.out.println("\tDatos Estudiante: Cristhian Andres Escobar Herrera");
		System.out.println("\tCI: 6908109 L.P.");
		// A) Instanciar 2 supermercados de forma distinta

		Supermercado s1 = new Supermercado();
		Supermercado s2 = new Supermercado("Easy Mart");

		// b) Mostrar los 2 supermecados

		s1.mostrar();
		s2.mostrar();

		// c) mostrar el supermercado con mas stock disponible del producto de nombre x
		s1.mayStock(s2, "leche");
		
		// d) Mostrar el nombre de los productos que tiene el supermercado de nombre Y,
		// que son más baratos en el supermercado de nombre X.


		// e) Implementar un método para verificar si el supermercado tiene stock
		// disponible del producto de nombre X.
		s1.vStock("pasta");
		s2.vStock("jabon");

	}

}
