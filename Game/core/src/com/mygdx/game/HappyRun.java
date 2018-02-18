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
	//float floatX = Gdx.graphics.getWidth();
	float floatX = 2000;

	float floatY = 100;
	float Gravitiy = 2;
	float dudeY = 1;
	float velocity = 0;

	int spielStand = 0;


	@Override
	public void create () {
		batch = new SpriteBatch();
		background = new Texture("background.png");
		dude = new Texture[2];
		dude[0] = new Texture("dude1_1.png");
		dude[1] = new Texture("dude2_2.png");
		platform = new Texture("platform.png");
		dudeY = Gdx.graphics.getHeight() / 2 - dude[intAnimation].getHeight() / 2;


	}

	@Override
	public void render () {

		batch.begin();
		if (spielStand == 0){
			batch.draw(background, 0,0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
			spielStand++;
		} else {



			if (intAnimation == 0) {
				intAnimation = 1;
			} else {
				intAnimation = 0;
			}

			velocity++;
			dudeY -= velocity;

			batch.draw(dude[0], Gdx.graphics.getWidth() / 2 - dude[intAnimation].getWidth() / 2, dudeY);


			if (Gdx.input.isTouched()) {

				batch.draw(background, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
				batch.draw(dude[intAnimation], Gdx.graphics.getWidth() / 2 - dude[intAnimation].getWidth() / 2, dudeY);
				floatY += 10;

			}

			if (floatY > 400) {
				floatY = 100;
			}

			batch.draw(platform, floatX, 200);
			floatX -= 10;

			if (floatX <= platform.getWidth() - platform.getWidth() * 2) {
				floatX = 2000;
			}



		}
		batch.end();
	}

}
