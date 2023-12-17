using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
   public bool[] monedas = { true, true, true, true, true, true, true, true, true, true};
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
            // Si no existe, establece esta instancia como la instancia �nica.
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
        CordobaUI.instance.actualizadialogo( Dialog.instance.specificText(8));
        Dialog.instance.setnum(8);
        if (monedas[1])
        {
            addMoneda();
            monedas[1] = false;

        }

    }
    public void maceta2()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(6));
        Dialog.instance.setnum(6);

    }
    public void maceta3()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(7));
        Dialog.instance.setnum(7);

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
