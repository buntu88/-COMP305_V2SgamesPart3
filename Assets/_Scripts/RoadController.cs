﻿/*
    Source File Name: GameController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 25th March 2016
    Program Descreption: v8
*/

using UnityEngine;

public class RoadController : MonoBehaviour
{
    public GameController _gameController;
    // Use this for initialization
    void Start()
    {
        //this._gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {

        this._gameController._endGame();
        Destroy(other.gameObject);

    }
}
