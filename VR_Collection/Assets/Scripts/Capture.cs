using UnityEngine;
using System.Collections;

public class Capture : MonoBehaviour {

    public static GameObject easy;
    public static GameObject med;
    public static GameObject hard;
    public GameObject pokemon;
    public float[] rate = new float[Random.Range(0,100)];
    public bool caught;

	// Use this for initialization
	void Start () {
        pokemon = this.gameObject;
        CheckDifficulty(pokemon);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CheckDifficulty(GameObject me) {

        if(me.gameObject.tag == "Easy") {
            //85%
            me = easy;
            easy = GameObject.FindGameObjectWithTag("Easy");
            float crate = rate[Random.Range(0, rate.Length)];
            EasyRate(crate);
        }

        else if(me.gameObject.tag == "Medium") {
            //75%
            me = med;
            float crate = rate[Random.Range(0, rate.Length)];
            MedRate(crate);
        }

        else if(me.gameObject.tag == "Hard") {
            //55%
            me = hard;
            hard = GameObject.FindGameObjectWithTag("Hard");
            float crate = rate[Random.Range(0,rate.Length)];
            HardRate(crate);
        }
    }

    void EasyRate(float check) {
        if (check >= 15)
            caught = true;
        else
            caught = false;        
    }

    void MedRate(float check)
    {
        if (check >= 25)
            caught = true;
        else
            caught = false;
    }

    void HardRate(float check)
    {
        if (check >= 45)
            caught = true;
        else
            caught = false;
    }

    

}
