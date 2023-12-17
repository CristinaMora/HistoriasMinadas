using System.Collections;
using System.Collections.Generic;
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
    EfectoCamaraShake _EfectoCamaraShake;

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

    }
    private void Start()
    {
        // Iniciar la generación de piedras en intervalos regulares
        InvokeRepeating("GenerarPiedra", 0f, intervaloDeGeneracion);
    }

    private void GenerarPiedra()
    {
        // Generar una piedra en una posición aleatoria a lo largo del eje X
        Vector3 posicionGenerada = new Vector3(Random.Range(-rangoX, rangoX), posicionY, 0f);
        Instantiate(piedraPrefab, posicionGenerada, Quaternion.identity);
    }
    public void Collision()
    {
        _EfectoCamaraShake.ActivarShake();
    }
    public void FinalMinijuego()
    {
       // ocultar.SetActive(false);
        CancelInvoke("GenerarPiedra");
       // Debug.Log("sellama");
        foreach (GameObject desactivarObjeto in ocultar)
        {
           // desactivarObjeto.SetActive(true);
            if (desactivarObjeto.GetComponent<ControladorFundido>() != null)
            {
               // Debug.Log("fadeout");
            //    desactivarObjeto.gameObject.SetActive(true);
                desactivarObjeto.GetComponent<ControladorFundido>().ComenzarDesvanecer();
            }
            else
            {
                //Debug.Log("fat");
                desactivarObjeto.SetActive(false);
            }
        }
        foreach (GameObject desactivarObjeto in aparecer)
        {
            desactivarObjeto.SetActive(true);
            if (desactivarObjeto.GetComponent<ControladorFundido>() != null)
            {
                //Debug.Log("fadeout");
                desactivarObjeto.gameObject.SetActive(true);
                desactivarObjeto.GetComponent<ControladorFundido>().ComenzarFundido();
            }
            else
            {
                //Debug.Log("fat");
                desactivarObjeto.SetActive(true);   
            }
        }
    }
}
