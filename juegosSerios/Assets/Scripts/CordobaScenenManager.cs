using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
    //                         0      1        2       3       4        5        6      7      8      9
    //                      isabel, patios1,patios2,juderia,mezquita,jardines,estatua,viana, medina, bar
   public bool[] monedas = { true , true   , true  , true  , true   , true   , true  ,true , true  , true};
    public static CordobaScenenManager instance;
    #region references
    [SerializeField]
    private CordobaUI uiManager;
    [SerializeField] public GameObject regadera;
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
    public void monedacelo()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(28));
        Dialog.instance.setnum(28);
        if (monedas[4])
        {
            addMoneda();
            monedas[4] = false;

        }

    }
    public void monedadeestatua()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(40));
        Dialog.instance.setnum(40);
        regadera.SetActive(false);
        if (monedas[6])
        {
            addMoneda();
            monedas[6] = false;

        }

    }
    public void jardines1()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(33));
        Dialog.instance.setnum(33);

    }
    public void jardines2()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(34));
        Dialog.instance.setnum(34);

    }
    public void jardines3()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(35));
        Dialog.instance.setnum(35);

    }
    public void jardines4()
    {
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(36));
        Dialog.instance.setnum(36);
        addMoneda();

    }

    public void cambioescenaPatios2()
    {
        if (monedas[2])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(9));
            Dialog.instance.setnum(9);
        }
        else Dialog.instance.desactivaCuadroDialogo();

    }
    public void cambioescenaPatios()
    {
        if (monedas[0])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(0));
            Dialog.instance.setnum(0);
        }
        else Dialog.instance.desactivaCuadroDialogo();


    }
    public void cambioescenaJuderia()
    {
        if (monedas[3])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(18));
            Dialog.instance.setnum(18);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();           

    }
    public void cambioescenaMezquita()
    {
        if (monedas[4])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(22));
            Dialog.instance.setnum(22);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();           

    }
     
    public void cambioescenaJardines()
    {
        if (monedas[5])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(29));
            Dialog.instance.setnum(29);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();

    }
    public void cambioescenaEstatua()
    {
        if (monedas[6])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(37));
            Dialog.instance.setnum(37);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();

        regadera.SetActive(false);

    }
    public void cambioescenaPalacio()
    {
        if (monedas[7])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(41));
            Dialog.instance.setnum(41);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();

    }
    public void cambioescenaMedina()
    {
        if (monedas[8])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(47));
            Dialog.instance.setnum(47);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();

    }
    public void cambioescenabar()
    { //falta poner si alguna de las monedas no ha sido recogida que no entre 
        bool todas= true;
        int i = 0;
        //for(i = 0; i < monedas.Length; i++)
        //{

        //}
        if (monedas[9])
        {
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(18));
            Dialog.instance.setnum(18);
        }
        else
            Dialog.instance.desactivaCuadroDialogo();

    }
}
