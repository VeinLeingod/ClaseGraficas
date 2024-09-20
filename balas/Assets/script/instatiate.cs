using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiate : MonoBehaviour
{
	public GameObject sphere; // Asegúrate de asignar la esfera en el Inspector
	public bool wacarear = true; // Controla si puedes instanciar
	public float cooldownTime = 2f; // Tiempo de cooldown

	// Update is called once per frame
	void Update()
	{
		if (wacarear)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				StartCoroutine(diezbalas());
			}
		}
	}

	IEnumerator diezbalas()
	{
		wacarear = false; // Desactiva el instanciamiento al iniciar la corutina

		for (int i = 0; i < 10; i++)
		{
			Instantiate(sphere, transform.position+new Vector3(0,0,1), Quaternion.identity);
			yield return new WaitForSeconds(0.5f); // Espera entre instancias
		}

		yield return new WaitForSeconds(cooldownTime); // Espera el tiempo de cooldown

		wacarear = true; // Reactiva el instanciamiento
	}
}
