using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

///<summary>Creating Player.</summary>
public class PlayerController : MonoBehaviour
{
    
    public float speed = 4000f;
    public Rigidbody move;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    private int score = 0;
    
    
    ///<summary>Initializing game</summary>
    void Start()
    {
        move = GetComponent<Rigidbody> ();
    }

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            move.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            move.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            move.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            move.AddForce(0, 0, -speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            score += 1;
            SetScoreText();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Trap")
        {
            health -= 1;
            SetHealthText();
        }
        if (other.gameObject.tag == "Goal")
        {
            health -= 1;
            Debug.Log("You win!");
        }
    }
    void SetScoreText()
    {
        scoreText.text = string.Format("Score: {0}", score);
    }
    void SetHealthText()
    {
        healthText.text = string.Format("Health: {0}", health);
    }
}
