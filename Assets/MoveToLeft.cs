using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public float LenghtOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    { 
        if(currentTimeToSpawn> 0)
        { 
            currentTimeToSpawn -= Time.deltaTime;
        }

        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }
    public void SpawnObject()
    {
        float LeftPoint = transform.position.x - LenghtOffset;
        float RightPoint = transform.position.x + LenghtOffset;
        Instantiate(objectToSpawn, new Vector3 (Random.Range(LeftPoint,RightPoint), transform.position.y, 0), transform.rotation);
    }
}

 