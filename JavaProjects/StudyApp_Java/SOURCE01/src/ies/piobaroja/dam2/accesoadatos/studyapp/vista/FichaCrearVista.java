package ies.piobaroja.dam2.accesoadatos.studyapp.vista;

import javax.swing.JPanel;

import ies.piobaroja.dam2.accesoadatos.studyapp.controlador.FichaCrearControlador;

import javax.swing.JButton;

public class FichaCrearVista extends JPanel{

	private static final long serialVersionUID = 1L;
	
	private JButton btnNewButtonCrearFicha;
	private FichaCrearControlador controlador;
	
	public FichaCrearVista() {
		setLayout(null);
		
		
		
		btnNewButtonCrearFicha = new JButton("Crear");
		btnNewButtonCrearFicha.setBounds(172, 196, 105, 27);
		add(btnNewButtonCrearFicha);
		//conexion de boton con controlador
		btnNewButtonCrearFicha.addActionListener(controlador);

		
	}
	
	//Metodos que recogen datos relacionados con más clases que la vista

}
