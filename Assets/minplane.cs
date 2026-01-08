using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minplane : MonoBehaviour
{

    public float speed;
    public float deadZone = -15;


    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);

        }


    }
}
