package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

///
///Stefan Simic
///Meteorship
///23.02.2018
///Version 1.0
///

public class Meteorship extends ApplicationAdapter {
	SpriteBatch batch;
	Texture img;

	//Dateitypen werden erstellt, aber noch nicht zugewiesen



	//Dateitypen werden erstellt und gleich zugewiesen

	int intKoordinateX; //Koordinaten des Fingers X
	int intKoordinateY; //Koordinaten des Fingers Y


	//OnCreate
	@Override
	public void create () {
		batch = new SpriteBatch();
		img = new Texture("badlogic.jpg");
	}

	@Override
	public void render () {

		batch.begin();
		MotionShip();
		batch.end();

	}

	public void MotionShip () {
		batch.draw(img, 0,0);
	}

}
