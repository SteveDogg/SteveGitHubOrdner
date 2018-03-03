package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

import java.util.Random;

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
	Texture[] Flag;
	Texture ship;
	Texture Holder;
	Texture[] Meteor;

	//Dateitypen werden erstellt, aber noch nicht zugewiesen


	//Dateitypen werden erstellt und gleich zugewiesen

	int intKoordinateX; //Koordinaten des Fingers X
	int intKoordinateY; //Koordinaten des Fingers Y

	int intKoordinateYHelper;

	int floatX = 0;

	int GameStart = 0;

	int intBeweg = 0;

	int intMotion = 0;

	float intShipMotionX = 350;
	float intShipMotionY = 145;

	boolean Abfrager = false;

	int intUpCounter = 0;

	int Arrayer = 0;

	float y;
	float yspeed;

	int xFall;
	int yFall;

	//OnCreate
	@Override
	public void create() {
		batch = new SpriteBatch();
		water_down = new Texture("white.png");
		water_up = new Texture("water_up.png");
		Flag = new Texture[3];
		Flag[0] = new Texture("viking_ship_flag.png");
		Flag[1] = new Texture("viking_ship_flag1.png");
		Flag[2] = new Texture("viking_ship_flag2.png");
		Holder =  new Texture("viking_ship_flagholder.png");
		ship = new Texture("viking_ship_1col_cut.png");
		Meteor = new Texture[50];
	}

	@Override
	public void render() {

		batch.begin();

		if (GameStart == 0) {
			batch.draw(water_down, 0, 0, 1920, 1080);
			GameStart++;
		}

		MotionShipMovement();

		MotionShip();
		MeteorRain();
		getTheTouch();

		batch.end();

	}

	public void MotionShip() {

		batch.draw(water_down, 0, 0, 1920, 1080);
		batch.draw(water_up, 0, 20, 1920, 200);
		batch.draw(ship, intShipMotionX, intShipMotionY, 800, 300);
		batch.draw(Flag[Arrayer], intShipMotionX + 320, intShipMotionY + 135);
		batch.draw(Holder, intShipMotionX + 440, intShipMotionY + 112);
		//batch.draw(Flag[intBeweg], 750, 300);
		batch.draw(water_up, floatX, 0, 1920, 200);
		batch.draw(water_up, floatX - 1920, 0, 1920, 200);

		if (floatX < 1910) {
			floatX = floatX + 10;

		} else {
			floatX = 0;
		}
	}
	public void MotionShipMovement(){

		//The Ship moves naturally up and down, in a 20 frames interval, each time by 5 pixels

		if(intUpCounter < 20){
			if(Abfrager == false)
				{
					intShipMotionY = intShipMotionY - 5;
				}
			Abfrager = true;
			intUpCounter++;
		}else if(intUpCounter < 40){
			if(Abfrager == true)
				{
					intShipMotionY = intShipMotionY + 5;
				}
			Abfrager = false;
			intUpCounter++;
		}else {
			intUpCounter = 0;
		}

		//The Ship moves naturally from left to right and from right to left. each time they cross a distance of 300 pixels from one side to another.

		if(intMotion < 150){
			intShipMotionX = intShipMotionX + 2;
			Arrayer = 2;
			intMotion++;
			if(intMotion == 150){
				intMotion = 300;
			}
		}else if(intMotion > 150){
			intShipMotionX = intShipMotionX - 2;
			Arrayer = 1;
			intMotion--;
		}else {
			intMotion = 0;
		}

	}

	public void getTheTouch() {
		if (Gdx.input.isTouched()) {
			intKoordinateX = Gdx.input.getX();

			if(Gdx.input.getY() > 540){
				intKoordinateYHelper = Gdx.input.getY() - 540;
				intKoordinateY = 540 - intKoordinateYHelper;
			} else {
				intKoordinateYHelper = 540 - Gdx.input.getY();
				intKoordinateY = intKoordinateYHelper + 540;
			}

			System.out.println(intKoordinateY + "= Y und GDX = " + Gdx.input.getY());

			if(intKoordinateX > 980){
				intShipMotionX = intShipMotionX + 6;

			}else{

				intShipMotionX = intShipMotionX - 6;
			}

			/*
			intMotion =
			*/
		}

	}
	public void MeteorRain(){
		for (int i = 0; i < Meteor.length; i++) {
			Meteor[i] = new Texture("meteor.png");
		}
		for (int n = 0; n < Meteor.length; n++) {

			randomNumberGetting();
			batch.draw(Meteor[n], xFall, yFall, 40, 40);
		}
	}
	/*
	void fall(){
		y = y + yspeed;
		float gravity = 3;
		yspeed = yspeed + gravity;

		if(y > Gdx.graphics.getHeight()){
			y = 150;
		}
	}
	*/
	void randomNumberGetting(){
		Random x = new Random();
		xFall = x.nextInt(400);
		Random yx = new Random();
		yFall = yx.nextInt(400);
	}
}