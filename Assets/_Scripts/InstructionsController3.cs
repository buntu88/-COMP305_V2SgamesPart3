using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InstructionsController3 : MonoBehaviour {

    public ScoreScript scoreScript;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void BackButtonClick()
    {
        SceneManager.LoadScene("Level3");
    }
}
