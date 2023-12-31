using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Granada : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 5f; // Velocidad de movimiento del personaje

    [SerializeField]
    private float rangoMovimientoX = 5f; // Rango m�ximo de movimiento en el eje X

    [SerializeField]
    private float amplitudY = 2f; // Amplitud del movimiento en el eje Y

    void Update()
    {
        // Mover el personaje hacia la izquierda (tecla A)
        if (Input.GetKey(KeyCode.A) && transform.position.x > -rangoMovimientoX)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Mover el personaje hacia la derecha (tecla D)
        if (Input.GetKey(KeyCode.D) && transform.position.x < rangoMovimientoX)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        // Mover el personaje hacia arriba y abajo con un movimiento oscilante
        float movimientoY = Mathf.Sin(Time.timeSinceLevelLoad * velocidad) * amplitudY;
        transform.position = new Vector3(transform.position.x, transform.position.y+movimientoY, transform.position.z);
    }
}
