using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float inputHorizontal;

    public float speed = 10f;
    // Start is called before the first frame update

    public float xRange = 15f;

    public GameObject projectilPrefab;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * inputHorizontal);

        if (transform.position.x < -xRange)
        {
            // Posición de la izquierda
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xRange)
        {
            // Posición de la derecha
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        
        //Acciones

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }

    }
}
