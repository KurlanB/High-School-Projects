import java.util.ArrayList;
public class TestPartie2 {

	public static void main(String[] args) { //afficher les employe et factures avec le prix total
		ArrayList<Payable> liste = new ArrayList<>();
		
		SalarierPermanent a = new SalarierPermanent("K", "B", "123", 400);
		SalarierTemporaire b = new SalarierTemporaire("Y", "R", "124", 16, 41);
		VendeurTemporaire c = new VendeurTemporaire("R", "R", "125", 50, 15);
		VendeurPermanent d = new VendeurPermanent("Y", "B", "126", 50, 15, 100);
		Invoice f = new Invoice("1234", "ball", 5, 30);
		
		liste.add(a);
		liste.add(b);
		liste.add(c);
		liste.add(d);
		liste.add(f);
		
		double x = 0;
		for(Payable i : liste) {
			System.out.println(i);
			x += i.getPaymentAmount();
		}
		
		System.out.format("Facture final : %.2f$",x );
	}

}
