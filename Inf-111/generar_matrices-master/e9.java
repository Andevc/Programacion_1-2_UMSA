// Diagonales
package com.mycompany.lab111.matrices.generar_matrices;

import java.util.Scanner;


public class e9{

    static public int v[][] = new int[20][20];

    static public void llenar(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=n; j++){
                v[i][j] = 0;
            }
        }
    }


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

    static public void diagonal_inferior(int n){
        int c=1, i,j=1,li=1,ls=n,k;
        for(k = 1; k <= n; k++){
            j = 1; 
            for(i = li; i <= ls; i++){
                v[i][j] = c; 
                c = c+1;
                j++;
            }
            li = li+1; 
        }
    }



    
    static public void diagonal_superior(int n){
        int c=1, i,j=1,li=1,ls=n,k;
        for(k = 1; k <= n; k++){
            j = 1; 
            for(i = li; i <= ls; i++){
                v[j][i] = c; 
                c = c+1;
                j++;
            }
            li = li+1; 
        }
    }

    static public void diagonal_invertida_inferior(int n){
        int c=1, i,j=1,li=1,ls=n,k;
        for(k = 1; k <= n; k++){
            j = n; 
            for(i = li; i <= ls ; i++){
                v[i][j] = c; 
                c = c+1;
                j--;
            }
            li = li+1; 
        }
    }

    static public void diagonal_invertida_superior(int n){
        int c=1, i,j=1,li=1,ls=n,k;
        for(k = 1; k <= n; k++){
            i = 1;
            for(j = ls; j >= li; j--){
                v[i][j] = c; 
                c = c+1;
                i++;
            }
            ls = ls-1;
        }
    }

    public static void main(String[] args) {
        try(Scanner sc = new Scanner(System.in)){
            System.out.print("n: ");
            int n = sc.nextInt();
            diagonal_inferior(n);
            mostrar(n);
            llenar(n);
            diagonal_superior(n);
            mostrar(n);
            llenar(n);
            diagonal_invertida_superior(n);
            mostrar(n);
            llenar(n);
            diagonal_invertida_inferior(n);
            mostrar(n);
            llenar(n);
            System.out.println("\n");
        }
    }



}