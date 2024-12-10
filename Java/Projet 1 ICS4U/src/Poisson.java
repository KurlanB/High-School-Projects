
public class Poisson {
	private String Espece;
	private int Taille; // declaration des variables
	
	public Poisson(int t, String e) { // methode constructeur
		Taille = t;
		Espece = e;
	}
	
	public String getEspece() { // get pour les variable
		return Espece;
	} //
	
	public int getTaille() {
		return Taille;
	} // 
	
	public String toString() { //tostring pour devenir String
		return String.format("%s de %dcm", Espece, Taille);
	}
	//
	
}
