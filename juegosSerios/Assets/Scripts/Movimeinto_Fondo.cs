using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimeinto_Fondo : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 2f; // Velocidad de movimiento del fondo

    [SerializeField]
    private float resetPosition = -10f; // Posici�n para reiniciar el fondo

    void Update()
    {
        // Mover el fondo hacia abajo
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);

        // Reiniciar la posici�n del fondo cuando llega a cierta posici�n
        if (transform.position.y < resetPosition)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Calcular la nueva posici�n del fondo arriba
        Vector2 nuevaPosicion = new Vector2(0, resetPosition + GetComponent<SpriteRenderer>().bounds.size.y * 2);

        // Establecer la nueva posici�n del fondo
        transform.position = nuevaPosicion;
    }
}
