package com.mycompany.lab111.matrices.generar_matrices;

import java.util.Scanner;

public class e12 {

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

    static public void vibora(int n){
        int c=1,li = 1, ls = n;
        int i,j,k;
        for( k = 1; k <= n; k++){
            i = li;
            for(j=li ; j <= li + 1; j++){v[i][j] = c; c++;}
            i = li+1;
            for(j = li; j <= li; j++){v[i][j] = c; c++;}

            li++;ls--;
        }

         
    }

    public static void main(String[] args) {
        try(Scanner sc = new Scanner(System.in)){
            int n = 5;
            vibora(n);
            mostrar(n);
        }
    }
    
    
}
