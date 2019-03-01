using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GooseController : MonoBehaviour
{
    public Rigidbody2D gooseRB;
    public float jumpSpeed = 5;
    public GameObject gameOverCanvas;
    public Text scoreText;

    public int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("REEEEEE");
            gooseRB.velocity = new Vector2(gooseRB.velocity.x, jumpSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("uhhhh");
        gameOverCanvas.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }


}
