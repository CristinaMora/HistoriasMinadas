using UnityEngine;

public class EfectoCamaraShake : MonoBehaviour
{
    private Vector3 posicionOriginal; // Posici�n original de la c�mara
    private bool shaking = false; // Indicador de si la c�mara est� temblando
    private float duracionShake = 0.5f; // Duraci�n del efecto de shake en segundos
    private float intensidadShake = 0.1f; // Intensidad del shake

    void Start()
    {
        
        posicionOriginal = transform.position; // Guardar la posici�n original de la c�mara
    }

    void Update()
    {
        if (shaking)
        {
            // Sacudir la c�mara
            transform.position = posicionOriginal + Random.insideUnitSphere * intensidadShake;

            // Reducir la duraci�n restante
            duracionShake -= Time.deltaTime;

            // Detener el shake si la duraci�n se ha agotado
            if (duracionShake <= 0f)
            {
                shaking = false;
                transform.position = posicionOriginal; // Restaurar la posici�n original
            }
        }
    }

    // M�todo para activar el efecto de shake
    public void ActivarShake()
    {
        if (!shaking)
        {
            shaking = true;
            duracionShake = 0.5f; // Puedes ajustar la duraci�n seg�n tus preferencias
        }
    }
}
