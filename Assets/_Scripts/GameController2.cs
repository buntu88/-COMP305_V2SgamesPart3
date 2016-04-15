/*
    Source File Name: GameController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 25th March 2016
    Program Descreption: v8
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController2 : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;
    public ScoreScript scoreScript;
    public GameObject prefab;
    private int x;
    private int y;

    [SerializeField]
    private AudioSource _gameOverSound;

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
                
                this._livesValue = 0;
                this._endGame();
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
    public Text WarningLabel;
    public Button RestartButton;
    public GameObject player;
    public new GameObject camera;

    // Use this for initialization
    void Start()
    {
        this._initialize();
        //Instantiate(this.player, this._playerSpawnPoint, Quaternion.Euler(0, 167, 0));
        //Vector3 position = new Vector3(Random.Range(-1000.0F, 1000F), Random.Range(0f, 400f), Random.Range(-500F, 1500F));
        //Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(0, 50);
        y = Random.Range(0, 50);
        if (x == y)
        {
            // Vector3 position = new Vector3(Random.Range(-1000.0F, 1000F), Random.Range(0f, 400f), Random.Range(-500F, 1500F));
            Vector3 position = new Vector3(Random.Range(this.player.transform.position.x, this.player.transform.position.x + 200F),
                                            Random.Range(this.player.transform.position.y - 30f, this.player.transform.position.y + 30F), 
                                            Random.Range(this.player.transform.position.z - 30f, this.player.transform.position.z + 30F));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    //PRIVATE METHODS ++++++++++++++++++

    //Initial Method
    private void _initialize()
    {
      //  this._playerSpawnPoint = new Vector3(482f, 67.5f, 2434f);

        this.ScoreValue = scoreScript.scoreValue;
        this.LivesValue = scoreScript.livesValue;
        this.GameOverLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
        this.camera.gameObject.SetActive(false);
        this.WarningLabel.gameObject.SetActive(false);
        //this.player.gameObject.SetActive(true);

    }

    //End Game Method
    public void _endGame()
    {
        scoreScript.scoreValue = this._scoreValue;
        scoreScript.livesValue = this._livesValue;
        if (LivesValue > 0)
        {
            this.ScoreValue += 500;
            //this.GameOverLabel.text = "You Win!!!";
            SceneManager.LoadScene("Instructions3");

        }
        else
        {
            this.GameOverLabel.text = "Game Over!!!";
            this.HighScoreLabel.text = "High Score: " + this._scoreValue;

            this.camera.gameObject.SetActive(true);
            this.GameOverLabel.gameObject.SetActive(true);
            this.HighScoreLabel.gameObject.SetActive(true);
            this.LivesLabel.gameObject.SetActive(false);
            this.ScoreLabel.gameObject.SetActive(false);

            this._gameOverSound.Play();
            this.RestartButton.gameObject.SetActive(true);
        }



    }

    // PUBLIC METHODS

        public void _warning()
    {
        this.WarningLabel.gameObject.SetActive(true);
    }

    public void _safe()
    {
        this.WarningLabel.gameObject.SetActive(false);
    }

    public void RestartButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
