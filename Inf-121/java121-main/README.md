# Persistencia Java
### Crear
``` Java
public void Crear() throws ClassNotFoundException, IOException {
  ObjectOutputStream file = new ObjectOutputStream(new FileOutputStream(na));
  file.close();
}
```
### Adicionar
```Java

public void Adicionar() throws ClassNotFoundException, IOException {
  String op;
  Scanner lee = new Scanner(System.in);
  ObjectOutputStream file = null;
  try {
    if(new File(na).exists()){ file = new AddObjectOutputStream(new FileOutputStream(na,true)); }
    else{ file = new ObjectOutputStream(new FileOutputStream(na,true)); }
    do{
      jz = new Juez();
      jz.LeeJuez();
      file.writeObject(jz);
      System.out.println("Desea cont s/n");
      op = lee.next();
    }while(op.equals("s"));
  } 
  catch (Exception e) { System.out.println("Fin adicion"); }
  finally{ file.close(); }
}

```
### Listar
``` Java
public void Listar() throws ClassNotFoundException, IOException {
  ObjectInputStream file = null;
  try {
    file = new ObjectInputStream(new FileInputStream(na));
    while(true) {
      jz = new Juez();
      jz = (Juez)file.readObject();
      jz.MostJuez();
    }
  } 
  catch( Exception e) {  System.out.println("Fin listado"); }
  finally { file.close(); }
}
```
### Modificar
``` Java
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
    archF.close();
    archFCopia.close();
    File original = new File (nomArch); // archOriginal
    original.delete(); // archivoOriginal.dat
    File copia = new File ("aux.dat");
    copia.renameTo(original);
    
  }
}
```

### Eliminar
```Java
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
    archF.close();
    archFCopia.close();
    File original = new File (nomArch); // archOriginal
    original.delete(); // archivoOriginal.dat
    File copia = new File ("aux.dat");
    copia.renameTo(original);
    
  }
}
```

### Clase Main
``` Java
public static void main(String[] args) throws ClassNotFoundException, IOException {
  // CODIGO MAIN
}
```

### Class AddObject
``` java
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
public class AddObjectOutputStream extends ObjectOutputStream{	
  public AddObjectOutputStream(OutputStream out) throws IOException{
    super(out);
  }
  protected void writeStreamHeader() throws IOException{
    this.reset();
  }
}
```
