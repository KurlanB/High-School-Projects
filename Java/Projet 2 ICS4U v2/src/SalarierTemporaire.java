
public class SalarierTemporaire extends Employe {
	private double taux, nHeure;
	
	public SalarierTemporaire(String n, String p, String na, double t, double h) {
		super(n, p, na);
		taux = t;
		nHeure = h;
	}

	
	public double getTaux() {
		return taux;
	}


	public void setTaux(double taux) {
		this.taux = taux;
	}


	public double getnHeure() {
		return nHeure;
	}


	public void setnHeure(double nHeure) {
		this.nHeure = nHeure;
	}


	public double salairePaye() {
		if(nHeure <= 40) {
			return taux*nHeure;
		} else {
			return taux*(40+((nHeure-40)*1.5));
		}
	}
	
	public String toString() {
		return super.toString() + String.format("Taux horaire : %.2f \nNombre d'heures travaille : %.2f \nSalaire Hebdomadaire : %.2f", taux, nHeure, salairePaye());
	}
}
