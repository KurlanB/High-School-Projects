public class Breuvage implements CPrix {

	private String sorte;
	private int nBreuvage;// details de breuvage
	private final static double prixPop = 1.1; //prix des breuvages
	private final static double prixJus = 1.35;
	private final static double prixEau = 1 ;
	
	public Breuvage(String sorte, int nBreuvage) { //constructeur
		this.sorte = sorte;
		this.nBreuvage = nBreuvage;
	}
	
	@Override
	public double prix() { //methode pour calculer les prix en utilisant la sorte de breuvage
		double x = 0;
		switch(sorte) {
		case "pop":
			x = prixPop * nBreuvage;
			break;
		case "jus":
			x = prixJus * nBreuvage;
			break;
		case "eau":
			x = prixEau * nBreuvage;
			break;
			}
		return x;
	}
	
	public String toString() { //afficher les breuvages
		return nBreuvage + " Breuvage(s) " + sorte + " - Cout : $" + String.format("%.2f", prix());
	}
	
}
