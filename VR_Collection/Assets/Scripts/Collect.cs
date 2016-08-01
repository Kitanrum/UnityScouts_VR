using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {

        Debug.Log("Entered Object");

        if(other.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
