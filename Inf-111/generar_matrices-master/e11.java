package com.mycompany.lab111.matrices.generar_matrices;

import java.util.Scanner;

public class e11 {
 
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

    static public void zigzag(int n){
        int c=1;
        int i,j,k;
        for(k = 1; k<=n; k++){
            i = k;
            if(k %2 == 1){
                for(j = 1; j<=n; j++){ v[i][j] = c; c++;}
            }else{
                for(j = n; j>=1; j--) { v[i][j] = c; c++;}
            }
        }
    }

    public static void main(String[] args) {
        try(Scanner sc = new Scanner(System.in)){
            int n = 5;
            zigzag(n);
            mostrar(n);
        }
    }
    


    
}
