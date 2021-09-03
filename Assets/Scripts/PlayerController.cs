using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

///<summary>Creating Player.</summary>
public class PlayerController : MonoBehaviour
{
    
    public float speed = 4000f;
    public Rigidbody move;
    
    ///<summary>Initializing game</summary>
    void Start()
    {
        move = GetComponent<Rigidbody> ();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            move.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            move.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            move.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            move.AddForce(0, 0, -speed * Time.deltaTime);
        }

    }
}
