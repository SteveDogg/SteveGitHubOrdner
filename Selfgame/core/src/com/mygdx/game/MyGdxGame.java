package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class MyGdxGame extends ApplicationAdapter {
	SpriteBatch batch;
	Texture Hintergrund;
	Texture[] Mann;
	Texture trans;

	int LaufAnimation = 0;

	@Override
	public void create () {
		batch = new SpriteBatch();
		Hintergrund = new Texture("hintergrundgras.png");
		Mann = new Texture[5];
		Mann[0] = new Texture("mannstehend.png");
		Mann[1] = new Texture("mannrechts1.png");
		Mann[2] = new Texture("mannrechts2_1.png");
		Mann[3] = new Texture("mannlinks1.png");
		Mann[4] = new Texture("mannlins2.png");
		trans = new Texture("transparent.png");



	}

	@Override
	public void render () {

		batch.begin();

		batch.draw(Hintergrund, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());

		batch.draw(Mann[LaufAnimation], Gdx.graphics.getWidth() /2  - Mann[0].getWidth() /2 , 50);
		batch.draw(trans, 0, 0);

		if(Gdx.input.isTouched()){

			int KoordinateX = Gdx.input.getX();
			int KoordinateY = Gdx.input.getY();

			System.out.println("X = " + Gdx.input.getX() +  "  Y = " + Gdx.input.getY());

			if(KoordinateX < 600 && KoordinateY > 500)
			{
				if (LaufAnimation != 3)
				{
					LaufAnimation = 3;
				}else if (LaufAnimation != 4)
				{
					LaufAnimation = 4;
				}

				float laufer = 850;

				laufer += 50;

				batch.draw(Hintergrund, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());

				batch.draw(Mann[LaufAnimation], laufer, 300);

			} else if (KoordinateX < 1100 && KoordinateX > 600){
				batch.draw(Hintergrund, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());

				batch.draw(Mann[LaufAnimation], Gdx.graphics.getWidth() /2  - Mann[0].getWidth() /2 , 500);
			} else if (KoordinateX > 1100) {
				batch.draw(Hintergrund, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());

				batch.draw(Mann[LaufAnimation], Gdx.graphics.getWidth() /2  - Mann[0].getWidth() /2 , 50);
			}
		}

		batch.end();

	}

}
