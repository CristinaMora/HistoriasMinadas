using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedras_Granada : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 5f; // Velocidad de movimiento de las piedras

    private void Update()
    {
        // Mover las piedras en diagonal
        transform.Translate(new Vector3(-1f, -1f, 0f) * velocidad * Time.deltaTime);

        // Comprobar colisión con el personaje utilizando duck typing
        if (transform.position.y < -50)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement_Granada>())
        {
            Generador_Piedras.instance.Collision();
           // Debug.Log("Collision");
        }
        else
        {
            Debug.Log("mal");
        }
    }
}
