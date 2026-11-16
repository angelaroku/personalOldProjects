package asteroidesJuego_SpaceShipGame;


import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferStrategy;

import javax.swing.JFrame;

public class Ventana extends JFrame implements Runnable{
	public static final int WIDTH = 800, HEIGHT = 600;
	private Canvas canvas;
	private Thread thread;
	private boolean running = false;
	private BufferStrategy bs;
	private Graphics g;
	
	
	
	
	public Ventana() {
		setTitle("Space Ship Game");
		setSize(WIDTH, HEIGHT);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setResizable(false);
		setLocationRelativeTo(null);
		setVisible(true);
		
		canvas = new Canvas();
		canvas.setPreferredSize(new Dimension(WIDTH, HEIGHT));
		canvas.setMaximumSize(new Dimension(WIDTH, HEIGHT));
		canvas.setMinimumSize(new Dimension(WIDTH, HEIGHT));
		canvas.setFocusable(true);
		
		add(canvas);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Ventana().start();
		

	}
	
	private void update() {
		
	}
	
	private void draw() {
		bs = canvas.getBufferStrategy();
		
		if (bs==null) {
			canvas.createBufferStrategy(3);
			return;
		}
		
		g=bs.getDrawGraphics();
		
		
		g.drawRect(0, 0, 100, 100);
		
		g.dispose();
		bs.show();
		
		
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		
		while(running) {
			update();
			draw();
		}
		
		stop();
		
	}

	private void start() {
		
		thread = new Thread(this);

		thread.start();
		running = true;
		
		
	}
	
	private void stop() {
		try {
			thread.join();
			running = false;
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
}
