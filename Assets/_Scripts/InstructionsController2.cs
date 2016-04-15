using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InstructionsController2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void BackButtonClick()
    {
        SceneManager.LoadScene("Level2");
    }
}
