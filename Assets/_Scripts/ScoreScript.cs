using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    public int scoreValue = 0;
    public int livesValue = 5;

    public int ScoreValue
    {
        get
        {
            return this.scoreValue;
        }

        set
        {
            this.scoreValue = value;
        }
    }

    public int LivesValue
    {
        get
        {
            return this.livesValue;
        }

        set
        {
            this.livesValue = value;
            if (this.livesValue < 0)
            {
                this.livesValue = 0;
            }
        }
    }


    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().name == "Zero")
        {
            SceneManager.LoadScene("Menu");
        }

    }
    void Awake()
    {
        DontDestroyOnLoad(this);
    }


    // Update is called once per frame
    void Update () {
	
	}
}
