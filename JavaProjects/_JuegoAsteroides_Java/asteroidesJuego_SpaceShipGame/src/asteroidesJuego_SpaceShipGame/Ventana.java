package asteroidesJuego_SpaceShipGame;


import javax.swing.JFrame;

public class Ventana extends JFrame{
	public static final int WIDTH = 800, HEIGHT = 600;
	
	
	public Ventana() {
		setTitle("Space Ship Game");
		setSize(WIDTH, HEIGHT);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setResizable(false);
		setLocationRelativeTo(null);
		
		setVisible(true);
		
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Ventana();
		

	}

}
