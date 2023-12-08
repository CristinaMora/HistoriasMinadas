using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform objetivo; // El personaje que la c�mara seguir�

    [SerializeField]
    private float suavidad = 5f; // Par�metro para ajustar la suavidad del movimiento

    [SerializeField]
    private Vector2 rangoMovimientoX = new Vector2(-5f, 5f); // Rango de movimiento en el eje X

    [SerializeField]
    private Vector2 rangoMovimientoY = new Vector2(-2f, 2f); // Rango de movimiento en el eje Y

    private EfectoCamaraShake efectoShake;

    void Start()
    {
        if (objetivo != null)
        {
            // Establecer la posici�n inicial de la c�mara centrada y el personaje en la parte inferior
            Vector3 posicionInicial = new Vector3(objetivo.position.x, rangoMovimientoY.x, transform.position.z);
            transform.position = posicionInicial;
        }

        // Obtener la referencia al script de efecto de shake
        efectoShake = GetComponent<EfectoCamaraShake>();
    }

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Obtener la posici�n actual de la c�mara
            Vector3 posicionActual = transform.position;

            // Obtener la posici�n objetivo del personaje con restricciones en los ejes
            float posX = Mathf.Clamp(objetivo.position.x, rangoMovimientoX.x, rangoMovimientoX.y);
            float posY = Mathf.Clamp(objetivo.position.y, rangoMovimientoY.x, rangoMovimientoY.y);
            Vector3 posicionObjetivo = new Vector3(posX, posY, posicionActual.z);

            // Suavizar el movimiento utilizando Lerp
            Vector3 nuevaPosicion = Vector3.Lerp(posicionActual, posicionObjetivo, suavidad * Time.deltaTime);

            // Establecer la nueva posici�n de la c�mara
            transform.position = nuevaPosicion;
        }
    }

    // M�todo para activar el efecto de shake desde otros scripts
    public void ActivarShake()
    {
        efectoShake.ActivarShake();
    }
}
