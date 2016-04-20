/*
    Source File Name: GameController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Descreption: v8
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;
    public ScoreScript scoreScript;

    [SerializeField]
    private AudioSource _gameOverSound;
    private bool isActive;

    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue < 1)
            {
                this._endGame();
                this._livesValue = 0;
            }
            else
            {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }
    }

    // PUBLIC INSTANCE VARIABLES
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public Button RestartButton;
    public GameObject player;
    public new GameObject camera;

    // Use this for initialization
    void Start()
    {
        this._initialize();
        //Instantiate(this.player, this._playerSpawnPoint, Quaternion.Euler(0, 167, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            scoreScript.scoreValue = this._scoreValue;
            scoreScript.livesValue = this._livesValue;
            SceneManager.LoadScene("Instructions2");
        }
            
        if (Input.GetKey(KeyCode.T))
        {
            scoreScript.scoreValue = this._scoreValue;
            scoreScript.livesValue = this._livesValue;
            SceneManager.LoadScene("Instructions3");
        }
    }

    //PRIVATE METHODS ++++++++++++++++++

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = scoreScript.scoreValue;
        this.LivesValue = scoreScript.livesValue;
        this.GameOverLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
        this.camera.gameObject.SetActive(false);
        

    }

    //End Game Method
    public void _endGame()
    {

        scoreScript.scoreValue = this._scoreValue;
        scoreScript.livesValue = this._livesValue;
        if (LivesValue > 0)
        {
            this.ScoreValue += 500;
            scoreScript.scoreValue = this._scoreValue;
            SceneManager.LoadScene("Instructions2");

        }
        else
        {
            this.GameOverLabel.text = "Game Over!!!";

        }

        this.HighScoreLabel.text = "High Score: " + this._scoreValue;

        this.camera.gameObject.SetActive(true);
        this.GameOverLabel.gameObject.SetActive(true);
        this.HighScoreLabel.gameObject.SetActive(true);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.player.gameObject.SetActive(false);
        this._gameOverSound.Play();
        this.RestartButton.gameObject.SetActive(true);
        this.isActive = true;
    }

    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
