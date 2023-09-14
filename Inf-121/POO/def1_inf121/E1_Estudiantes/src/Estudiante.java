public class Estudiante {

    private int ci;
    private int matricula;
    private String nombre;
    private String paterno;
    private String materno;
    private double promedio;

    public double getPromedio() {
        return this.promedio;
    }

    public String getNombre() {
        return this.nombre;
    }

    public int getMatricula() {
        return this.matricula;
    }

    public void setPromedio(double promedio) {
        this.promedio = promedio;
    }

    public Estudiante() {
        ci = 33973214;
        matricula = 7755221;
        promedio = 62.0;
        materno = "Fernandez";
        paterno = "Mita";
        nombre = "Carlos";
    }

    public Estudiante(double promedio) {
        ci = 18492747;
        matricula = 1844255;
        this.promedio = promedio;
        nombre = "Violeta";
        paterno = "Poma";
        materno = "Condori";
    }

    public void mostrar() {
        System.out.println("--x-----------------------------x--");
        System.out.println(
            "\n\tNombre: " + this.nombre+
            "\n\tPaterno: " + this.paterno +
            "\n\tMaterno: " + this.materno +
            "\n\tCI: " + this.ci +
            "\n\tMatricula: " + this.matricula +
            "\n\tpromedio: " + this.promedio 
            );
        System.out.println("--x-----------------------------x--\n");
    }

    public boolean mpromedio(Estudiante e) {

        if (getPromedio() > e.getPromedio()) {
            return true;
        }
        return false;

    }

    public void upProm(Estudiante e, int x) {

        if( getMatricula() == x){
            setPromedio(90);
        }

        if( e.getMatricula() == x){
            
            e.setPromedio(90);
        }
    }
}
