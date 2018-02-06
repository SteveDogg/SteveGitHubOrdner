package com.example.stefan.funktionentest;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public class Mensch {

        String name;
        int groesse;
        String Geschlecht;
        int Alter;

        public Mensch( String name, int groesse, String geschlecht, int Alter) {
            this.name = name;
            this.groesse = groesse;
            this.Geschlecht = Geschlecht;
            this.Alter = Alter;

        }

        public String toString() {
            return String.format("Name: %s\nGrösse: %sGeschlecht: %s\nGeschlecht: %s\nAlter: %s", name, groesse, Geschlecht, Alter);
        }
    }
}
