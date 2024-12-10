import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.border.MatteBorder;

import java.awt.FlowLayout;
import java.awt.BorderLayout;
import java.awt.Color;

import javax.swing.BoxLayout;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.EOFException;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Font;
import javax.swing.JTextField;
import java.awt.Component;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Menu extends JFrame {

	private JPanel contentPane;
	private JTextField txtDeb;
	private JTextField txtCred;
	private JTextField txtTCode;
	protected static JLabel lblC = new JLabel("");
	protected static JLabel lblS = new JLabel("");
	protected static JLabel lblSit = new JLabel("");
	protected static JLabel lblT = new JLabel("");
	protected static JLabel lblD = new JLabel("");
	protected static JLabel lblDeb = new JLabel("");
	private JTextField txtTran;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Menu frame = new Menu();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Menu() {
		setResizable(false);
		setTitle("Compte");
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) { //quand la fenetre se ferme toujours ouvrir la page d'accueil 
				Banque b = new Banque();
				b.setVisible(true);
			}
		});
		setDefaultCloseOperation(JFrame.HIDE_ON_CLOSE);
		setBounds(100, 100, 750, 405);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(255, 255, 204));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.X_AXIS));

		JPanel pDetails = new JPanel();
		contentPane.add(pDetails);
		pDetails.setLayout(null);
		pDetails.setBorder(new MatteBorder(0, 0, 0, 2, Color.black));
		pDetails.setBackground(new Color(255, 255, 204));

		JLabel lblCode = new JLabel("Code :");
		lblCode.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblCode.setBounds(21, 85, 53, 31);
		pDetails.add(lblCode);

		JLabel lblNom = new JLabel("Nom titulaire :");
		lblNom.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblNom.setBounds(21, 127, 112, 31);
		pDetails.add(lblNom);

		JLabel lblDecouvertMax = new JLabel("Decouvert max :");
		lblDecouvertMax.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDecouvertMax.setBounds(21, 169, 131, 31);
		pDetails.add(lblDecouvertMax);

		JLabel lblDebitMax = new JLabel("Debit max :");
		lblDebitMax.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDebitMax.setBounds(21, 211, 90, 31);
		pDetails.add(lblDebitMax);

		JLabel lblSituation = new JLabel("Situation :");
		lblSituation.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblSituation.setBounds(21, 253, 77, 31);
		pDetails.add(lblSituation);

		JLabel lblSolde = new JLabel("Solde :");
		lblSolde.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblSolde.setBounds(21, 295, 53, 31);
		pDetails.add(lblSolde);

		JLabel lblDetail = new JLabel("Details du compte");
		lblDetail.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 27));
		lblDetail.setBounds(76, 23, 236, 51);
		lblDetail.setForeground(new Color(102, 153, 255));
		pDetails.add(lblDetail);

		lblC.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblC.setBounds(80, 85, 272, 31);
		pDetails.add(lblC);

		lblT.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblT.setBounds(136, 127, 216, 31);
		pDetails.add(lblT);

		lblD.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblD.setBounds(156, 169, 196, 31);
		pDetails.add(lblD);

		lblDeb.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblDeb.setBounds(110, 211, 242, 31);
		pDetails.add(lblDeb);

		lblSit.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblSit.setBounds(108, 253, 244, 31);
		pDetails.add(lblSit);

		lblS.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblS.setBounds(84, 295, 268, 31);
		pDetails.add(lblS);

		JPanel pActions = new JPanel();
		contentPane.add(pActions);
		pActions.setLayout(null);
		pActions.setBackground(new Color(255, 255, 204));

		JLabel lblTransaction = new JLabel("Transactions");
		lblTransaction.setForeground(new Color(102, 153, 255));
		lblTransaction.setFont(new Font("Berlin Sans FB Demi", Font.BOLD, 27));
		lblTransaction.setBounds(96, 22, 159, 51);
		pActions.add(lblTransaction);

		txtDeb = new JTextField();
		txtDeb.setBounds(194, 104, 112, 31);
		pActions.add(txtDeb);
		txtDeb.setColumns(10);

		txtCred = new JTextField();
		txtCred.setColumns(10);
		txtCred.setBounds(194, 158, 112, 31);
		pActions.add(txtCred);

		txtTCode = new JTextField();
		txtTCode.setColumns(10);
		txtTCode.setBounds(194, 263, 74, 31);
		pActions.add(txtTCode);

		JButton btnDebit = new JButton("Debit");
		btnDebit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					if(!txtDeb.getText().isBlank()) {
						int c = Integer.parseInt(lblC.getText()); //si la boite texte n'est pas vide alors faire la transaction
						ArrayList<Compte> comptes = new ArrayList<>(); //creer une liste de compte pour stocker les comptes
						try {
							comptes = WriteFile.read(); //lire le fichier et mettre les comptes dans la liste
						} catch (ClassNotFoundException e1) {
							e1.printStackTrace();
						} catch (IOException e1) {
							e1.printStackTrace();
						}

						for(Compte i : comptes) { //passer a travers la liste et trouver le code de l'utilisateur 
							if(i.getCode() == c) {
								i.withdraw(Double.parseDouble(txtDeb.getText())); //faire la trasaction avec le montant ecrit
								txtDeb.setText("");//reset la boite texte
							}
						}

						try {
							WriteFile.write(comptes); //reecrire les comptes modifies dans le fichier
						} catch (IOException e1) {
							e1.printStackTrace();
						}

						update(c); //mettre a jour les details
					} else {
						JOptionPane.showConfirmDialog(null, "Entrez une valeur à debiter", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE); //si la boite est vide
					}
				}catch(NumberFormatException n) {
					JOptionPane.showConfirmDialog(null, "Entrez un nombre", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE); // si un String est entre
				}
			}
		});
		btnDebit.setForeground(Color.WHITE);
		btnDebit.setBackground(new Color(102, 153, 255));
		btnDebit.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnDebit.setBounds(49, 102, 112, 31);
		btnDebit.setFocusable(false);
		pActions.add(btnDebit);

		JButton btnCred = new JButton("Credit");
		btnCred.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					if(!txtCred.getText().isBlank()) { //si la boite n'est pas vide faire la transaction
						int c = Integer.parseInt(lblC.getText());
						ArrayList<Compte> comptes = new ArrayList<>(); // creer une liste et lire les comptes du fichier et placer dans la liste
						try {
							comptes = WriteFile.read();
						} catch (ClassNotFoundException e1) {
							e1.printStackTrace();
						} catch (IOException e1) {
							e1.printStackTrace();
						}

						for(Compte i : comptes) { //trouver le compte de l'utilisateur et faire la transacition
							if(i.getCode() == c) {
								i.deposit(Double.parseDouble(txtCred.getText()));
								txtCred.setText("");
							}
						}

						try {
							WriteFile.write(comptes); //reecrire les comptes dans le fichier
						} catch (IOException e1) {
							e1.printStackTrace();
						}

						update(c); //mettre a jour les details
					} else { //les erreurs
						JOptionPane.showConfirmDialog(null, "Entrez une valeur à crediter", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
					}
				}catch(NumberFormatException n) {
					JOptionPane.showConfirmDialog(null, "Entrez un nombre", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				}
			}
		});
		btnCred.setForeground(Color.WHITE);
		btnCred.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnCred.setBackground(new Color(102, 153, 255));
		btnCred.setBounds(49, 156, 112, 31);
		btnCred.setFocusable(false);
		pActions.add(btnCred);

		JButton btnTran = new JButton("Transfer");
		btnTran.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					if(!txtTran.getText().isBlank() && !txtTCode.getText().isBlank()) { // si les deux boites ne sont pas vides
						int c = Integer.parseInt(lblC.getText()); //truover le code de l'utilisateur et le code du compte a transferer
						int t = Integer.parseInt(txtTCode.getText());
						ArrayList<Compte> comptes = new ArrayList<>(); //creer une liste et mettre les objets dans le fichier dans cette liste
						try {
							comptes = WriteFile.read();
						} catch (ClassNotFoundException e1) {
							e1.printStackTrace();
						} catch (IOException e1) {
							e1.printStackTrace();
						}

						for(Compte i : comptes) {// trouver les deux comptes dans la liste 
							if(i.getCode() == t) {
								if(i.getCode() == c) {
									i.withdraw(Double.parseDouble(txtTran.getText())); //retirer de l'argent du compte de l'utilisateur 
								}
								i.deposit(Double.parseDouble(txtTran.getText())); //mettre de l'argent dans l'autre compte
								txtTran.setText("");
								txtTCode.setText("");
							} else {
								JOptionPane.showConfirmDialog(null, "Cette utilisateur n'existe pas", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
							} //erreur
						}
						try {
							WriteFile.write(comptes);
						} catch (IOException e1) { //reecrire dans le fichier
							e1.printStackTrace();
						}
						update(c); //mettre a jour les details
					} else if (txtTran.getText().isBlank()){ // erreurs
						JOptionPane.showConfirmDialog(null, "Entrez une valeur à transferer", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
					} else if(txtTCode.getText().isBlank()) {
						JOptionPane.showConfirmDialog(null, "Entrez le code de l'utilisateur a laquelle vous voulez faire un transfere", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
					}
				}catch(NumberFormatException n) {
					JOptionPane.showConfirmDialog(null, "Entrez un nombre", "Erreur", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE);
				}
			}
		});
		btnTran.setForeground(Color.WHITE);
		btnTran.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnTran.setBackground(new Color(102, 153, 255));
		btnTran.setBounds(49, 210, 112, 31);
		btnTran.setFocusable(false);
		pActions.add(btnTran);

		JButton btnRetour = new JButton("Retour");
		btnRetour.addActionListener(new ActionListener() { //retourner a la page d'accueil
			public void actionPerformed(ActionEvent e) {
				setVisible(false);
				Banque b = new Banque();
				b.setVisible(true);
			}
		});
		btnRetour.setForeground(Color.WHITE);
		btnRetour.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnRetour.setBackground(new Color(102, 153, 255));
		btnRetour.setBounds(119, 314, 112, 31);
		btnRetour.setFocusable(false);
		pActions.add(btnRetour);
		
		txtTran = new JTextField();
		txtTran.setColumns(10);
		txtTran.setBounds(194, 210, 112, 31);
		pActions.add(txtTran);
		
		JLabel lblCode_1 = new JLabel("Code :");
		lblCode_1.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblCode_1.setBounds(108, 261, 53, 31);
		pActions.add(lblCode_1);
	}

	public static void update(int code) { //mettre a jour les details du compte
		lblT.setText(WriteFile.readCode(code).getNom());
		lblD.setText(Double.toString(WriteFile.readCode(code).getDmax()));
		lblDeb.setText(Double.toString(WriteFile.readCode(code).getDebitmax()));
		lblSit.setText(WriteFile.readCode(code).getSituation());
		lblS.setText(Double.toString(WriteFile.readCode(code).getSolde()));
	}
}
