using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallMove : MonoBehaviour {

    public GameObject[] gameObjects;

    public static int AllScore;
    public int ThisScore;
    public Text textscore;
    // Use this for initialization
    private void Awake()
    {
        AllScore = 0;
    }
    void Start () {
        this.GetComponent<Rigidbody2D>().AddForce(-Vector2.up * 3);
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        textscore.text = "Score:" + ThisScore.ToString();
        if (ThisScore >= AllScore)
        {
            gameObjects[1].SetActive(true);
            Time.timeScale = 0;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ZK")
        {
            Destroy(collision.gameObject);
            ThisScore += 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BG")
        {
            gameObjects[0].SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RePlay()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
