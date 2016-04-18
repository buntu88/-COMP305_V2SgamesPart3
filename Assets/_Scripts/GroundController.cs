/*
    Source File Name: GroundController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Description: v8
*/
using UnityEngine;
public class GroundController : MonoBehaviour
{

    public GameController _gameController;

    private Vector3 _playerSpawnPoint;
    // Use this for initialization
    void Start()
    {
        //this._gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
        this._playerSpawnPoint = new Vector3(515.26f, 0f, 64.63f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        this._gameController.LivesValue--;
        Transform playerTransform = other.gameObject.GetComponent<Transform>();
        playerTransform.position = this._playerSpawnPoint;
        //playerTransform.Rotate(0, 177, 0);
        


    }
}
