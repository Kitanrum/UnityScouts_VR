using UnityEngine;
using System.Collections;

public class Animate : MonoBehaviour {

    public Animator anim;
    public bool escape = false;
    public GameObject me;
    public Capture _capture;
	// Use this for initialization

    void Awake () {
        
        anim = GetComponent<Animator>();
        _capture = GetComponent<Capture>();
    }

	void Start () {

        //anim.Play("Bla_Idle");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "PokeBall") {

            anim.SetBool("Hit", true);
            me = _capture.pokemon;
            me.GetComponentInChildren<Renderer>().enabled = false;

            /* if(escape == true) {

                 _capture.caught = false;
                 anim.SetBool("Hit", false);
                 anim.SetBool("Escape", true);
             }*/
        }

    }

}
