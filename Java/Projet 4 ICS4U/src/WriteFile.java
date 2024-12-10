import java.io.EOFException;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

import javax.swing.JOptionPane;

public class WriteFile {
	protected static ObjectOutputStream output; 
	protected static ObjectInputStream input;
	
	public WriteFile() { //methodes pour modifier le fichier
	}
	
	public static void openFile() { //ouvrir le fichier
		try{
			output = new ObjectOutputStream(new FileOutputStream("liste.txt"));
			input = new ObjectInputStream(new FileInputStream("liste.txt"));
		}
		catch (IOException ioException){
			JOptionPane.showConfirmDialog(null, "Erreur à ouvrir le fichier. Fin du Programme", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
			System.exit(1);
		}
	}
	
	public static Compte readCode(int code){ //lire le fichier et trouver le code avec ce code
		try {
			input = new ObjectInputStream(new FileInputStream("liste.txt"));
		} catch (IOException e) {
			e.printStackTrace();
		}
		Compte c = null;
		try{
			while(true){
				Compte compte = (Compte)input.readObject();
				if(compte.getCode() == code) {
					c = compte;
					break;
				}
			}
		}catch(EOFException endOfFileException) {
			JOptionPane.showConfirmDialog(null, "Il n'y a pas de comptes avec ce code", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
		}catch (ClassNotFoundException classNotFoundException){
			JOptionPane.showConfirmDialog(null, "Objet Invalide", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
		}catch (IOException ioException){
			JOptionPane.showConfirmDialog(null, "Erreur à lire dans le fichier", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
		}
		return c;
	}
	
	public static ArrayList<Compte> read()throws IOException, ClassNotFoundException { //lire le fichier et retourner tous les objets dans une liste
		ArrayList<Compte> liste = new ArrayList<>();
		
		try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("liste.txt"))) {
            while (true) {
                try {
                    Compte compte = (Compte) ois.readObject();
                    liste.add(compte);
                } catch (EOFException e) {
                    break;
                }
            }
        }
		return liste;
	}
	
	public static void write(ArrayList<Compte> liste) throws IOException{ //ecrire dans le fichier tous les objets d;une liste
		try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("liste.txt"))) {
            for (Compte compte : liste) {
                oos.writeObject(compte);
            }
        }
	}
	
	public static void closeFile(){ //fermer le fichier
		try{
			if (output != null)
				output.close();
			if(input!=null) {
				input.close();
			}
		}
		catch (IOException ioException){
			JOptionPane.showConfirmDialog(null, "Erreur à fermer le fichier", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
		} 
	}
}
