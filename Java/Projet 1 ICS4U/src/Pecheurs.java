import java.util.ArrayList;
import java.util.Random;
public class Pecheurs {

	private String nom;
	private ArrayList <Poisson> poissonAttrapes = new ArrayList<>(); //la liste ou les livres emprunte seront ajoute
	private int nombrePoissons, tailleValide;
	private static final int limite = 4;

	public Pecheurs(String n, int t) { // methode constructeur
		nom = n;
		tailleValide = t;
	}

	public void allerPecher(Etang e) { // aller pecher un poisson
		if(nombrePoissons < limite) { // si le pecheur n'est pas a sa limite il peut pecher
			Poisson p = e.attraperPoisson(); // attraper un poisson
			if (p != null) {
				nombrePoissons++;
				if(garder(p)) { // si le poisson a la bonne taille le garder 
					poissonAttrapes.add(p);
				} else if(!garder(p)) { // sinon le remettre
					e.ajouter(p);
					nombrePoissons--;
				}
			}

		}
	}

	public boolean garder(Poisson p) { // si la taille du poisson est correct dire vrai sinon faux
		boolean size = false;
		if(p != null) {
			if(p.getTaille() > tailleValide) {
				size = true;
			} else if(p.getTaille() < tailleValide) {
				size = false;
			}
		}
		return size;
	}

	public void listePoisson() { //liste des poisson que le pecheur a peche et leur espece et taille
		System.out.printf("%s a attrapes et gardes %d poissons qui sont :\n", nom, nombrePoissons);
		for (Poisson i : poissonAttrapes) {
			System.out.printf("%s de %dcm\n", i.getEspece(), i.getTaille());
		}
	}

	public String toString() { // to string
		return String.format("%s a peches %d poissons", nom, nombrePoissons);
	}
}
