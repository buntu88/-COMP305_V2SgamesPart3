/*
    Source File Name: GameController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Descreption: v8
*/

using UnityEngine;

public class RoadController2 : MonoBehaviour
{
    public GameController2 _gameController;
    // Use this for initialization
    void Start()
    {
       
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
