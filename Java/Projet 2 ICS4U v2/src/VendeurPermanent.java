
public class VendeurPermanent extends VendeurTemporaire { //sous classe de vendeur temporaire
	public double salaireBase;
	
	public VendeurPermanent(String n, String p, String na, double v, double c, double b) { //constructeur avec variables de employe et vendeur temporaire
		super(n, p, na, v, c);
		salaireBase = b;
	}

	public double getSalaireBase() { //get et set
		return salaireBase;
	}

	public void setSalaireBase(double salaireBase) {
		this.salaireBase = salaireBase;
	}
	
	public double salairePaye() {
		return (commission*ventes) + salaireBase;
	}
	
	public String toString() {
		return super.toString() + String.format("\nSalaire de base : %.2f", salaireBase);
	}
}
