package ejer1;
import java.io.*;
import java.util.Scanner;
public class ArchJuez {
	
	private String na;
	private Juez jz;
	public ArchJuez(String na) { this.na = na; }
	
	public void Crear() throws ClassNotFoundException, IOException {
		ObjectOutputStream file = new ObjectOutputStream(new FileOutputStream(na));
		file.close();
	}
	public void Adicionar() throws ClassNotFoundException, IOException {
		String op;
		Scanner lee = new Scanner(System.in);
		ObjectOutputStream file = null;
		
		try {
			if(new File(na).exists()){
				file = new AddObjectOutputStream(new FileOutputStream(na,true));
			}else{					
				file = new ObjectOutputStream(new FileOutputStream(na,true));
			}
			do{
				jz = new Juez();
				jz.LeeJuez();
				file.writeObject(jz);
				System.out.println("Desea cont s/n");
				op = lee.next();
			}while(op.equals("s"));
			
		} catch (Exception e) {
			
			System.out.println("Fin adicion");
		}finally{
			file.close();
		}
		
	}
	public void Listar() throws ClassNotFoundException, IOException {
		ObjectInputStream file = null;
		try {
			file = new ObjectInputStream(new FileInputStream(na));
			while(true) {
				jz = new Juez();
				jz = (Juez)file.readObject();
				jz.MostJuez();
			}
		} catch( Exception e) {  System.out.println("Fin listado"); }
		finally { file.close(); }
	}

	public void modificar(String nom) throws ClassNotFoundException, IOException {
		Scanner lee = new Scanner(System.in);
		String op;
		ObjectInputStream file = null;
		ObjectOutputStream fileAux = null;
		try {
			file = new ObjectInputStream(new FileInputStream(na));
			if(new File(na).exists()){ fileAux = new AddObjectOutputStream(new FileOutputStream("aux.dat",true)); }
			else{ fileAux = new ObjectOutputStream(new FileOutputStream("aux.dat",true)); }
			while(true){
				jz = new Juez();
				jz = (Juez)file.readObject();
				if( jz.getNombre().equals(nom)){
					System.out.println("Desea Modificar");
					op = lee.next();
					if( op.equals("s")){ jz.LeeJuez(); }
				}
				fileAux.writeObject(jz);
			}
		} catch (Exception e) {
			System.out.println("Fin Modificar");
		} finally{
			file.close();
			fileAux.close();
			if( new File(na).exists()){ new File(na).delete(); }
			if( new File("aux.dat").exists()){ new File("aux.dat").renameTo(new File(na));  }
		}
	}

	public void Eliminar(String nom) throws ClassNotFoundException, IOException {
		boolean sw;
		ObjectInputStream file = null;
		ObjectOutputStream fileAux = null;
		try{
			
			file = new ObjectInputStream(new FileInputStream(na));
			if(new File(na).exists()){ fileAux = new AddObjectOutputStream(new FileOutputStream("aux.dat",true)); }
			else{ fileAux = new ObjectOutputStream(new FileOutputStream("aux.dat",true)); }
			while (true) {
				jz = new Juez();
				jz = (Juez)file.readObject();
				if( jz.getNombre().equals(nom) ){ sw = true; }
				else{ fileAux.writeObject(jz); }
			}
		}
		catch (Exception e){ System.out.println("Fin Eliminar"); }
		finally { 
			file.close();
			fileAux.close();
			if( new File(na).exists()){ new File(na).delete(); }
			if( new File("aux.dat").exists()){ new File("aux.dat").renameTo(new File(na));  }
		}
		
	}
	

}
