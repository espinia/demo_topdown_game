using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		//se llama autmáticamente cuando otro objeto físico entra en el 
		//collider y trigger del objeto

		//revisamos las etiquetas
		if (other.CompareTag("Projectile"))
		{  
			//animal choca contra un proyectil
			//destruye el animal
			Destroy(gameObject);

			//destruye lo otro
			Destroy(other.gameObject);
		}
	}
}
