using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public Sprite[] sprites;
	// Use this for initialization
	void Start () {
        int temp = Random.Range(0, 2);
        if (temp == 1)
        {
            this.gameObject.SetActive(true);
            BallMove.AllScore += 1;
            this.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
        }
        else
        {
            this.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
