
public class Invoice implements Payable { //classe qui utilise payable
	private final String numeroArticle; //variables pour invoice
	private final String descriptionArticle;
	private final int quantité;
	private final double prixUnitaire;
	
	public Invoice(String numeroArticle, String descriptionArticle, int quantité, double prixUnitaire) { //constructeur
		this.numeroArticle = numeroArticle;
		this.descriptionArticle = descriptionArticle;
		this.quantité = quantité;
		this.prixUnitaire = prixUnitaire;
	}
	
	public String getNumeroArticle() { //get et set
		return numeroArticle;
	}


	public String getDescriptionArticle() {
		return descriptionArticle;
	}


	public int getQuantité() {
		return quantité;
	}


	public double getPrixUnitaire() {
		return prixUnitaire;
	}


	@Override
	 public double getPaymentAmount() { //le montant a paye
	 return getQuantité() * getPrixUnitaire();
	 }

	@Override
	 public String toString() { //afficher les details
	 return String.format("%s: %n%s: %s (%s) %n%s: %d %n%s: $%,.2f \nPrix : %.2f$", "Invoice", "Numéro de l’article", getNumeroArticle(), getDescriptionArticle(), "Quantité", getQuantité(), "Prix unitaire", getPrixUnitaire(), getPaymentAmount());
	 }

}