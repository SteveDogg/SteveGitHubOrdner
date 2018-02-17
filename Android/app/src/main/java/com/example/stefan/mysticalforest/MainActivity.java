package com.example.stefan.mysticalforest;

import android.support.v7.app.ActionBar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    TextView txtStart;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ActionBar actionBar = getSupportActionBar();
        actionBar.hide();

        txtStart = (TextView)findViewById(R.id.txtStart);

        txtStart.setOnClickListener((View.OnClickListener) this);
        {

            txtStart.setText("fagot");

        }
    }
}
