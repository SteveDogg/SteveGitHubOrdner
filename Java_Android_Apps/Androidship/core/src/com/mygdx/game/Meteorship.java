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
	Texture water_down;
	Texture water_up;

	//Dateitypen werden erstellt, aber noch nicht zugewiesen



	//Dateitypen werden erstellt und gleich zugewiesen

	int intKoordinateX; //Koordinaten des Fingers X
	int intKoordinateY; //Koordinaten des Fingers Y


	//OnCreate
	@Override
	public void create () {
		batch = new SpriteBatch();
		water_down = new Texture("water_down.png");
		water_up = new Texture("water_up.png");
	}

	@Override
	public void render () {

		batch.begin();
		MotionShip();
		batch.end();

	}

	public void MotionShip () {
		batch.draw(water_down, 0,0, 1960 , 150);
		batch.draw(water_up, 0, 140, 1960, 100);
	}

}
