package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class SadlyRun extends ApplicationAdapter {
	SpriteBatch batch;
	Texture Whute;

	int gameStart = 0;
	
	@Override
	public void create () {
		batch = new SpriteBatch();
		Whute = new Texture("whute.png");
	}

	@Override
	public void render () {
		batch.begin();
		if(gameStart == 0) {
			batch.draw(Whute, 0, 0,1080 , 1920);
			gameStart++;
		} else{

			if (Gdx.input.isTouched()){
				System.out.println(Gdx.input.getX() + "   " + Gdx.input.getY());
			}


		}
		batch.end();
	}
}
