using UnityEngine;
using System.Collections;

public class SafeController2 : MonoBehaviour {

    public GameController2 _gameController;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        this._gameController._safe();

    }
}
