using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
    Vector2 direction;

	// Use this for initialization
	void Start () 
    {
        
	}

    public float speed = 20f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("d"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
