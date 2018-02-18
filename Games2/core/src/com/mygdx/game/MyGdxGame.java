package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class MyGdxGame extends ApplicationAdapter {
	SpriteBatch batch;
	Texture black;
	Texture hinter;

	int gameStart =0;
	
	@Override
	public void create () {
		batch = new SpriteBatch();
		black = new Texture("black.png");
		hinter = new Texture("hintergrundgras.png");



	}

	@Override
	public void render () {
		batch.begin();


		if(gameStart == 0) {
			batch.draw(hinter, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
			gameStart++;
		} else {
			if (Gdx.input.isTouched()) {


				batch.draw(black, Gdx.input.getX(), Gdx.input.getY());
				System.out.println(Gdx.input.getX() + "  " + Gdx.input.getY());

			}
		}
		batch.end();
	}

}
