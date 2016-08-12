using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

    public Rigidbody ball;
    public Transform arm;
    public Transform player;

    public float throwDelay = 2f;
    public float nextThrow = 0f;

	// Use this for initialization
	void Start () {

        arm = transform.FindChild("Arm");
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Fire2")) {
            nextThrow = throwDelay;
            ThrowPB();
        }

        nextThrow -= Time.deltaTime;
	
	}

    void ThrowPB() {

        Rigidbody instance = (Rigidbody)Instantiate(ball, arm.transform.position, arm.transform.rotation);
        Vector3 fwd = arm.TransformDirection(Vector3.forward);

        instance.AddForce(fwd * 500);
    }
}
