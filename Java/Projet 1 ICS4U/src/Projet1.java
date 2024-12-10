import java.util.*;

public class Projet1{
	public static void main(String[] args) {
		Etang   grandEtang = new Etang(15);
		   grandEtang.ajouter(new Poisson(4, "Sunfish"));
		   grandEtang.ajouter(new Poisson(25, "Pike"));
		   grandEtang.ajouter(new Poisson(20, "Bass"));
		   grandEtang.ajouter(new Poisson(30, "Perch"));
		   grandEtang.ajouter(new Poisson(14, "Sunfish"));
		   grandEtang.ajouter(new Poisson(15, "Pike"));
		   grandEtang.ajouter(new Poisson(9, "Pike"));
		   grandEtang.ajouter(new Poisson(12, "Bass"));
		   grandEtang.ajouter(new Poisson(5, "Sunfish"));
		   grandEtang.ajouter(new Poisson(12, "Sunfish"));
		   grandEtang.ajouter(new Poisson(10, "Bass"));
		   grandEtang.ajouter(new Poisson(2, "Bass"));
		   grandEtang.ajouter(new Poisson(16, "Perch"));
		   grandEtang.ajouter(new Poisson(30, "Sunfish"));
		   grandEtang.ajouter(new Poisson(7, "Perch"));
		   grandEtang.listePoissons();
		   
		   //Cr�er deux p�cheurs
		   Pecheurs suzy = new Pecheurs("Suzy", 10);
		   Pecheurs fred = new Pecheurs("Fred", 15);
		   
		    for(int i =0;i<20;i++) {
		    suzy.allerPecher(grandEtang);
		    }
		    
		    System.out.println("Voici la liste des poissons p�ch�s par Suzy :");
		    suzy.listePoisson();
		   
		      for(int i =0;i<20;i++) {
		    	  fred.allerPecher(grandEtang);
		      }
		      
		      System.out.println("Voici la liste des poissons p�ch�s par Fred :");
		      		fred.listePoisson();
		   
		   System.out.println("Voila ce qui reste dans le lac");
		   grandEtang.listePoissons();

	}

}
