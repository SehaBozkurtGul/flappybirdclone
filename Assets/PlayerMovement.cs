using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D PlaneRb;
    public float Wind;
    public Sprite goingup,goingdown;
    public Logic logic;
    public bool playerAlive = true;
  
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
       
               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && playerAlive)
        {
            PlaneRb.velocity = Vector2.up * Wind;
        }
        if (PlaneRb.velocity.y > -1)
        {
            GetComponent<SpriteRenderer>().sprite = goingup;
        }
        else 
        {
            GetComponent<SpriteRenderer>().sprite = goingdown;
        }
       // Debug.Log()
       if (PlaneRb.position.y > 5 || PlaneRb.position.y < -5)
        {
            logic.GameOver("ahsoka");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MiniPlane"))
        {
            logic.GameOver("miniplane");
            Debug.Log("mini plane death");
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            logic.GameOver("tree");
            Debug.Log("tree death");
        }

    }
 
}

