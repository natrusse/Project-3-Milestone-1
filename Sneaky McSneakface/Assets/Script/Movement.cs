using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public int maxspeed;
    public int rotspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //forward with up arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * maxspeed * Time.deltaTime);
        }
        //backward with down arrow
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * maxspeed * Time.deltaTime);
        }
        //left rotation with left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed * 2);
        }
        //right rotation with right arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotspeed * 2);
        }
    }
}
