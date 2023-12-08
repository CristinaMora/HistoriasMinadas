using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Piedras : MonoBehaviour
{
    [SerializeField]
    private GameObject piedraPrefab; // Prefab de la piedra que se generará

    [SerializeField]
    private float intervaloDeGeneracion = 2f; // Intervalo de tiempo entre generaciones

    [SerializeField]
    private float rangoX = 5f; // Rango a lo largo del eje X donde se generan las piedras

    [SerializeField]
    private float posicionY = 5f; // Posición fija en el eje Y donde se generan las piedras

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
}
