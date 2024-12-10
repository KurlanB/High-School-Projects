
public class SalarierPermanent extends Employe{
	private double salaireHebdo;
	
	public SalarierPermanent(String n, String p, String na, double s) {
		super(n, p, na);
		salaireHebdo = s;
	}

	public double getSalaireHebdo() {
		return salaireHebdo;
	}

	public void setSalaireHebdo(double salaireHebdo) {
		this.salaireHebdo = salaireHebdo;
	}
	
	public double salairePaye() {
		return salaireHebdo;
	}
	
	public String toString() {
		return super.toString() + String.format("Salaire hebdomadaire : %.2f", salairePaye());
	}
	
}
