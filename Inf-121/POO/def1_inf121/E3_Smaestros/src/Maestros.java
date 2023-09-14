public class Maestros {

    private int sueldo;
    private String nombre, paterno, ci;

    public Maestros(){
        nombre = "Pedro";
        paterno = "Mamani";
        ci = "7684921";
        sueldo = 3000;
    }

    public Maestros(int sueldo){
        nombre = "Jose";
        paterno = "Silva";
        ci = "4579212";
        this.sueldo = sueldo;
    }
 
    public void mostrarMae(){
        System.out.println("--x------------------------------x--");
        System.out.println("\tMaestro");
        System.out.println(
            "\n\tNombre: " + this.nombre+
            "\n\tPaterno: " + this.paterno+
            "\n\tCI: " + this.ci+
            "\n\tSueldo: " + this.sueldo
        );
        System.out.println("--x------------------------------x--\n");
    }
    public String getCi(){

        return this.ci;
    }

    public int getSueldo(){
        return this.sueldo;
    }


}
 