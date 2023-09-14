using System;
namespace E2_caja
{
    public class Caja
    {
        private string color, estado;
        private int nroObjetos;
        private string[,] obj = new string[100, 2];
        // obj[0,0] = Nobre Objeto; obj[0,1] = Cantidad 
        public Caja()
        {
            color = "Marron";
            estado = "buen estado";
            nroObjetos = 3;
            obj[0, 0] = "Platos"; obj[0, 1] = "18";
            obj[1, 0] = "Tazas"; obj[1, 1] = "12";
            obj[2, 0] = "Cucharas"; obj[2, 1] = "6";
        }
        public Caja(string color, string estado)
        {
            this.color = color;
            this.estado = estado;
            nroObjetos = 4;
            obj[0, 0] = "Reloj"; obj[0, 1] = "6";
            obj[1, 0] = "Libro"; obj[1, 1] = "10";
            obj[2, 0] = "Lapiz"; obj[2, 1] = "20";
            obj[3, 0] = "Paraguas"; obj[3, 1] = "5";
        }
        public Caja(string color, string estado, int nroObjetos)
        {
            this.color = color;
            this.estado = estado;
            this.nroObjetos = nroObjetos;
            obj[0, 0] = "Linterna"; obj[0, 1] = "16";
            obj[1, 0] = "Peluche"; obj[1, 1] = "10";
            obj[2, 0] = "Ajedrez"; obj[2, 1] = "20";
            obj[4, 0] = "Lapiz"; obj[4, 1] = "25";
            obj[3, 0] = "Platos"; obj[3, 1] = "15";
        }
        public void mostrar()
        {
            Console.WriteLine(
                "\n--x-----------------------------x-- \n\t\tCaja" +
                "\n\tColor: " + this.color +
                "\n\tEstado: " + this.estado +
                "\n\tNro Objetos: " + this.nroObjetos + "\n"
            );
            for (int i = 0; i < this.nroObjetos; i++){
                Console.WriteLine("\t|  " + obj[i, 0] + "\t| " + obj[i, 1] + "\t|");
            }
        }
        public static Caja operator --(Caja x)
        {
            for (int i = 0; i < x.nroObjetos; i++){
                x.obj[i, 1] = ((int)((int.Parse(x.obj[i, 1]) * 0.5))).ToString();
            }
            return x;
        }
        public static Caja operator -(Caja x, Caja y)
        {
            if (x.estado == "mal estado"){
                if (y.estado == "buen estado"){
                    for (int i = 0; i < x.nroObjetos; i++){
                        y.obj[y.nroObjetos, 0] = x.obj[i, 0];
                        y.obj[y.nroObjetos, 1] = x.obj[i, 1];
                        x.obj[i, 0] = "";
                        x.obj[i, 1] = "";
                        y.nroObjetos++;
                    }
                    x.nroObjetos = 0;
                }
                else{
                    Console.WriteLine("La caja no esta en mal estado");
                }
            }
            else{
                Console.WriteLine("La caja esta en " + x.estado);
            }
            return y;
        }
        public bool objExiste(string x)
        {
            for (int i = 0; i < nroObjetos; i++){
                if (obj[i, 0] == x){
                    return true;
                }
            }
            return false;
        }

        public int busCant(string x)
        {
            int pos = -1;
            for (int i = 0; i < nroObjetos; i++){
                if (obj[i, 0] == x){
                    pos = i;
                }
            }
            return pos;
        }
        public static Caja operator ==(Caja x, Objeto y)
        {
            bool sw = false;
            int i = x.busCant(y.Nombre);
            if (x.objExiste(y.Nombre)){
                
                Console.WriteLine("\t-La cantidad del producto " + y.Nombre + " es de: " + x.obj[i, 1]);
                sw = true;
            }
            if (!sw){
                Console.WriteLine("\t-El objeto no existe en la caja. ");
            }
            return x;
        }
        public static Caja operator !=(Caja x, Objeto y){return x;}
    }
}
