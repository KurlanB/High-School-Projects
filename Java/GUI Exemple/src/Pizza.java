

public class Pizza implements CPrix{

	private String taille;//variable pour chaque details de la pizza
	private int nPizza;
	private int nGarniture;
	private final static double prixP = 6.79; //les prix des pizzas et garnitures
	private final static double prixM = 8.29;
	private final static double prixL = 9.49 ;
	private final static double prixE = 10.29;
	private final static double prixPa = 15.99;
	private final static double prixGP = 1.2;
	private final static double prixGM = 1.4;
	private final static double prixGL = 1.6;
	private final static double prixGE = 1.8;
	private final static double prixGPa = 2.3;
	
	public Pizza(String taille, int nPizza, int nGarniture) { //constructeur
		this.taille = taille;
		this.nPizza = nPizza;
		this.nGarniture = nGarniture;
	}
	
	@Override
	public double prix() { //methode prix pour calculer les prix dependament de la taille
		double x = 0;
		switch(taille) {
		case "petit":
			x = prixP * nPizza + prixGP * nGarniture;
			break;
		case "moyen":
			x = prixM * nPizza + prixGM * nGarniture;
			break;
		case "large":
			x = prixL * nPizza + prixGL * nGarniture;
			break;
		case "extra large":
			x = prixE * nPizza + prixGE * nGarniture;
			break;
		case "party square":
			x = prixPa * nPizza + prixGPa * nGarniture;
			break;
		}
		return x;
	}
	
	@Override
	public String toString() { //afficher la commande de pizza
		return nPizza + " pizza(s) de taille " + taille + " avec " + nGarniture + " garniture(s) - Cout : $" + String.format("%.2f", prix());
	}
}
