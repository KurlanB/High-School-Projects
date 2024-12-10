import java.util.Random;

public class Etang {
	private int nombrePoissons, capacite; // declarer les variables
	private Poisson[] poisson; //la liste ou les livres emprunte seront ajoute


	public Etang(int nombre) { //methode constructeur
		capacite = nombre;
		poisson = new Poisson[capacite]; //capacite du tableau
	}

	public int getnombre() { //get nombrepoissons
		return nombrePoissons;
	} 

	public boolean estSature() {
		return nombrePoissons >= capacite; //si l'etang est rempli retouner vrai 
	}

	public Poisson attraperPoisson(){ // attraper un poisson
		Random r = new Random();
		int peche = r.nextInt(capacite);
		Poisson p = poisson[peche]; //variable pour le poisson choisi
		
		if(p != null) {
			poisson[peche] = poisson[nombrePoissons - 1]; // enlever le poisson est mettre le dernier a sa place
			poisson[nombrePoissons - 1] = null;
			nombrePoissons--;
		}
		return p;
	}

	public void ajouter(Poisson x) { //ajouter un poisson dans l'etang
		if (!estSature()) {
			poisson[nombrePoissons] = x; // si l'etang n'est pas rempli ajouter un poisson
			nombrePoissons++;
		}
	}


	public void listePoissons() { //lister les poissons leur espece et taille
		System.out.printf("L'etang avec %d poissons sont :\n", nombrePoissons);
		for (Poisson i : poisson) {
			if (i == null) {
				System.out.println("null");
			} else {
				System.out.println(i.toString());
			}
		}
	} 

	public String toString() { // nombre de poissons dans l'etang
		return String.format("Etang avec %d poissons", nombrePoissons);
	}



}

