/*
    Source File Name: PlayerShooting
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 15th April 2016
    Program Descreption: v8
*/

using UnityEngine;

public class PlayerShooting3 : MonoBehaviour
{

    //PUBLIC MEMBER VARIABLES
    public Transform flashPoint1;
    public Transform flashPoint2;
    public GameObject muzzleFlash;
    public GameObject metalbulletImpact;
    public GameObject stonebulletImpact;
    public GameObject explosion;
    public GameController3 _gameController;



    // PRIVATE INSTANCE VARIABLES
    private Transform _transform;


    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();

        //this._gameController = GameObject.FindGameObjectWithTag("GameController3").GetComponent("GameController3") as GameController3;

    } // end Start

    // Update is called once per frame
    void Update()
    {

    } // end Update


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TankExplosion"))
        {
            this._gameController.LivesValue--;
        }


    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(this.muzzleFlash, flashPoint1.position, Quaternion.identity);
            Instantiate(this.muzzleFlash, flashPoint2.position, Quaternion.identity);

            RaycastHit hit; // stores information from the Ray;

            if (Physics.Raycast(this._transform.position, this._transform.forward, out hit, 10000f))
            {

                if (hit.transform.gameObject.CompareTag("Ground"))
                {
                    Instantiate(this.stonebulletImpact, hit.point, Quaternion.identity);
                    //this._gameController.ScoreValue += 100;
                }
                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    Instantiate(this.explosion, hit.point, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    this._gameController.ScoreValue += 100;
                }


            }


        } // end if
    } // end FixedUpdate




}
