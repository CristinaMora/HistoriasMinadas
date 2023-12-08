using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimeinto_Fondo : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 2f; // Velocidad de movimiento del fondo

    [SerializeField]
    private float resetPosition = -10f; // Posición para reiniciar el fondo

    void Update()
    {
        // Mover el fondo hacia abajo
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);

        // Reiniciar la posición del fondo cuando llega a cierta posición
        if (transform.position.y < resetPosition)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Calcular la nueva posición del fondo arriba
        Vector2 nuevaPosicion = new Vector2(0, resetPosition + GetComponent<SpriteRenderer>().bounds.size.y * 2);

        // Establecer la nueva posición del fondo
        transform.position = nuevaPosicion;
    }
}
