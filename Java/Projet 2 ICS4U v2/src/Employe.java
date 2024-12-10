
public abstract class Employe implements Payable{
	protected String nom, prenom, nas;
	
	public Employe(String n, String p, String na) {
		nom = n;
		prenom = p;
		nas = na;
	}
	
	public String getNom() {
		return nom;
	}
	
	public String getPrenom() {
		return prenom;
	}
	
	public String getNas() {
		return nas;
	}
	
	public abstract double salairePaye();
	
	public double getPaymentAmount() {
		return salairePaye();
	}
	
	public String toString() {
		return String.format("Employe : %s, %s \n Numero d'assurance sociale : %s \n", prenom, nom, nas);
	}
}
