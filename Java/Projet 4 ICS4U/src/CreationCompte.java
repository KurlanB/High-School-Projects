import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.border.LineBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Font;
import java.awt.Color;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.JComboBox;
import javax.swing.ButtonGroup;
import javax.swing.Icon;
import javax.swing.JButton;
import javax.swing.JRadioButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.EOFException;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.awt.event.WindowStateListener;

public class CreationCompte extends JFrame{

	private JPanel contentPane;
	private static JTextField txtNom;
	private JLabel lblDepot;
	private JLabel lblDecouvert;
	private JLabel lblDebit;
	private static JTextField txtDecouvert;
	private static JTextField txtDebit;
	private static JTextField txtDepot; 
	private JButton btnCreer;
	private JButton btnRetourner;
	private static JRadioButton rdbtnNon;
	private static JRadioButton rdbtnNon2;
	private static JRadioButton rdbtnNon3;
	private static JRadioButton rdbtnOui2;
	private static JRadioButton rdbtnOui3;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					CreationCompte frame = new CreationCompte();
					frame.setVisible(false);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public CreationCompte() {
		setResizable(false);
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) { //ouvrir la page d'accueil quand on ferme cette fenetre
				Banque b = new Banque();
				b.setVisible(true);
			}
		});
		setTitle("Création de Compte");
		setBounds(100, 100, 595, 430);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(255, 250, 205));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

		setContentPane(contentPane);
		contentPane.setLayout(null);

		JLabel lblNom = new JLabel("*Nom du titulaire : ");
		lblNom.setHorizontalAlignment(SwingConstants.RIGHT);
		lblNom.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblNom.setBounds(34, 97, 146, 40);
		contentPane.add(lblNom);

		JLabel lblTitre = new JLabel("Création du Compte");
		lblTitre.setForeground(new Color(102, 153, 255));
		lblTitre.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 27));
		lblTitre.setBounds(160, 23, 255, 50);
		contentPane.add(lblTitre);

		txtNom = new JTextField();
		txtNom.setFont(new Font("Arial", Font.PLAIN, 14));
		txtNom.setBounds(190, 100, 313, 32);
		contentPane.add(txtNom);
		txtNom.setColumns(10);

		lblDepot = new JLabel("Depot initial : ");
		lblDepot.setHorizontalAlignment(SwingConstants.RIGHT);
		lblDepot.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDepot.setBounds(34, 148, 146, 40);
		contentPane.add(lblDepot);

		lblDecouvert = new JLabel("Decouvert maximal : ");
		lblDecouvert.setHorizontalAlignment(SwingConstants.RIGHT);
		lblDecouvert.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDecouvert.setBounds(10, 199, 170, 40);
		contentPane.add(lblDecouvert);

		lblDebit = new JLabel("Debit maximal : ");
		lblDebit.setHorizontalAlignment(SwingConstants.RIGHT);
		lblDebit.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDebit.setBounds(10, 250, 170, 40);
		contentPane.add(lblDebit);

		txtDepot = new JTextField();
		txtDepot.setText("0");
		txtDepot.setFont(new Font("Tahoma", Font.PLAIN, 12));
		txtDepot.setEnabled(false);
		txtDepot.setBounds(190, 154, 120, 27);
		contentPane.add(txtDepot);

		txtDecouvert = new JTextField();
		txtDecouvert.setText("800");
		txtDecouvert.setFont(new Font("Tahoma", Font.PLAIN, 12));
		txtDecouvert.setEnabled(false);
		txtDecouvert.setBounds(190, 206, 120, 27);
		contentPane.add(txtDecouvert);

		txtDebit = new JTextField();
		txtDebit.setText("1000");
		txtDebit.setFont(new Font("Tahoma", Font.PLAIN, 12));
		txtDebit.setEnabled(false);
		txtDebit.setBounds(190, 259, 120, 27);
		contentPane.add(txtDebit);

		btnCreer = new JButton("Créer un compte");
		btnCreer.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(txtNom.getText().isBlank()) {
					JOptionPane.showConfirmDialog(null, "Veuillez entrez un nom valide", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				} else if (Double.parseDouble(txtDepot.getText())  < 0 || Double.parseDouble(txtDebit.getText()) < 0 || Double.parseDouble(txtDecouvert.getText()) < 0) {
					JOptionPane.showConfirmDialog(null, "Entrez seulement des valeurs positives", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				} else {
					if (ajouterc()) {
						setVisible(false);
						Banque b = new Banque();
						b.setVisible(true);
					}
				}
			}
		});
		btnCreer.setBackground(new Color(102, 153, 255));
		btnCreer.setForeground(new Color(255, 255, 255));
		btnCreer.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnCreer.setBounds(192, 324, 146, 40);
		btnCreer.setBorder(new LineBorder(new Color(102, 153, 255)));
		btnCreer.setFocusable(false);
		contentPane.add(btnCreer);

		btnRetourner = new JButton("Retourner");
		btnRetourner.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false);
				Banque f = new Banque();
				f.setVisible(true);
			}
		});
		btnRetourner.setBounds(371, 324, 146, 40);
		btnRetourner.setBackground(new Color(102, 153, 255));
		btnRetourner.setForeground(new Color(255, 255, 255));
		btnRetourner.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnRetourner.setBorder(new LineBorder(new Color(102, 153, 255)));
		btnRetourner.setFocusable(false);
		contentPane.add(btnRetourner);

		JRadioButton rdbtnOui = new JRadioButton("Oui");
		rdbtnOui.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDepot.setEnabled(true);
				txtDepot.setText("");
			}
		});
		rdbtnOui.setForeground(new Color(0, 0, 0));
		rdbtnOui.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnOui.setBounds(354, 157, 69, 23);
		rdbtnOui.setBackground(new Color(255, 250, 205));
		rdbtnOui.setFocusable(false);
		contentPane.add(rdbtnOui);

		rdbtnNon = new JRadioButton("Non");
		rdbtnNon.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDepot.setEnabled(false);
				txtDepot.setText("0");
			}
		});
		rdbtnNon.setSelected(true);
		rdbtnNon.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnNon.setBackground(new Color(255, 250, 205));
		rdbtnNon.setBounds(443, 157, 80, 23);
		rdbtnNon.setFocusable(false);
		contentPane.add(rdbtnNon);

		ButtonGroup group = new ButtonGroup();
		group.add(rdbtnOui);
		group.add(rdbtnNon);

		rdbtnNon2 = new JRadioButton("Non");
		rdbtnNon2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDecouvert.setEnabled(false);
				txtDecouvert.setText("800");
			}
		});
		rdbtnNon2.setSelected(true);
		rdbtnNon2.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnNon2.setBackground(new Color(255, 250, 205));
		rdbtnNon2.setBounds(443, 210, 80, 23);
		rdbtnNon2.setFocusable(false);
		contentPane.add(rdbtnNon2);

		rdbtnOui2 = new JRadioButton("Oui");
		rdbtnOui2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDecouvert.setEnabled(true);
				txtDecouvert.setText("");
			}
		});
		rdbtnOui2.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnOui2.setBackground(new Color(255, 250, 205));
		rdbtnOui2.setBounds(354, 210, 69, 23);
		rdbtnOui2.setFocusable(false);
		contentPane.add(rdbtnOui2);

		ButtonGroup group2 = new ButtonGroup();
		group2.add(rdbtnOui2);
		group2.add(rdbtnNon2);

		rdbtnNon3 = new JRadioButton("Non");
		rdbtnNon3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDebit.setEnabled(false);
				txtDebit.setText("1000");
			}
		});
		rdbtnNon3.setSelected(true);
		rdbtnNon3.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnNon3.setBackground(new Color(255, 250, 205));
		rdbtnNon3.setBounds(443, 261, 80, 23);
		rdbtnNon3.setFocusable(false);
		contentPane.add(rdbtnNon3);

		rdbtnOui3 = new JRadioButton("Oui");
		rdbtnOui3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtDebit.setEnabled(true);
				txtDebit.setText("");
			}
		});
		rdbtnOui3.setFont(new Font("Tahoma", Font.PLAIN, 15));
		rdbtnOui3.setBackground(new Color(255, 250, 205));
		rdbtnOui3.setBounds(354, 261, 69, 23);
		rdbtnOui3.setFocusable(false);
		contentPane.add(rdbtnOui3);

		ButtonGroup group3 = new ButtonGroup();
		group3.add(rdbtnOui3);
		group3.add(rdbtnNon3);
	}

	public static boolean ajouterc(){	
		boolean check = false;
		Compte compte;
		String nom = "";
		double depot = 0, decouvert = 0, debit = 0;
		try {
			nom = txtNom.getText();
			depot = Integer.parseInt(txtDepot.getText());
			decouvert = Integer.parseInt(txtDecouvert.getText());
			debit = Integer.parseInt(txtDebit.getText());

			if(depot == 0) {
				compte = new Compte(nom, decouvert, debit);
			} else {
				compte = new Compte(nom, decouvert, debit, depot);
			}
			try{
				// sérialisation de l'objet client
				WriteFile.output.writeObject(compte);
				JOptionPane.showConfirmDialog(null, "Votre code de compte est " + compte.getCode(), "Bonjour " + compte.getNom(), JOptionPane.DEFAULT_OPTION, JOptionPane.PLAIN_MESSAGE);
				check = true;
			}
			catch (IOException ioException){
				JOptionPane.showConfirmDialog(null, "Erreur à entrer dans le fichier", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
			}	
		}catch(NumberFormatException e) {
			JOptionPane.showConfirmDialog(null, "Entrez des valeurs valides", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
		}
		return check;
	}
}
