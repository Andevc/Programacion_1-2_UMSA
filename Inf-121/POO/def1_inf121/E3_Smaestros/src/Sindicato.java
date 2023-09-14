public class Sindicato {
    private String nombre, direccion;
    private String[][] a = new String[2][100];
    private int nroAfiliados;
    public Sindicato(){
        this.nombre = "Sindicato de Maestros Independientes";
        this.direccion = "Calle del Maestro, número 123";
        this.nroAfiliados = 4;
        a[0][0] = "4579212"; a[1][0] = "Presidente"; 
        a[0][1] = "19387261"; a[1][1] = "Vicepresidente"; 
        a[0][2] = "94857123"; a[1][2] = "Secretario"; 
        a[0][3] = "12948576"; a[1][3] = "Fiscal y Vocal"; 
    }
    public void mostarSind(){
        System.out.println("--x--------------------x--");
        System.out.println("\tSindicato");
        System.out.println(
            "\n\tNombre: " + this.nombre+
            "\n\tDireccion: " + this.direccion+
            "\n\tNro Afiliados: " + this.nroAfiliados
        );
        for (int i = 0; i < 2; i++) {
			System.out.println("");
            System.out.print("\t| ");
			for (int j = 0; j < this.nroAfiliados; j++) {
				System.out.print(this.a[i][j] + "\t  |\t ");
			}
		}
        System.out.println("\n--x--------------------x--\n");
        
    }
    public String[][] getA(){
        return this.a;
    }
    public void setA(String[][] a){
        this.a = a;
    }
    public void setNroAfiliados(int nroAfiliados){
        this.nroAfiliados = nroAfiliados;
    }
    public int getNroAf(){
        return this.nroAfiliados;
    }
    public void maeAfiliados(Maestros m){
        int x = 0;
        for(int i = 0; i < this.nroAfiliados; i++){
            if( m.getCi() == this.a[0][i]){
                x = 1;
            }
        }
        if(x != 1){               
            setNroAfiliados(nroAfiliados+1);
            a[0][nroAfiliados-1] = m.getCi();
            a[1][nroAfiliados-1] = "Sin cargo";
        }
    }

    public void sPresi(Maestros m){
        String dni = "";
        for(int i = 0; i < getNroAf(); i++){
            if(a[1][i].equals("Presidente")){
                dni = a[0][i];
            }
        }
        if(m.getCi().equals(dni)){
            System.out.println("El sueldo del cargo presindente es de: "+m.getSueldo()+"\n");
        }

    }

}
 