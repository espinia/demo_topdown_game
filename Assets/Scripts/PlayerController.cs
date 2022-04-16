using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;

    public float xRange = 15.0f;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento del personaje
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if(transform.position.x<-xRange)
		{
            //impedir salir a izquierda
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
        else if (transform.position.x > xRange)
        {
            //impedir salir a derecha
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //acciones

        if(Input.GetKeyDown(KeyCode.Space))
		{
            //lanzar proyectil
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
    }
}
