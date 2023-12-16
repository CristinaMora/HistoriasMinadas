using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
    bool[] monedas = { true, true, true, true, true, true, true, true, true, true, };
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
    public void maceta()
    {

        //el texto 5
        Dialog.instance.activaCuadroDialogo();
        Dialog.instance.specificText(5);
    }
    public void maceta2()
    {
        //el texto el 6

    }
    public void macetaconmoneda()
    {
        //el 7 

    }
    public void cambioescenaPatios2()
    {
        //el texto 8

    }
}
