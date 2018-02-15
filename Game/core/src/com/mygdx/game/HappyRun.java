package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

import static javax.swing.text.StyleConstants.Background;

public class HappyRun extends ApplicationAdapter {
	SpriteBatch batch;
	Texture img;
	Texture platform;
	Texture[] dude;
	Texture background;

	int intAnimation =0;



	@Override
	public void create () {
		batch = new SpriteBatch();
		background = new Texture("background.png");
		dude = new Texture[2];
		dude[0] = new Texture("dude1_1.png");
		dude[1] = new Texture("dude2_2.png");
		platform = new Texture("platform.png");
	}

	@Override
	public void render () {

		batch.begin();

		batch.draw(background, 0,0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());

		if (intAnimation == 0)
		{
			intAnimation = 1;
		}else
		{
			intAnimation = 0;
		}

		batch.draw(dude[intAnimation], Gdx.graphics.getWidth() / 2 - dude[intAnimation].getWidth() /2, 2);


		if (Gdx.input.isTouched()) {

			batch.draw(background, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
			batch.draw(dude[intAnimation], Gdx.graphics.getWidth() / 2 - dude[intAnimation].getWidth() / 2, 200);

		}

		batch.draw(platform, Gdx.graphics.getWidth() / 2 - dude[intAnimation].getWidth() / 2, 200);

		batch.end();
	}

}
