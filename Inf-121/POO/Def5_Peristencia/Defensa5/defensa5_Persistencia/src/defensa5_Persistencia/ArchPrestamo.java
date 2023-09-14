package defensa5_Persistencia;
import java.util.*;
import java.io.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;

public class ArchPrestamo {
	Scanner sc = new Scanner(System.in);
	private String nomArch;
	
	public ArchPrestamo(String nomArch) {
		this.nomArch= nomArch;
	}

	public void crear() throws ClassNotFoundException, IOException { 
		ObjectOutputStream file = new ObjectOutputStream(new FileOutputStream(nomArch));
		file.close();
	}

	public void adicionar() throws ClassNotFoundException, IOException{
		String sw = "" ;
		
		Scanner sc = new Scanner(System.in);
		ObjectOutputStream file = null;

		try {
			if (new File(nomArch).exists()) {
				file = new AddObjectOutputStream(new FileOutputStream(nomArch,true));
			}else{
				file = new ObjectOutputStream(new FileOutputStream(nomArch,true));
			}
			do {
				Prestamo regPres = new Prestamo();
				regPres.leerReg();
				file.writeObject(regPres);
				System.out.println("Desea Continuar si/no:");
				System.out.print(": "); sw = sc.next();
			} while (sw.equals("si") );
		} catch (Exception e) {
			System.out.println("Fin adicion");
		}
		finally{
			file.close();
		}

	}

}
