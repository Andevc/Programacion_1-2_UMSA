public class Supermercado {

    private String nombre, direccion;
    private String[][] prod = new String[50][3];
    private int nroProductos;

    public Supermercado(){
        nombre  = "Supra";
        direccion = "Calle 15 de Mayo, número 321";
        nroProductos = 5;
        //? producto[i][0] = nombre, producto[i][1] = stock, producto[i][2] = precio. 
        prod[0][0] = "leche"; prod[0][1] = "15"; prod[0][2] = "18";
        prod[1][0] = "pan"; prod[1][1] = "35"; prod[1][2] = "15";
        prod[2][0] = "papel";prod[2][1] = "25"; prod[2][2] = "19";
        prod[3][0] = "arroz";prod[3][1] = "20"; prod[3][2] = "10";
        prod[4][0] = "pasta";prod[4][1] = "30"; prod[4][2] = "14";
        
    }

    public Supermercado(String nombre){
        this.nombre  = nombre;
        direccion = "Avenida de las Flores, número 456";
        nroProductos = 5;
        //? producto[i][0] = nombre, producto[i][1] = stock, producto[i][2] = precio. 
        prod[0][0] = "arroz"; prod[0][1] = "40"; prod[0][2] = "12";
        prod[1][0] = "aceite"; prod[1][1] = "25"; prod[1][2] = "19";
        prod[2][0] = "jabon";prod[2][1] = "50"; prod[2][2] = "4";
        prod[3][0] = "leche";prod[3][1] = "40"; prod[3][2] = "19";
        prod[4][0] = "pan"; prod[4][1] = "45"; prod[4][2] = "20";
        
        
    }

    public void mostrar(){
        System.out.println("--x--------------------------------x--");
        System.out.println("\tSupermercado");
        System.out.println(
            "\n\tNombre: "+this.nombre+
            "\n\tDireccion: "+this.direccion+
            "\n\tNro Productos: "+this.nroProductos
            );
        for(int i = 0; i < nroProductos; i++){
            System.out.println("");
            System.out.print("\t| ");
            for(int  j = 0; j < 3; j++){
                System.out.print(this.prod[i][j] + "    |\t");
            }
        }
        System.out.println("\n--x--------------------------------x--\n");
    }

    public String getNombre(){
        return this.nombre;
    }

    public int getNroProd(){
        return this.nroProductos;
    }

    public String[][] getProd(){
        return this.prod;
    }

    public void mayStock(Supermercado s, String x){
        int st1 = 0, st2 = 0;
        for(int i = 0; i < getNroProd(); i++){
            if( this.prod[i][1].equals(x)){
                st1 = Integer.parseInt(prod[i][1]);
            }
        }
        for(int i = 0; i < s.getNroProd(); i++){
            if( this.prod[i][1].equals(x)){
                st2 = Integer.parseInt(prod[i][1]);
            }
        }
        if( st1 > st2){
            System.out.println("\tEl supermercado "+getNombre()+" tiene mas stock de "+x);
        }else{
            System.out.println("\tEl supermercado "+s.getNombre()+" tiene mas stock de "+x);
        }

    }

    public void nomProd(String x, String y, Supermercado s){
        int i = 0, j = 0;
        String x1 = "", y1 = "";
        System.out.println("\tEn el Supermecado "+y);
        for( i = 0; i < getNroProd(); i++){
            for( j = 0; j < s.getNroProd(); j++){
                if(getProd()[i][0].equals(s.getProd()[j][0])){ 
                    if( getNombre().equals(x) &&  s.getNombre().equals(y)){
                        x1 = getProd()[i][2]; y1 = s.getProd()[j][2];
                    }
                    else{
                        y1 = getProd()[i][2]; x1 = s.getProd()[j][2];
                    }  
                    if(Integer.parseInt(x1) > Integer.parseInt(y1) ){
                        System.out.println("\t\t-"+s.getProd()[j][0]+" es mas barato");
                    }              
                }
            }
        }
    }

    public void vStock(String x){
        for(int i = 0; i < getNroProd(); i++){
            if(this.prod[i][0].equals(x)){
                if(Integer.parseInt(this.prod[i][1]) > 0){
                    System.out.println("\tEl producto "+x+" tiene stock disponible ");
                }
            }
        }
    }


}
