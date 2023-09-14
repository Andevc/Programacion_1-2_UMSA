package ejercicio2_lab5;

import java.io.File;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;


public class Archempleado {
    Scanner lee = new Scanner(System.in);
    private String nomArch;
    private empleado emple;

    public Archempleado() {
        this.nomArch = "";
    }

    public void crear() throws IOException {
        ObjectOutputStream aremple = new ObjectOutputStream(new FileOutputStream(nomArch));
        aremple.close();
    }

    public void Adicionar() throws IOException {
        String op;
        ObjectOutputStream aremple = null;
        try {
            if (new File(nomArch).exists()) {
                aremple = new ObjectOutputStream(new FileOutputStream(nomArch, true));
            } else {
                aremple = new ObjectOutputStream(new FileOutputStream(nomArch, true));
            }

            do {
                emple = new empleado();
                emple.leere();
                aremple.writeObject(emple);
                System.out.println("¿Desea continuar? (s/n)");
                op = lee.next();
            } while (op.equalsIgnoreCase("s"));

        } catch (Exception e) {
            System.out.println("El error es: " + e.getMessage());
        } finally {
            if (aremple != null) {
                aremple.close();
            }
        }
    }

    public void Listar() throws ClassNotFoundException, IOException {
        ObjectInputStream aremple = null;
        try {
            aremple = new ObjectInputStream(new FileInputStream(nomArch));
            while (true) {
                emple = (empleado) aremple.readObject();
                emple.mostrare();
            }
        } catch (Exception e) {
            System.out.println("¡Fin del listado!");
        } finally {
            if (aremple != null) {
                aremple.close();
            }
        }
    }
}
