/*
    Source File Name: GroundController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Description: v8
*/
using UnityEngine;
public class GroundController2 : MonoBehaviour
{

    public GameController2 _gameController;

    private Vector3 _playerSpawnPoint;
    // Use this for initialization
    void Start()
    {
this._playerSpawnPoint = new Vector3(-2055.4f, -88.4f, -88.4f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {    
        

        Transform playerTransform = other.gameObject.GetComponent<Transform>();
        playerTransform.position = this._playerSpawnPoint;
        //playerTransform.Rotate(0, 167, 0);
        this._gameController.LivesValue--;


    }
}
