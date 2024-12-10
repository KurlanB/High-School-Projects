
public class VendeurTemporaire extends Employe {
	protected double ventes, commission;
	
	public VendeurTemporaire(String n, String p, String na, double v, double c) {
		super(n, p, na);
		ventes = v;
		commission = c;
	}

	public double getVentes() {
		return ventes;
	}

	public void setVentes(double ventes) {
		this.ventes = ventes;
	}

	public double getCommission() {
		return commission;
	}

	public void setCommission(double commission) {
		this.commission = commission;
	}
	
	public double salairePaye() {
		return commission * ventes;
	}
	
	public String toString() {
		return super.toString() + String.format("Les ventes : %.2f \nCommission : %.2f \nSalaire Hebdomadaire : %.2f",ventes, commission, salairePaye());
	}

}
