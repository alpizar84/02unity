using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{

    private float topBound = 30f;

    private float lowerBound = -7f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!!!!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        
    }
    
}
