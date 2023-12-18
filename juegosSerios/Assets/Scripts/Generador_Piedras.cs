using System.Collections;
using UnityEngine;

public class Generador_Piedras : MonoBehaviour
{
    public static Generador_Piedras instance;

    [SerializeField]
    private GameObject piedraPrefab; // Prefab de la piedra que se generará

    [SerializeField]
    private float intervaloDeGeneracion = 2f; // Intervalo de tiempo entre generaciones

    [SerializeField]
    private float rangoX = 5f; // Rango a lo largo del eje X donde se generan las piedras

    [SerializeField]
    private float posicionY = 5f; // Posición fija en el eje Y donde se generan las piedras

    [SerializeField]
    private AudioClip sonidoCaballo; // Sonido del caballo
    [SerializeField]
    private AudioClip sonidoPaja; // Sonido de la paja

    private AudioSource audioSource;
    private AudioSource audioSource2;
    [SerializeField]
    private EfectoCamaraShake _EfectoCamaraShake;

    [SerializeField]
    private GameObject[] ocultar;
    [SerializeField]
    private GameObject[] aparecer;


    private void Awake()
    {
        // Verifica si ya existe una instancia del GameManager.
        if (instance == null)
        {
            // Si no existe, establece esta instancia como la instancia única.
            instance = this;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, destruye esta para evitar duplicados.
            Destroy(gameObject);
        }

        // Obtén o agrega un componente AudioSource
        audioSource = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Start()
    {
        // Iniciar la generación de piedras en intervalos regulares
        InvokeRepeating("GenerarPiedra", 0f, intervaloDeGeneracion);

        // Reproducir el sonido del caballo en bucle
        audioSource.clip = sonidoCaballo;
        audioSource.loop = true;
        audioSource.Play();

        audioSource2.clip = sonidoPaja;
        audioSource2.loop = true;
        audioSource2.Play();
    }

    private void GenerarPiedra()
    {
        // Generar una piedra en una posición aleatoria a lo largo del eje X
        Vector3 posicionGenerada = new Vector3(Random.Range(-rangoX, rangoX), posicionY, 0f);
        Instantiate(piedraPrefab, posicionGenerada, Quaternion.identity);

        // Reproducir el sonido de la paja
        audioSource.PlayOneShot(sonidoPaja);
    }

    public void Collision()
    {
        _EfectoCamaraShake.ActivarShake();
    }
    public void Volver()
    {
        GameManager.instance.Start_Scene("SampleScene");
       // GameManager.instance.GranadeVisible();
    }
    public void FinalMinijuego()
    {
        // Detener la generación de piedras
        CancelInvoke("GenerarPiedra");

        // Detener el sonido del caballo
        audioSource.Stop();
        audioSource2.Stop();
        foreach (GameObject desactivarObjeto in ocultar)
        {
            // Desactivar objetos y gestionar el fundido si es necesario
            if (desactivarObjeto.GetComponent<ControladorFundido>() != null)
            {
                desactivarObjeto.GetComponent<ControladorFundido>().ComenzarFundido();
            }
            else
            {
                desactivarObjeto.SetActive(false);
            }
        }

        foreach (GameObject desactivarObjeto in aparecer)
        {
            // Activar objetos y gestionar el fundido si es necesario
            if (desactivarObjeto.GetComponent<ControladorFundido>() != null)
            {
                
                desactivarObjeto.GetComponent<ControladorFundido>().ComenzarDesvanecer();
            }
            else
            {
                desactivarObjeto.SetActive(true);
            }
        }
    }
}
