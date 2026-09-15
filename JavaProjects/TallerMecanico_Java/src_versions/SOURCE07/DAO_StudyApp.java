//NUEVO DAO REVISAR
package ies.piobaroja.dam2.accesoadatos.studyapp.dao;

import ies.piobaroja.dam2.accesoadatos.studyapp.modelo.StudyApp;

public class DAO_StudyApp {
	private static DAO_StudyApp instancia=null;
	private StudyApp studyApp;
	
	
	private DAO_StudyApp() {
		studyApp=new StudyApp() ;
	}

	public static DAO_StudyApp getInstancia() {
		if (instancia == null) {
			instancia = new DAO_StudyApp();
		}
		return instancia;
	}
	
	//METODOS CRUD enlazados con modelo "StudyApp"
	
	
	
	 
}
