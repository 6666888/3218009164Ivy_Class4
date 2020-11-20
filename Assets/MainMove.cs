using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMove : MonoBehaviour {

    public int Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * Speed);
        }
    }
}
