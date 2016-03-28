﻿using UnityEngine;
using System.Collections;

public class ScorePowerup : Powerup {
    
    //new used to call super class
    new void Start()
    {
        base.Start();
    }

    //overrides abstract method in parent
    public override void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            //destroys current gameObject during collision with player
            Destroy(gameObject);
            player.scorePowerUp(100);

            //sets array element in PowerUpSpawn to be false
            power.makeFalse(position);
        }
    }

}