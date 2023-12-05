using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
    public static CordobaScenenManager instance;
    #region references
    [SerializeField]
    private CordobaUI uiManager;
    int numMonedas;
    #endregion
    private void Awake()
    {
        // Verifica si ya existe una instancia del GameManager.
        if (instance == null)
        {
            // Si no existe, establece esta instancia como la instancia única.
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, destruye esta para evitar duplicados.
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        numMonedas = 0;
    }
    public void addMoneda()
    {
        numMonedas++;
        uiManager.actualizaMonedas(numMonedas);
    }

}
