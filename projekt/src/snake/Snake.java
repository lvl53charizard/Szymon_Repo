package snake;

import java.awt.Dimension;
import java.awt.Point;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import java.util.Random;

import javax.swing.JFrame;
import javax.swing.Timer;









public class Snake implements ActionListener, KeyListener
{
	public static Snake snake;
	
	public JFrame jframe;
	
	public RenderPanel renderPanel;
	
	public Timer timer = new Timer(25, this);
	
	public ArrayList<Point> snakeParts = new ArrayList<Point>();
	
	public static final int SCALE = 10;
	
	public static final int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3;
	
	public int ticks = 0, direction = DOWN, score, tailLength = 10, time;
	
	public Point head, cherry, cherry1, cherry2;
	
	public Random random;
	
	public boolean over = false, paused;
	
	public Dimension dim;

	public Snake()
	{
		dim = Toolkit.getDefaultToolkit().getScreenSize();
		jframe = new JFrame("Snake");
		jframe.setVisible(true);
		jframe.setSize(800, 700);
		jframe.setResizable(false);
		jframe.setLocation(dim.width / 2 - jframe.getWidth() / 2, dim.height / 2 - jframe.getHeight() / 2);
		jframe.add(renderPanel = new RenderPanel());
		jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jframe.addKeyListener(this);
		startGame();
	}
	
	public void startGame()
	{
		over = false;
		paused = false;
		time = 0;
		score = 0;
		tailLength = 14;
		ticks = 0;
		direction = DOWN;
		head = new Point(0, -1);
		random = new Random();
		snakeParts.clear();
		cherry = new Point(random.nextInt(79), random.nextInt(66));
		cherry1 = new Point(random.nextInt(79), random.nextInt(66));
		cherry2 = new Point(random.nextInt(79), random.nextInt(66));
		timer.start();
	}

	@Override
	public void actionPerformed(ActionEvent arg0)
	{
		renderPanel.repaint();
		ticks++;

		if (ticks % 2 == 0 && head != null && !over && !paused)
		{
			time++;

			snakeParts.add(new Point(head.x, head.y));

			if (direction == UP)
			{
				if (head.y - 1 >= 0 && noTailAt(head.x, head.y - 1)){
					head = new Point(head.x, head.y - 1);
				}
				else{
					over = true;
				}
			}

			if (direction == DOWN)
			{
				if (head.y + 1 < 67 && noTailAt(head.x, head.y + 1)){
					head = new Point(head.x, head.y + 1);
				}
				else{
					over = true;
				}
			}

			if (direction == LEFT)
			{
				if (head.x - 1 >= 0 && noTailAt(head.x - 1, head.y)){
					head = new Point(head.x - 1, head.y);
				}
				else{
					over = true;
				}
			}

			if (direction == RIGHT)
			{
				if (head.x + 1 < 80 && noTailAt(head.x + 1, head.y)){
					head = new Point(head.x + 1, head.y);
				}
				else{
					over = true;
				}
			}

			if (snakeParts.size() > tailLength)
			{
				snakeParts.remove(0);

			}
			//Red
			if (cherry != null)
			{
				if (head.equals(cherry))
				{
					score += 10;
					tailLength++;
					cherry.setLocation(random.nextInt(79), random.nextInt(66));
				}
			}
			//Orange
			if (cherry1 != null)
			{
				if (head.equals(cherry1))
				{
					score += 50;
					tailLength+= 5;
					cherry1.setLocation(random.nextInt(79), random.nextInt(66));
				}
			}
			// magenta
			if (cherry2 != null)
			{
				if (head.equals(cherry2))
				{;
					score += 100;
					tailLength+= 10;
					cherry2.setLocation(random.nextInt(79), random.nextInt(66));
				}
			}
		}
	}

					public boolean noTailAt(int x, int y)
	{
		for (Point point : snakeParts)
		{
			if (point.equals(new Point(x, y)))
			{
				return false;
			}
		}
		return true;
	}

					public static void main(String[] args)
	{
		snake = new Snake();
	}

	@Override
	public void keyPressed(KeyEvent e)
	{
		int i = e.getKeyCode();
		
	switch (i) {	
		case KeyEvent.VK_LEFT:{
			if(direction != RIGHT)
				direction = LEFT;
			break;
		}
		case KeyEvent.VK_A:{
			if(direction != RIGHT)
				direction = LEFT;
			break;
		}
		case 'D':{
			if(direction != LEFT)
				direction = RIGHT;
			break;
		}
		case KeyEvent.VK_RIGHT:{
			if(direction != LEFT)
				direction = RIGHT;
			break;
		}
		case 'W':{
			if(direction != DOWN)
				direction = UP;
			break;
		}
		case KeyEvent.VK_UP:{
			if(direction != DOWN)
				direction = UP;
			break;
		}
		case 'S':{
			if(direction != UP)
				direction = DOWN;
			break;
		}
		case KeyEvent.VK_DOWN:{
			if(direction != UP)
				direction = DOWN;
			break;
		}
		case ' ':{
			if(over)
				startGame();
			else{
				paused = !paused;
			}
		}
	}
}

	@Override
	public void keyReleased(KeyEvent e)
	{
	}

	@Override
	public void keyTyped(KeyEvent e)
	{
	}

}