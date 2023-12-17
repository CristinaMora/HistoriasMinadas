using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedras_Granada : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 5f; // Velocidad de movimiento de las piedras hacia abajo
   
    private void Update()
    {
        // Mover las piedras hacia abajo en el eje Y
        //  transform.Translate(Vector3.down * velocidad * Time.deltaTime);
      //  Debug.Log("fun");
        // Comprobar colisión con el personaje utilizando duck typing
        if (transform.position.y < -50)
        {
            Debug.Log("yeee");
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement_Granada>())
        {
            Generador_Piedras.instance.Collision();
            Debug.Log("Collision");
        }
        else
        {
            Debug.Log("mal");
        }
    }
}
