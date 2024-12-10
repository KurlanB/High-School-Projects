import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.CompoundBorder;
import javax.swing.border.EmptyBorder;
import javax.swing.border.LineBorder;
import javax.swing.border.TitledBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import java.awt.Font;
import javax.swing.SwingConstants;
import java.awt.Color;
import java.awt.SystemColor;
import javax.swing.UIManager;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.io.EOFException;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class Banque extends JFrame {//Page d'acceuil ou on peut choisir entre ouvrir un compte ou se connecter a un compte existant

	private JPanel contentPane;
	private JTextField txtCode;
	private JTextField txtNom;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Banque frame = new Banque();//creer la fenetre est la faire apparaitre
					frame.setVisible(true);
					WriteFile.openFile();// ouvrir le fichier texte
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Banque() {
		setResizable(false);
		setTitle("Menu d'identification");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 570, 675);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(255, 255, 204));
		contentPane.setForeground(Color.BLACK);
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

		setContentPane(contentPane);
		contentPane.setLayout(null);

		txtCode = new JTextField();
		txtCode.addFocusListener(new FocusAdapter() {
			@Override
			public void focusGained(FocusEvent e) {
				if(txtCode.getText().equals("Code d'identification")) { //avoir des placeholders pour les boites textes
					txtCode.setText("");
					txtCode.setForeground(new Color (0, 0, 0));
				}
			}
			@Override
			public void focusLost(FocusEvent e) {
				if(txtCode.getText().isEmpty()) {
					txtCode.setForeground(new Color(192, 192, 192));
					txtCode.setText("Code d'identification");
				}
			}
		});
		txtCode.setForeground(new Color(192, 192, 192));
		txtCode.setText("Code d'identification");
		txtCode.setHorizontalAlignment(SwingConstants.CENTER);
		txtCode.setFont(new Font("Tahoma", Font.PLAIN, 24));
		txtCode.setBounds(58, 191, 433, 60);
		contentPane.add(txtCode);
		txtCode.setColumns(10);

		txtNom = new JTextField();
		txtNom.addFocusListener(new FocusAdapter() {
			@Override
			public void focusGained(FocusEvent e) {
				if(txtNom.getText().equals("Nom d'utilisateur")) { //encore des placeholders pour l'autre boite
					txtNom.setText("");;
					txtNom.setForeground(new Color (0, 0, 0));
				}
			}
			@Override
			public void focusLost(FocusEvent e) {
				if(txtNom.getText().isEmpty()) {
					txtNom.setForeground(new Color(192, 192, 192));
					txtNom.setText("Nom d'utilisateur");
				}
			}
		});
		txtNom.setText("Nom d'utilisateur");
		txtNom.setForeground(new Color(192, 192, 192));
		txtNom.setHorizontalAlignment(SwingConstants.CENTER);
		txtNom.setFont(new Font("Tahoma", Font.PLAIN, 24));
		txtNom.setBounds(58, 285, 433, 60);
		contentPane.add(txtNom);
		txtNom.setColumns(10);

		JLabel lblBienvenue = new JLabel("Bienvenue à");
		lblBienvenue.setForeground(new Color(41, 41, 41));
		lblBienvenue.setHorizontalAlignment(SwingConstants.CENTER);
		lblBienvenue.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 40));
		lblBienvenue.setBounds(132, 25, 281, 60);
		contentPane.add(lblBienvenue);

		JButton btnSignup = new JButton("S'inscrire"); // quand on clique inscrire, ouvrir la page pour creer un compte
		btnSignup.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false);
				CreationCompte c = new CreationCompte();
				c.setVisible(true);
			}
		});
		btnSignup.setFont(new Font("Tahoma", Font.BOLD, 15));
		btnSignup.setBounds(211, 442, 121, 33);
		btnSignup.setBackground(new Color(102, 153, 255));
		btnSignup.setForeground(new Color(255, 255, 255));
		btnSignup.setBorder(new LineBorder(new Color(102, 153, 255)));
		btnSignup.setFocusable(false);
		contentPane.add(btnSignup);

		JButton btnConnect = new JButton("Se connecter");// se connecter a un compte existant
		btnConnect.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					int code = Integer.parseInt(txtCode.getText()); //avoir les input de code et nom
					String text = txtNom.getText().trim();
					Compte u = WriteFile.readCode(code); // trouver le code dans le fichier text
					if(u != null) {
						if (u.getNom().equals(text)) {
							Menu.lblC.setText(Integer.toString(code)); // envoyer le code a la prochaine fenetre pour savoir quelle compte est connecte
							Menu.update(code); // mettre a jour les details du compte
							setVisible(false); //ouvrir la fenetre de menu du compte choisi
							Menu m = new Menu();
							m.setVisible(true);
						} else if(!u.getNom().equals(text)) { // si il y a des erreurs comme ne pas entrer les bons details et ne pas entrer des nombres pour le code
							JOptionPane.showConfirmDialog(null, "Le code et nom d'utilisateur ne correspondent pas", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE); 
						}
					}
				}catch(NumberFormatException numberFormatException){
					JOptionPane.showConfirmDialog(null, "Le code doit seulement avoir des entiers", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				}
			}
		});
		
		btnConnect.setBackground(new Color(102, 153, 255));
		btnConnect.setForeground(new Color(255, 255, 255));
		btnConnect.setFont(new Font("Tahoma", Font.BOLD, 23));
		btnConnect.setBounds(160, 375, 221, 56);
		btnConnect.setBorder(new LineBorder(new Color(102, 153, 255)));
		btnConnect.setFocusable(false);
		contentPane.add(btnConnect);

		JButton btnQuitter = new JButton("Quitter"); // quitter le programme
		btnQuitter.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				WriteFile.closeFile();
				System.exit(0);
			}
		});
		btnQuitter.setFont(new Font("Tahoma", Font.BOLD, 13));
		btnQuitter.setBackground(new Color(102, 153, 255));
		btnQuitter.setForeground(new Color(255, 255, 255));
		btnQuitter.setBounds(221, 568, 99, 24);
		btnQuitter.setBorder(new LineBorder(new Color(102, 153, 255)));
		contentPane.add(btnQuitter);
		btnQuitter.setFocusable(false);

		JLabel lblParadiseBank = new JLabel("Paradise Bank");
		lblParadiseBank.setHorizontalAlignment(SwingConstants.CENTER);
		lblParadiseBank.setForeground(new Color(102, 153, 255));
		lblParadiseBank.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 45));
		lblParadiseBank.setBounds(119, 94, 311, 60);
		contentPane.add(lblParadiseBank);
	}
}
