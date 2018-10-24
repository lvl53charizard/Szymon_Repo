package entities.creatures;

import java.awt.Graphics;


import gfx.Assets;
import tile.Game;

public class Player extends Creature {

	private Game game;
	
	public Player(Game game, float x, float y) {
		super(x, y, Creature.DEFAULT_CREATURE_WIDTH, Creature.DEFAULT_CREATURE_HEIGHT);
		this.game = game;
		 
		
	}

	@Override
	public void tick() {
		getInput();
		move();
		
	}

	private void getInput() {
		xMove = 0;
		yMove = 0;
		
		if(game.getKeyManager().up) { 
			yMove = -speed;
				if(this.height - 30 > y) {
					yMove = 0;
				}
		}
		if(game.getKeyManager().down) {
			yMove = speed;
				if(this.height + 655 < y) {
					yMove = 0;
				}
		}
		if(game.getKeyManager().left) {
			xMove = -speed;
				if(this.width - 30 > x) {
					xMove = 0;
				}
		}
		if(game.getKeyManager().right) {
			xMove = speed;
				if(this.width + 1215 < x) {
					xMove = 0;
				}
		}
	}
	
	@Override
	public void render(Graphics g) {
		g.drawImage(Assets.player, (int) x, (int) y, width, height, null);
		
	}

}
