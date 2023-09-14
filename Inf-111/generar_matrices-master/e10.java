package com.mycompany.lab111.matrices.generar_matrices;
import java.util.Scanner;
public class e10 {
    static public int v[][] = new int[20][20];
    static public void mostrar(int n){
        System.out.print("v[][]:");
        for(int i=1; i<=n;i++){
            System.out.println("");
            System.out.print("\t|   ");
            for(int j=1;j<=n;j++){
                System.out.print(v[i][j]+"\t|   ");
            }
        }
        System.out.println("\n");
    }
    static public void remolino(int n){
        int c = 1,ls=n,li=1;
        int i,j,k;
        for(k = 1; k<=n/2; k++){
            i = ls;
            for(j = ls; j>= li; j--) {v[i][j] = c; c++;}
            j = li; 
            for(i = ls-1; i>=li; i--){v[i][j] = c; c++;}
            j = ls;
            for(i = ls-1; i>=li; i-- ){v[i][j] = c; c++;}
            i = li; 
            for(j = ls-1; j>=li+1; j-- ) {v[i][j] = c; c++;}
            ls--; li++;            
        }
        if( n % 2 == 1 ){ v[(int) n / 2 + 1][(int) n / 2 + 1] = c;}
    }
    public static void main(String[] args) {
        try(Scanner sc = new Scanner(System.in)){
            int n = 5; 
            remolino(n);
            mostrar(n);
        }
    }
}


