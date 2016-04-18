/*
    Source File Name: GameController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Descreption: v8
*/

using UnityEngine;

public class RoadController3 : MonoBehaviour
{
    public GameController3 _gameController;
    // Use this for initialization
    void Start()
    {
        //this._gameController = GameObject.FindGameObjectWithTag("GameController3").GetComponent("GameController3") as GameController3;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {

        _gameController._endGame();
        Destroy(other.gameObject);

    }
}
