using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour
{
    public Image barraImagen; // Referencia a la imagen de la barra de progreso
    public float duracionTotal = 10f; // Duración total de la barra de progreso en segundos

    private float tiempoActual = 0f; // Tiempo actual transcurrido

    void Update()
    {
        if (tiempoActual < duracionTotal)
        {
            // Incrementar el tiempo actual
            tiempoActual += Time.deltaTime;

            // Calcular el porcentaje completado
            float porcentajeCompletado = tiempoActual / duracionTotal;

            // Actualizar la barra de progreso
            ActualizarBarraProgreso(porcentajeCompletado);
        }
        else
        {
            // Aquí puedes realizar alguna acción cuando la barra de progreso alcanza el 100%
            Debug.Log("Barra de progreso completada");
        }
    }

    void ActualizarBarraProgreso(float porcentaje)
    {
        // Asegurarse de que la referencia a la imagen de la barra esté configurada
        if (barraImagen != null)
        {
            Debug.Log(porcentaje);  
            // Ajustar el valor de llenado de la barra de progreso
            barraImagen.fillAmount = porcentaje;
        }
    }
}
