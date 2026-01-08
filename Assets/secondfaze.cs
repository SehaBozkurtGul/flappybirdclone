using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class seondfaze : MonoBehaviour
{
    private float speed=5;
    private int distance;
    public Text scoreText;
    public Camera camera1;


    // Start is called before the first frame update
    void Start()
    {
        camera1.backgroundColor = new Color32(0x27, 0x78, 0x3A, 0xFF);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
      
        distance = (int) -transform.position.x;
        Distance();
        addScore();
        
    }
    void Distance()
    {

       

    }

    public void addScore()
    {
        scoreText.text = distance.ToString();
    }

   


}
