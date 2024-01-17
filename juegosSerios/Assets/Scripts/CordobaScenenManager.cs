using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
    //                         0      1        2       3       4        5        6      7      8      9
    //                      isabel, patios1,patios2,juderia,mezquita,jardines,estatua,viana, medina, bar
    public bool[] monedas = { true, true, true, true, true, true, true, true, true, true };
    public static CordobaScenenManager instance;
    #region references
    [SerializeField]
    private CordobaUI uiManager;
    [SerializeField] public GameObject regadera;
    [SerializeField] public GameObject imagen;
    [SerializeField] public GameObject container;
    [SerializeField] public GameObject parent;
    [SerializeField] public GameObject moneda;
    [SerializeField] public GameObject jarron;
    [SerializeField] public GameObject jarronroto;
    [SerializeField] public GameObject opcion1;
    [SerializeField] public GameObject opcion2;
    [SerializeField] public GameObject gente;
    [SerializeField]
    private AudioClip sonidito; // Sonido del caballo
    private AudioSource audioSource;
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
        // Obtén o agrega un componente AudioSource
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = sonidito;
        audioSource.loop = true;
        audioSource.Play();

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
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(8));
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
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(6));
        Dialog.instance.setnum(6);

    }
    public void maceta3()
    {
        Dialog.instance.activaCuadroDialogo();
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(7));
        Dialog.instance.setnum(7);

    }
    public void monedacelo()
    {
        Dialog.instance.activaCuadroDialogo();
        desactivaopciones();

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
        desactivaopciones();

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
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(33));
        Dialog.instance.setnum(33);

    }
    public void jardines2()
    {
        Dialog.instance.activaCuadroDialogo();
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(34));
        Dialog.instance.setnum(34);

    }
    public void jardines3()
    {
        Dialog.instance.activaCuadroDialogo();
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(35));
        Dialog.instance.setnum(35);

    }
    public void jardines4()
    {
        Dialog.instance.activaCuadroDialogo();
        desactivaopciones();

        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(36));
        Dialog.instance.setnum(36);
        if (monedas[5])
        {
            addMoneda();
            monedas[5] = false;

        }

    }
    public void monedapalacio()
    {
        if (monedas[7])
        {
            addMoneda();
            monedas[7] = false;
            imagen.SetActive(false);
            container.SetActive(false);
            parent.SetActive(false);
            moneda.SetActive(false);
        }

    }

    public void cambioescenaPatios2()
    {
        if (monedas[2])
        {
            Dialog.instance.activaCuadroDialogo();
            desactivaopciones();

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
            desactivaopciones();

            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(0));
            Dialog.instance.setnum(0);
        }
        else Dialog.instance.desactivaCuadroDialogo();


    }
    public void cambioescenaJuderia()
    {
        jarron.SetActive(false);
        jarronroto.SetActive(false);
        if (monedas[3])
        {
            Dialog.instance.activaCuadroDialogo();
            desactivaopciones();

            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(18));
            Dialog.instance.setnum(18);

        }
        else
        {
            jarronroto.SetActive(true);
            Dialog.instance.desactivaCuadroDialogo();


        }

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
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(38));
            Dialog.instance.setnum(38);
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
        imagen.SetActive(false);
        container.SetActive(false);
        parent.SetActive(false);
        moneda.SetActive(false);

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
        bool todas = monedas[0] || monedas[1] || monedas[2] || monedas[3] || monedas[4] || monedas[5] || monedas[6] || monedas[7] || monedas[8];
    
        gente.SetActive(false);
        if (todas)
        {
            //58 
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(57));
            Dialog.instance.setnum(57);
        }
        else
        {
            //56no tengo hambre
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(58));
            Dialog.instance.setnum(58);
        }

    }
    public void activaopciones()
    {
        opcion1.SetActive(true);
        opcion2.SetActive(true);
    }
    public void desactivaopciones()
    {
        opcion1.SetActive(false);
        opcion2.SetActive(false);
    }
    public void cambiajarrones()
    {

        jarron.SetActive(false);
        jarronroto.SetActive(true);
        Dialog.instance.activaCuadroDialogo();
        CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(67));
        Dialog.instance.setnum(67);
        monedas[3] = false;
        addMoneda();
    }
    public void monedabar()
    {
        if (monedas[9])
        {
            monedas[9] = false;
            addMoneda();
            Dialog.instance.activaCuadroDialogo();
            CordobaUI.instance.actualizadialogo(Dialog.instance.specificText(71));
            Dialog.instance.setnum(71);
        }
    }
}
