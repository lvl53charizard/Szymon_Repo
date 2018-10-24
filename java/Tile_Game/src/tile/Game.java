package tile;

import java.awt.Graphics;
import java.awt.image.BufferStrategy;
import java.util.Random;

import disp.Display;
import gfx.Assets;
import input.KeyManager;

public class Game implements Runnable {

	private Display display;
	private Thread thread;
	private boolean running = false;
	private BufferStrategy bs;
	private Graphics g;
	
	public int width, height;
	public String title;
	
	public int o;
	
	private State gameState;
	private State menuState;
	
	private KeyManager keyManager;
	Random rand = new Random(); 
	public int value = rand.nextInt(1280);
	public int value1 = rand.nextInt(720);
	
	
	public Game(String title, int width, int height) {
		
		this.width = width;
		this.height = height;
		this.title = title;
		keyManager = new KeyManager();
		
		
	}

	private void init() {
		
		display = new Display(title, width, height);
		display.getFrame().addKeyListener(keyManager);
		Assets.init();
		
		gameState = new GameState(this);
		menuState = new MenuState(this);
		State.setState(gameState);
	}
	
	private void tick() {
		keyManager.tick();
		
		if(State.getState() != null)
			State.getState().tick();
	}
	
	private void render() {
		bs = display.getCanvas().getBufferStrategy();
		if(bs == null) {
			display.getCanvas().createBufferStrategy(3);
			return;
		}
		g = bs.getDrawGraphics();
		
		g.clearRect(0, 0, width, height);
		// Draw
		for(int i = 0; i < 1280; i += 32) {
			for(int o = 0; o < 720; o += 32) {
				g.drawImage(Assets.grass, i, o, null);
			}
		}
		
			
		
		if(State.getState() != null)
			State.getState().render(g);
		
		
		
		g.drawImage(Assets.gravel, 32, 128, null);
		g.drawImage(Assets.stone, 128, 128 , null);
		
		// Draw Ends
		bs.show();
		g.dispose();
	}
	
	
	public void run() {
		
		init();
		
		int fps = 60;
		double timePerTick = 1000000000 / fps;
		double delta = 0;
		long now;
		long lastTime = System.nanoTime();
		long timer = 0;
		int ticks = 0;
		
		while(running){
			now = System.nanoTime();
			delta += (now - lastTime) / timePerTick;
			timer += now - lastTime;
			lastTime = now;
			
			if(delta >= 1){
				tick();
				render();
				ticks++;
				delta--;
			}
			
			if(timer >= 1000000000){
				System.out.println("fps: " + ticks);
				ticks = 0;
				timer = 0;
			}
		}
		
		stop();
		
	}
	
	public KeyManager getKeyManager() {
		return keyManager;
	}
	
	public synchronized void start() {
		
		if(running)
			return;
		running = true;
		thread = new Thread(this);
		thread.start();
		
	}
	
	public synchronized void stop() {
		if(!running)
			return;
		running = false;
		try {
			thread.join();
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	
}
