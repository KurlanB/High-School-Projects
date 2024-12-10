import java.awt.*;
import javax.swing.*;
import javax.swing.border.EmptyBorder;
import javax.swing.border.LineBorder;
import javax.swing.border.TitledBorder;
import javax.swing.border.EtchedBorder;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.event.ChangeListener;
import javax.swing.event.ChangeEvent;
import java.util.ArrayList;

public class Fenetre extends JFrame {

	private JPanel contentPane;//ArrayList pour prendre tous les commandes
	protected static ArrayList<CPrix> commande = new ArrayList<>();
	private boolean yes;// boolean pour verifier s'il y a un item dans la commande
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Fenetre frame = new Fenetre();
					frame.setVisible(true);// Afficher la fenetre quand on run le programme
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Fenetre() {

		ImageIcon img = new ImageIcon("\"C:\\Users\\beeha\\eclipse-workspace\\GUI Exemple\\logo.png\""); // icon dans la barre titre
		setIconImage(Toolkit.getDefaultToolkit().getImage(Fenetre.class.getResource("/image/pizza.png"))); 
		setFont(new Font("Bauhaus 93", Font.ITALIC, 20)); // font
		setResizable(false); //empecher l'utilisateur de resize la fenetre
		setTitle("Pizza Simmou"); // titre de la fenetre
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // fermer application quand on clique sur X
		setBounds(100, 100, 900, 560); // taille de la fenetre
		contentPane = new JPanel(); // panel ou tous les autres objets vont faire parties
		contentPane.setBackground(new Color(246, 187, 10));
		contentPane.setBorder(new EmptyBorder(10, 10, 10, 10));

		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(5, 5));

		//============================================================= MENU =================================================================
		JPanel pMenu = new JPanel(); // panel pour le menu
		pMenu.setForeground(new Color(0, 0, 0));
		pMenu.setBackground(new Color(246, 187, 10));
		pMenu.setBorder(new TitledBorder(new EtchedBorder(EtchedBorder.LOWERED, new Color(246, 187, 10), new Color(246, 187, 10)), "MENU", TitledBorder.CENTER, TitledBorder.ABOVE_TOP, new Font("Berlin Sans FB Demi", Font.BOLD, 22), new Color(0, 0, 0)));
		contentPane.add(pMenu, BorderLayout.WEST);
		pMenu.setLayout(new GridLayout(3, 1, 0, 0));
		pMenu.setPreferredSize(new Dimension(250, 0));

		//Taille pizza
		JPanel pTaille = new JPanel(); //panel dans le menu pour la taille
		pTaille.setBorder(new LineBorder(new Color(249, 211, 66), 3, true));
		pTaille.setBackground(new Color(253, 232, 141));
		pMenu.add(pTaille);
		pTaille.setLayout(new FlowLayout(FlowLayout.CENTER, 0, 0));

		JLabel lblTaille = new JLabel("Taille"); // titre 
		lblTaille.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 20));
		pTaille.add(lblTaille);

		JPanel pTaille2 = new JPanel(); // deuxieme panel pour bien afficher le menu
		pTaille.add(pTaille2);
		pTaille2.setPreferredSize(new Dimension(230,120));
		pTaille2.setBackground(new Color(253, 232, 141));
		pTaille2.setLayout(null);

		//les labels pour le menu
		JLabel lblSmall = new JLabel("Petit: $6.79"); 
		lblSmall.setFont(new Font("Forte", Font.PLAIN, 15));
		lblSmall.setHorizontalAlignment(SwingConstants.CENTER);
		lblSmall.setBounds(51, 0, 122, 33);
		pTaille2.add(lblSmall);

		JLabel lblMedium = new JLabel("Moyen: $8.29");
		lblMedium.setFont(new Font("Forte", Font.PLAIN, 15));
		lblMedium.setHorizontalAlignment(SwingConstants.CENTER);
		lblMedium.setBounds(61, 27, 111, 22);
		pTaille2.add(lblMedium);

		JLabel lblLarge = new JLabel("Large: $9.49");
		lblLarge.setFont(new Font("Forte", Font.PLAIN, 15));
		lblLarge.setHorizontalAlignment(SwingConstants.CENTER);
		lblLarge.setBounds(61, 49, 98, 22);
		pTaille2.add(lblLarge);

		JLabel lblELarge = new JLabel("Extra Large: $10.29");
		lblELarge.setFont(new Font("Forte", Font.PLAIN, 15));
		lblELarge.setHorizontalAlignment(SwingConstants.CENTER);
		lblELarge.setBounds(43, 70, 144, 22);
		pTaille2.add(lblELarge);

		JLabel lblParty = new JLabel("Party Square: $15.99");
		lblParty.setFont(new Font("Forte", Font.PLAIN, 15));
		lblParty.setHorizontalAlignment(SwingConstants.CENTER);
		lblParty.setBounds(42, 90, 145, 22);
		pTaille2.add(lblParty);

		//Garnitures
		JPanel pGarniture = new JPanel();
		pGarniture.setBorder(new LineBorder(new Color(249, 211, 66), 3));
		pGarniture.setBackground(new Color(253, 232, 141));
		pMenu.add(pGarniture);
		
		//labels des garnitures
		JLabel lblGarniture = new JLabel("Garnitures");
		lblGarniture.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 20));
		pGarniture.add(lblGarniture);
		
				JPanel pGarniture2 = new JPanel();
				pGarniture2.setLayout(null);
				pGarniture2.setPreferredSize(new Dimension(230, 115));
				pGarniture2.setBackground(new Color(253, 232, 141));
				pGarniture.add(pGarniture2);
				
						JLabel lblGSmall = new JLabel("Petit: $1.20");
						lblGSmall.setHorizontalAlignment(SwingConstants.CENTER);
						lblGSmall.setFont(new Font("Forte", Font.PLAIN, 15));
						lblGSmall.setBounds(51, 0, 122, 33);
						pGarniture2.add(lblGSmall);
						
								JLabel lblGMedium = new JLabel("Moyen: $1.40");
								lblGMedium.setHorizontalAlignment(SwingConstants.CENTER);
								lblGMedium.setFont(new Font("Forte", Font.PLAIN, 15));
								lblGMedium.setBounds(61, 27, 111, 22);
								pGarniture2.add(lblGMedium);
								
										JLabel lblGLarge = new JLabel("Large: $1.60");
										lblGLarge.setHorizontalAlignment(SwingConstants.CENTER);
										lblGLarge.setFont(new Font("Forte", Font.PLAIN, 15));
										lblGLarge.setBounds(61, 49, 98, 22);
										pGarniture2.add(lblGLarge);
										
												JLabel lblGELarge = new JLabel("Extra Large: $1.80");
												lblGELarge.setHorizontalAlignment(SwingConstants.CENTER);
												lblGELarge.setFont(new Font("Forte", Font.PLAIN, 15));
												lblGELarge.setBounds(43, 70, 144, 22);
												pGarniture2.add(lblGELarge);
												
														JLabel lblGParty = new JLabel("Party Square: $2.30");
														lblGParty.setHorizontalAlignment(SwingConstants.CENTER);
														lblGParty.setFont(new Font("Forte", Font.PLAIN, 15));
														lblGParty.setBounds(42, 90, 145, 22);
														pGarniture2.add(lblGParty);

		//Breuvages
		JPanel pBreuvage = new JPanel();
		pBreuvage.setBorder(new LineBorder(new Color(249, 211, 66), 3));
		pBreuvage.setBackground(new Color(253, 232, 141));
		pMenu.add(pBreuvage);

		JLabel lblBreuvages = new JLabel("Breuvages");
		lblBreuvages.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 20));
		pBreuvage.add(lblBreuvages);

		JPanel pBreuvage2 = new JPanel();
		pBreuvage2.setLayout(null);
		pBreuvage2.setPreferredSize(new Dimension(230, 110));
		pBreuvage2.setBackground(new Color(253, 232, 141));
		pBreuvage.add(pBreuvage2);

		JLabel lblPop = new JLabel("Pop : $1.10");
		lblPop.setHorizontalAlignment(SwingConstants.CENTER);
		lblPop.setFont(new Font("Forte", Font.PLAIN, 15));
		lblPop.setBounds(48, 6, 122, 33);
		pBreuvage2.add(lblPop);

		JLabel lblJuice = new JLabel("Juice : $1.35");
		lblJuice.setHorizontalAlignment(SwingConstants.CENTER);
		lblJuice.setFont(new Font("Forte", Font.PLAIN, 15));
		lblJuice.setBounds(53, 42, 111, 22);
		pBreuvage2.add(lblJuice);

		JLabel lblEau = new JLabel("Eau : $1");
		lblEau.setHorizontalAlignment(SwingConstants.CENTER);
		lblEau.setFont(new Font("Forte", Font.PLAIN, 15));
		lblEau.setBounds(53, 75, 98, 22);
		pBreuvage2.add(lblEau);

		//================================================================= Commande =========================================================================
		JPanel pCommande = new JPanel(); //panel pour la commande
		contentPane.add(pCommande, BorderLayout.CENTER);
		pCommande.setLayout(new BorderLayout(0,0));

		JPanel pCBreuvage = new JPanel(); // commande pour les breuvages
		pCBreuvage.setBorder(new TitledBorder(new LineBorder(new Color(249, 211, 66), 2, true), "Breuvage", TitledBorder.CENTER, TitledBorder.ABOVE_TOP, new Font("Berlin Sans FB Demi", Font.BOLD, 22), new Color(0, 0, 0)));
		pCBreuvage.setBackground(new Color(246, 187, 10));
		pCommande.add(pCBreuvage, BorderLayout.EAST);
		pCBreuvage.setPreferredSize(new Dimension(210,0));
		pCBreuvage.setLayout(new BorderLayout(0, 0));

		JPanel pCBreuvage2 = new JPanel(); //deuxieme panel pour le design des couleurs
		pCBreuvage.add(pCBreuvage2);
		pCBreuvage2.setBackground(new Color(253, 232, 141));
		pCBreuvage2.setLayout(null);

		//Labels pour breauvges
		JLabel lblSorte = new JLabel("Sorte :");
		lblSorte.setBounds(54, 32, 63, 28);
		lblSorte.setHorizontalAlignment(SwingConstants.CENTER);
		lblSorte.setFont(new Font("Forte", Font.PLAIN, 18));
		pCBreuvage2.add(lblSorte);

		JLabel lblNombreB = new JLabel("Nombre :");
		lblNombreB.setHorizontalAlignment(SwingConstants.CENTER);
		lblNombreB.setFont(new Font("Forte", Font.PLAIN, 18));
		lblNombreB.setBounds(10, 223, 88, 28);
		pCBreuvage2.add(lblNombreB);

		//Boutons et ComboBox
		JComboBox<Integer> cbnBreuvage = new JComboBox<Integer>(); // ajouter les nombres au ComboBox
		for(int i = 0; i <= 10; i++) {
			cbnBreuvage.addItem(i);
		}
		cbnBreuvage.setBounds(99, 226, 72, 22);
		pCBreuvage2.add(cbnBreuvage);

		JRadioButton rdbtnPop = new JRadioButton("Pop");
		rdbtnPop.setForeground(Color.BLACK);
		rdbtnPop.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnPop.setBackground(new Color(253, 232, 141));
		rdbtnPop.setBounds(54, 72, 73, 23);
		rdbtnPop.setFocusable(false);
		pCBreuvage2.add(rdbtnPop);

		JRadioButton rdbtnJus = new JRadioButton("Jus");
		rdbtnJus.setForeground(Color.BLACK);
		rdbtnJus.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnJus.setBackground(new Color(253, 232, 141));
		rdbtnJus.setBounds(54, 111, 73, 23);
		rdbtnJus.setFocusable(false);
		pCBreuvage2.add(rdbtnJus);

		JRadioButton rdbtnEau = new JRadioButton("Eau");
		rdbtnEau.setForeground(Color.BLACK);
		rdbtnEau.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnEau.setBackground(new Color(253, 232, 141));
		rdbtnEau.setBounds(54, 148, 73, 23);
		rdbtnEau.setFocusable(false);
		pCBreuvage2.add(rdbtnEau);

		ButtonGroup groupB = new ButtonGroup(); //groupe de radiobutton pour que l'utilisateur puisse selecter seulement un bouton
		groupB.add(rdbtnPop);
		groupB.add(rdbtnJus);
		groupB.add(rdbtnEau);

		JPanel pCPizza = new JPanel(); // commande de la pizza
		pCPizza.setBorder(new TitledBorder(new LineBorder(new Color(249, 211, 66), 2, true), "Pizza", TitledBorder.CENTER, TitledBorder.ABOVE_TOP, new Font("Berlin Sans FB Demi", Font.BOLD, 21), new Color(0, 0, 0)));
		pCPizza.setBackground(new Color(246, 187, 10));
		pCommande.add(pCPizza, BorderLayout.WEST);
		pCPizza.setPreferredSize(new Dimension(400,0));
		pCPizza.setLayout(new BorderLayout(0, 0));

		JPanel pCPizza2 = new JPanel(); //panel pour design
		pCPizza2.setPreferredSize(new Dimension(400,0));
		pCPizza.add(pCPizza2);
		pCPizza2.setBackground(new Color(253, 232, 141));
		pCPizza2.setLayout(null);

		//Labels pour pizza
		JLabel lblTaille1 = new JLabel("Taille :");
		lblTaille1.setHorizontalAlignment(SwingConstants.CENTER);
		lblTaille1.setFont(new Font("Forte", Font.PLAIN, 20));
		lblTaille1.setBounds(29, 86, 82, 22);
		pCPizza2.add(lblTaille1);

		JLabel lblNombre = new JLabel("Nombre :");
		lblNombre.setHorizontalAlignment(SwingConstants.CENTER);
		lblNombre.setFont(new Font("Forte", Font.PLAIN, 18));
		lblNombre.setBounds(29, 198, 82, 22);
		pCPizza2.add(lblNombre);

		JLabel lblGarnitures = new JLabel("Garnitures :");
		lblGarnitures.setHorizontalAlignment(SwingConstants.CENTER);
		lblGarnitures.setFont(new Font("Forte", Font.PLAIN, 18));
		lblGarnitures.setBounds(10, 269, 101, 22);
		pCPizza2.add(lblGarnitures);

		//Boutons et ComboBox
		JRadioButton rdbtnPetit = new JRadioButton("Petit");
		rdbtnPetit.setForeground(new Color(0, 0, 0));
		rdbtnPetit.setBackground(new Color(253, 232, 141));
		rdbtnPetit.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnPetit.setBounds(121, 48, 109, 23);
		rdbtnPetit.setFocusable(false);
		pCPizza2.add(rdbtnPetit);

		JRadioButton rdbtnMoyen = new JRadioButton("Moyen");
		rdbtnMoyen.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnMoyen.setBackground(new Color(253, 232, 141));
		rdbtnMoyen.setBounds(121, 84, 109, 23);
		rdbtnMoyen.setFocusable(false);
		pCPizza2.add(rdbtnMoyen);

		JRadioButton rdbtnLarge = new JRadioButton("Large");
		rdbtnLarge.setFont(new Font("Arial Black", Font.BOLD, 15));
		rdbtnLarge.setBackground(new Color(253, 232, 141));
		rdbtnLarge.setBounds(121, 121, 109, 23);
		rdbtnLarge.setFocusable(false);
		pCPizza2.add(rdbtnLarge);

		JRadioButton rdbtnExtraLarge = new JRadioButton("Extra Large");
		rdbtnExtraLarge.setFont(new Font("Arial Black", Font.BOLD, 14));
		rdbtnExtraLarge.setBackground(new Color(253, 232, 141));
		rdbtnExtraLarge.setBounds(232, 48, 135, 23);
		rdbtnExtraLarge.setFocusable(false);
		pCPizza2.add(rdbtnExtraLarge);

		JRadioButton rdbtnPartySquare = new JRadioButton("Party Square");
		rdbtnPartySquare.setFont(new Font("Arial Black", Font.BOLD, 14));
		rdbtnPartySquare.setBackground(new Color(253, 232, 141));
		rdbtnPartySquare.setBounds(232, 84, 127, 23);
		rdbtnPartySquare.setFocusable(false);
		pCPizza2.add(rdbtnPartySquare);

		ButtonGroup grouprdbtn = new ButtonGroup(); //Groupe de boutons pour selecter seulement un 
		grouprdbtn.add(rdbtnPetit);
		grouprdbtn.add(rdbtnMoyen);
		grouprdbtn.add(rdbtnLarge);
		grouprdbtn.add(rdbtnExtraLarge);
		grouprdbtn.add(rdbtnPartySquare);

		JComboBox<Integer> cbnPizza = new JComboBox<Integer>();
		for(int i = 0; i <= 10; i++) {
			cbnPizza.addItem(i);
		}
		cbnPizza.setBounds(121, 198, 72, 22);
		pCPizza2.add(cbnPizza);

		JComboBox<Integer> cbgPizza = new JComboBox<Integer>();
		for(int i = 0; i <= 10; i++) {
			cbgPizza.addItem(i);
		}
		cbgPizza.setBounds(121, 269, 72, 22);
		pCPizza2.add(cbgPizza);

		//panel pour les boutons d'actions
		JPanel pBoutons = new JPanel();
		pCommande.add(pBoutons, BorderLayout.SOUTH);
		pBoutons.setPreferredSize(new Dimension(0,100));
		pBoutons.setBackground(new Color(246, 187, 10));
		pBoutons.setLayout(null);

		JButton btnAjouter = new JButton("Ajouter"); //bouton pour ajouter a la commande
		btnAjouter.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) { //classe interne anonyme pour prendre l'action de cliquer le bouton
				int n = Integer.parseInt(cbnPizza.getSelectedItem().toString()); //variables pour prendre la valeur des ComboBox, nombre de pizza et garnitures
				int g = Integer.parseInt(cbgPizza.getSelectedItem().toString());
				String taille = ""; // String pour la taille de pizza

				boolean select = false; // voir si un des radiobuttons est selecter
				if (rdbtnPetit.isSelected() || rdbtnMoyen.isSelected() || rdbtnLarge.isSelected()|| rdbtnExtraLarge.isSelected()|| rdbtnPartySquare.isSelected()) {
					select = true;
				}
				if(n > 0 && select) { //Trouver quel taille a ete choisi et donner cette valeur au String taille
					if(rdbtnPetit.isSelected()) {
						taille = "petit";
					} else if(rdbtnMoyen.isSelected()) {
						taille = "moyen";
					}else if(rdbtnLarge.isSelected()) {
						taille = "large";
					}else if(rdbtnExtraLarge.isSelected()) {
						taille = "extra large";
					}else if(rdbtnPartySquare.isSelected()) {
						taille = "party square";
					} 

					//Ajouter la pizza a la commande en utilisant la class Pizza
					commande.add(new Pizza(taille, n, g));
					cbnPizza.setSelectedIndex(0); //reinitialiser les selections
					cbgPizza.setSelectedIndex(0);
					grouprdbtn.clearSelection();

				} else if(n > 0) { //si il y a de l'information manquantes alors donner des messages d'erreur
					JOptionPane.showConfirmDialog(null, "Veuillez choisir la taille de pizza", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				} else if(select) {
					JOptionPane.showConfirmDialog(null, "Veuillez choisir le nombre de pizza", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				} else if(g > 0) {
					JOptionPane.showConfirmDialog(null, "Veuillez choisir la taille et le type de pizza", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				}

				int x = Integer.parseInt(cbnBreuvage.getSelectedItem().toString()); // variable pour prendre le nombre de breuvages

				if(x > 0 && (rdbtnPop.isSelected() || rdbtnJus.isSelected() || rdbtnEau.isSelected())) { // voir si les valeus ont ete choisi et trouver la sorte de breuvage
					String sorte = "";
					if(rdbtnPop.isSelected()) {
						sorte = "pop";
					} else if(rdbtnJus.isSelected()) {
						sorte = "jus";
					}else if(rdbtnEau.isSelected()) {
						sorte = "eau";
					}
					
					//ajouter la commande en utilisant la class breuvage
					commande.add(new Breuvage(sorte, x));
					cbnBreuvage.setSelectedIndex(0);//reinitialiser les selections
					groupB.clearSelection();

				} else if((x > 0 || (rdbtnPop.isSelected() || rdbtnJus.isSelected() || rdbtnEau.isSelected()))){
					if(x == 0){// messages d'erreurs
						JOptionPane.showConfirmDialog(null, "Veuillez choisir le nombre de breauvages", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
					} else if(!(rdbtnPop.isSelected() || rdbtnJus.isSelected() || rdbtnEau.isSelected())){
						JOptionPane.showConfirmDialog(null, "Veuillez choisir le type de breauvages", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
					}
				}
			}
		});
		btnAjouter.setBackground(new Color(253, 232, 141));
		btnAjouter.setFont(new Font("Arial Black", Font.BOLD, 16));
		btnAjouter.setBounds(46, 31, 129, 49);
		pBoutons.add(btnAjouter);
		btnAjouter.setFocusable(false);
		btnAjouter.setBorder(BorderFactory.createEtchedBorder(EtchedBorder.RAISED));

		JButton btnPayer = new JButton("Payer"); //le bouton payer
		btnPayer.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(!commande.isEmpty()) { // voir si la commande est vide si oui donner un message d'erreur si non alors ouvrir une nouvelle fenetre et imprimer la commande
					setVisible(false);
					Fenetre2 f2 = new Fenetre2();
					f2.setVisible(true);

					for(CPrix i : commande) {
						f2.txtCommande.append(i + "\n");
					}
				} else {
					JOptionPane.showConfirmDialog(null, "Veuillez passer votre commande", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				}
			}
		});
		btnPayer.setFont(new Font("Arial Black", Font.BOLD, 16));
		btnPayer.setFocusable(false);
		btnPayer.setBorder(BorderFactory.createEtchedBorder(EtchedBorder.RAISED));
		btnPayer.setBackground(new Color(253, 232, 141));
		btnPayer.setBounds(230, 31, 129, 49);
		pBoutons.add(btnPayer);

		JButton btnQuitter = new JButton("Quitter"); //bouton pour quitter le programme
		btnQuitter.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnQuitter.setFont(new Font("Arial Black", Font.BOLD, 16));
		btnQuitter.setFocusable(false);
		btnQuitter.setBorder(BorderFactory.createEtchedBorder(EtchedBorder.RAISED));
		btnQuitter.setBackground(new Color(253, 232, 141));
		btnQuitter.setBounds(407, 31, 129, 49);
		pBoutons.add(btnQuitter);

	}
}
