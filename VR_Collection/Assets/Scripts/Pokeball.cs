using UnityEngine;
using System.Collections;

public class Pokeball : MonoBehaviour {

    float lifetime = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "Easy" || other.gameObject.tag == "Medium" || other.gameObject.tag == "Hard") {

            Destroy(gameObject);
        }
        else {
            Destroy(gameObject, lifetime);
        }
    }
}
