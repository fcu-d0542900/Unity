using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject arrow;
    public GameObject ball;

	// Use this for initialization
	void Start () {
        arrow = GameObject.Find("arrow");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
            arrow.transform.Rotate(0, 2, 0);
        if (Input.GetKey("right"))
            arrow.transform.Rotate(0, -2, 0);

        if (Input.GetKeyDown("space"))
        {
            GameObject copyball = Instantiate(ball);
            copyball.GetComponent<Rigidbody>().AddForce(arrow.transform.forward*12, ForceMode.Impulse);
        }
    }
}
