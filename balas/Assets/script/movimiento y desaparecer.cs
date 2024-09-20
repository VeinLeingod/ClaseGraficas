using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoydesaparecer : MonoBehaviour
{
	public float speed = 5f; // Velocidad de movimiento
	private float timer = 3f; // Tiempo antes de desaparecer

	void Start()
	{
		// Inicia la corutina que controla el movimiento y desaparición
		StartCoroutine(MoveAndDestroy());
	}
	private void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	private IEnumerator MoveAndDestroy()
	{
		//while (timer > 0)
		
			// Mueve la esfera hacia adelante
			
			//timer -= Time.deltaTime;

			yield return new WaitForSeconds(timer); // Espera el siguiente frame
		
	
		// Destruye el objeto
		Destroy(gameObject);
	}
}