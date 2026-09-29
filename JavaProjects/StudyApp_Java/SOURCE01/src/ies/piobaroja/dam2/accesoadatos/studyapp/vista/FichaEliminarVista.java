package ies.piobaroja.dam2.accesoadatos.studyapp.vista;

import javax.swing.JButton;
import javax.swing.JPanel;

import ies.piobaroja.dam2.accesoadatos.studyapp.controlador.FichaEliminarControlador;


public class FichaEliminarVista extends JPanel{

	private static final long serialVersionUID = 1L;
	
	private JButton btnNewButtonEliminarFicha ;
	
	private FichaEliminarControlador controlador;
	
	public FichaEliminarVista() {
		setLayout(null);


		btnNewButtonEliminarFicha = new JButton("Eliminar");
		btnNewButtonEliminarFicha.setBounds(172, 196, 105, 27);
		add(btnNewButtonEliminarFicha);
		//conexion de boton con controlador
		btnNewButtonEliminarFicha.addActionListener(controlador);

		
	}
	//Metodos que recogen datos relacionados con más clases que la vista

}
