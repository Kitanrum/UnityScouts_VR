using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public static int CoinCount = 0; //Total # of Coins in Scene
    public static GameObject[] Coins; //List of coin objects

	// Use this for initialization
	void Start () {

        Coins = GameObject.FindGameObjectsWithTag("Coin"); //Look for any Coin in the scene
        CoinCount = Coins.Length; //Total # of coins = Number of Objects in Coins

	}
	
	// Update is called once per frame
	void Update () {
	    
       if(CoinCount <= 0) {

            Debug.Log("You Won!");

        }
	}
}
