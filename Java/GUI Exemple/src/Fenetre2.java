import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Font;
import java.awt.Toolkit;

import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.border.EmptyBorder;
import javax.swing.border.EtchedBorder;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.GridLayout;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Fenetre2 extends JFrame {

	private JPanel contentPane;
	protected JTextArea txtCommande; // variable pour acceder a l'objet où afficher la commande

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Fenetre2 frame = new Fenetre2();
					frame.setVisible(false); // ne pas ouvrir la fenetre quand le programme est joue
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Fenetre2() {
		setDefaultCloseOperation(JFrame.HIDE_ON_CLOSE); // quand on ferme cette fenetre il se cache seulement 
		ImageIcon img = new ImageIcon("\"C:\\Users\\beeha\\eclipse-workspace\\GUI Exemple\\logo.png\""); 
	    setIconImage(Toolkit.getDefaultToolkit().getImage(Fenetre.class.getResource("/image/pizza.png")));
		setFont(new Font("Bauhaus 93", Font.ITALIC, 20));
		setResizable(false);
		setTitle("Pizza Simmou");
		setBounds(100, 100, 430, 550);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(246, 187, 10));
		contentPane.setBorder(new EmptyBorder(10, 10, 10, 10));

		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		//titre pour la commande
		JLabel lblTitre = new JLabel("Votre commande");
		lblTitre.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 20));
		lblTitre.setBounds(129, 32, 162, 23);
		contentPane.add(lblTitre);
		
		//bouton pour fermer la fenetre
		JButton btnFermer = new JButton("Fermer");
		btnFermer.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); // quand on ferme cette elle ouvre le menu principal
				Fenetre f = new Fenetre();
				f.setVisible(true);
				Fenetre.commande.clear(); // clear le ArrayList commande pour reinitialiser la commande
			}
		});
		btnFermer.setBounds(233, 454, 108, 34);
		btnFermer.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnFermer.setFocusable(false);
		btnFermer.setBorder(BorderFactory.createEtchedBorder(EtchedBorder.RAISED));
		btnFermer.setBackground(new Color(253, 232, 141));
		contentPane.add(btnFermer);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(22, 82, 370, 220);
		contentPane.add(scrollPane);
		
		txtCommande = new JTextArea();//TextArea où afficher la commande
		scrollPane.setViewportView(txtCommande);
		
		JPanel pTotal = new JPanel(); // panel où les totals seront afficher
		pTotal.setBackground(new Color(246, 187, 10)); 
		pTotal.setBounds(22, 323, 212, 105);
		contentPane.add(pTotal);
		pTotal.setLayout(new GridLayout(3, 2, 2, 0)); //layout en grid pour mieux afficher les totals
		
		//Labels pour les totaux
		JLabel lblSubtotal = new JLabel("Subtotal : "); 
		lblSubtotal.setHorizontalAlignment(SwingConstants.RIGHT);
		pTotal.add(lblSubtotal);
		lblSubtotal.setFont(new Font("Tahoma", Font.PLAIN, 13));
		
		JLabel lblSubp = new JLabel("");
		pTotal.add(lblSubp);
		
		JLabel lblTaxes = new JLabel("Taxes (13%) : ");
		lblTaxes.setHorizontalAlignment(SwingConstants.RIGHT);
		pTotal.add(lblTaxes);
		lblTaxes.setFont(new Font("Tahoma", Font.PLAIN, 14));
		
		JLabel lblTaxesp = new JLabel("");
		pTotal.add(lblTaxesp);
		
		JLabel lblTotal = new JLabel("Total : ");
		lblTotal.setHorizontalAlignment(SwingConstants.RIGHT);
		pTotal.add(lblTotal);
		lblTotal.setFont(new Font("Tahoma", Font.PLAIN, 14));
		
		JLabel lblTotalp = new JLabel("");
		pTotal.add(lblTotalp);
		
		JButton btnTotal = new JButton("Total"); // bouton pour afficher les prix totals
		btnTotal.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				double prix = 0; // for loop pour passer a travers le ArryList commande et retrouver le prix de chaque item en utilisant la methode de l'interface CPrix
				for(CPrix i : Fenetre.commande) {
					prix += i.prix();
				}
				lblSubp.setText(String.format("$ %.2f", prix)); // afficher les totaux dans les labels
				lblTaxesp.setText(String.format("$ %.2f", prix * 0.13));
				lblTotalp.setText(String.format("$ %.2f", prix * 1.13));
			}
		});
		btnTotal.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnTotal.setFocusable(false);
		btnTotal.setBorder(BorderFactory.createEtchedBorder(EtchedBorder.RAISED));
		btnTotal.setBackground(new Color(253, 232, 141));
		btnTotal.setBounds(68, 454, 108, 34);
		contentPane.add(btnTotal);
		
		
		addWindowListener(new WindowAdapter() { //quand on ferme la fenetre avec le X elle ouvre une nouvelle fenetre et clear la commande
			@Override
			public void windowClosing(WindowEvent e) {
				Fenetre f = new Fenetre();
				f.setVisible(true);
				Fenetre.commande.clear();
			}
		});
	}
}
