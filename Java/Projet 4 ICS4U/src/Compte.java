import java.io.IOException;
import java.io.Serializable;
import java.util.ArrayList;

import javax.swing.JOptionPane;

public class Compte implements Serializable{
	private String nom;
	private static int n = 1;
	private int code; 
	private double solde, decouvert = 0, dmax, debitmax, defaultDebMax;
	private boolean situation = false;

	public Compte(String nom, double dmax, double debitmax) { //constructeur si il n'y a pas de depot ajoute
		this.nom = nom;
		this.code = n;
		solde = 0;
		this.dmax = dmax;
		this.debitmax = debitmax;
		this.defaultDebMax = debitmax;
		setwDebmax(); //calculer le debit max du debut du compte
		n++;
	}

	public Compte(String nom, double dmax, double debitmax, double solde) { //constructeur si il y a un depot
		this.code = n;
		this.nom = nom;
		this.solde = solde;
		this.dmax = dmax;
		this.debitmax = debitmax;
		this.defaultDebMax = debitmax;
		setwDebmax();
		n++;
	}

	private void setDecouvert() { // calculer le decouvert si il y a lieu
		if (solde >= 0) {
			decouvert = 0;
		} else {
			decouvert = Math.abs(solde);
		}
	}

	public double getSolde() {
		return solde;
	}
	public void setdDebmax() { // calculer le debit max quand on credit
		if(solde <= 0 && debitmax < defaultDebMax) {
			debitmax = dmax - decouvert;
		} else if(solde > 0 && (solde + dmax) > debitmax && (solde + dmax) < defaultDebMax) {
			debitmax = solde + dmax;
		} else {
			debitmax = defaultDebMax;
		}
	}
	
	public void deposit(double n) { // crediter une somme d'argent
		this.solde += n;
		setDecouvert(); // calculer le decouvert et debitmax apres ce credit
		setdDebmax();
	}

	public void setwDebmax() { //calculer debitmax apres avoir debiter de l'argent
		if (solde >= 0 && solde + dmax < debitmax) {
			debitmax = solde + dmax;
		} else if (solde < 0 && dmax - decouvert <= debitmax) {
			debitmax = dmax - decouvert;
		} else {
			debitmax = defaultDebMax;
		}
	}
	public void withdraw(double n) { //debiter de l'argent
		if(n > debitmax) {
			JOptionPane.showConfirmDialog(null, "Cela depasse votre debit maximum", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE); // si cela depasse le debit maximum donner une erreur
		} if (solde <= 0 && solde - n < -dmax) {
			JOptionPane.showConfirmDialog(null, "Cela depasse le decouvert", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE); // si cela depasse le decouvert autorise donner un erreur
		} else if (n <= debitmax && !(solde <= 0 && solde - n < -dmax)){ //sinon faire le debit
			this.solde -= n;
			setDecouvert();
			setwDebmax();
		}
	}

	public String getSituation() { //voir si le compte est a decouvert ou non
		String x = "";
		if(decouvert == 0) {
			x = "Le compte n'est pas a decouvert";
		} else if (decouvert > 0) {
			x = "Le compte est a decouvert";
		}
		return x;
	}

	public String getNom() {
		return nom;
	}

	public int getCode() {
		return code;
	}

	public double getDecouvert() {
		return decouvert;
	}

	public double getDmax() {
		return dmax;
	}

	public double getDebitmax() {
		return debitmax;
	}

	public String toString() {
		return String.format("%s %d %f %f %f %b %f ", nom, code, decouvert, dmax, debitmax, situation, solde);
	}
}
