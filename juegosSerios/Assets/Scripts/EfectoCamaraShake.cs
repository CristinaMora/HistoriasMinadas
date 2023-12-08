using UnityEngine;

public class EfectoCamaraShake : MonoBehaviour
{
    private Vector3 posicionOriginal; // Posición original de la cámara
    private bool shaking = false; // Indicador de si la cámara está temblando
    private float duracionShake = 0.5f; // Duración del efecto de shake en segundos
    private float intensidadShake = 0.1f; // Intensidad del shake

    void Start()
    {
        
        posicionOriginal = transform.position; // Guardar la posición original de la cámara
    }

    void Update()
    {
        if (shaking)
        {
            // Sacudir la cámara
            transform.position = posicionOriginal + Random.insideUnitSphere * intensidadShake;

            // Reducir la duración restante
            duracionShake -= Time.deltaTime;

            // Detener el shake si la duración se ha agotado
            if (duracionShake <= 0f)
            {
                shaking = false;
                transform.position = posicionOriginal; // Restaurar la posición original
            }
        }
    }

    // Método para activar el efecto de shake
    public void ActivarShake()
    {
        if (!shaking)
        {
            shaking = true;
            duracionShake = 0.5f; // Puedes ajustar la duración según tus preferencias
        }
    }
}
