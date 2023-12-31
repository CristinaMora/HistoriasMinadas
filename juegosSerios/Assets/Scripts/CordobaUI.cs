using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CordobaUI : MonoBehaviour
{
    public static CordobaUI instance;
    [SerializeField] private GameObject _escenaTitulo;
    [SerializeField] private GameObject _bocadillo;
    [SerializeField] private GameObject _escena1;
    [SerializeField] private GameObject _escena2;
    [SerializeField] private GameObject _escena3;
    [SerializeField] private GameObject _escena4;
    [SerializeField] private GameObject _escena5;
    [SerializeField] private GameObject _escena6;
    [SerializeField] private GameObject _escena7;
    [SerializeField] private GameObject _escena8;
    [SerializeField] private GameObject _escena9;
    [SerializeField] private TMP_Text _nummonedas;
    [SerializeField] private TMP_Text _texto;
    [SerializeField] private TMP_Text _opcion1;
    [SerializeField] private TMP_Text _opcion2;
    private void Awake()
    {
        // Verifica si ya existe una instancia 
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
    // Start is called before the first frame update
    void Start()
    {
        _escenaTitulo.SetActive(true);
        _bocadillo.SetActive(false);
          _escena1.SetActive(false);
          _escena2.SetActive(false);
          _escena3.SetActive(false);
          _escena4.SetActive(false);
          _escena5.SetActive(false);
          _escena6.SetActive(false);
          _escena7.SetActive(false);
          _escena8.SetActive(false);
          _escena9.SetActive(false);
          _texto.gameObject.SetActive(false);
          _nummonedas.gameObject.SetActive(false);
    }

    public void nextdialog()
    {
        Debug.Log(Dialog.instance.numdialog);
        int a = Dialog.instance.numdialog;
        if (a!= 5 && a!= 8 && a != 6 && a != 7 && a != 17 && a != 27 && a != 28 && a != 21 && a != 32 && a != 33 && a != 34 && a != 35 && a != 36 && a != 39 && a != 40 && a != 46 && a != 55 && a != 57 && a != 59 && a != 62 && a != 63 && a != 66 && a != 67 && a != 70 && a != 76 && a != 69)
        {
            _texto.text = Dialog.instance.nextText();
            
        }
        else
        {
            if (Dialog.instance.numdialog == 5)
            {
                if (CordobaScenenManager.instance.monedas[0])
                {
                    CordobaScenenManager.instance.addMoneda();
                    CordobaScenenManager.instance.monedas[0] = false;
                }
               
            }
            else if (Dialog.instance.numdialog == 39)
            {
                CordobaScenenManager.instance.regadera.SetActive(true);

            }
            else if (Dialog.instance.numdialog == 46)//escena alfomra
            {
                CordobaScenenManager.instance.container.SetActive(true);
                CordobaScenenManager.instance.imagen.SetActive(true);
                CordobaScenenManager.instance.parent.SetActive(true);
                CordobaScenenManager.instance.moneda.SetActive(true);

            }
            else if (Dialog.instance.numdialog == 55)
            {
                if (CordobaScenenManager.instance.monedas[8])
                {
                    CordobaScenenManager.instance.addMoneda();
                    CordobaScenenManager.instance.monedas[8] = false;
                }

            }
            else if (Dialog.instance.numdialog == 66)
            {
                CordobaScenenManager.instance.jarron.SetActive(true);


            }
            else if (Dialog.instance.numdialog == 57)
            {
                _escena8.SetActive(false);


            }
            else if (Dialog.instance.numdialog == 70)
            {
                //activar muchos objetos
                CordobaScenenManager.instance.gente.SetActive(true);

            }
            else if (Dialog.instance.numdialog == 76)
            {
                GameManager.instance.juegosjugados[0] = true;
                SceneManager.LoadScene("SampleScene");
                //carga la escana del menu
            }

            Dialog.instance.desactivaCuadroDialogo();
            if (Dialog.instance.numdialog == 21)
            {
                Dialog.instance.activaCuadroDialogo();
                CordobaScenenManager.instance.desactivaopciones();
                actualizadialogo(Dialog.instance.specificText(60));
                Dialog.instance.setnum(60);

            }
            else if (Dialog.instance.numdialog == 62)
            {
                Dialog.instance.activaCuadroDialogo();
                _texto.gameObject.SetActive(false);
                CordobaScenenManager.instance.opcion1.SetActive(true);
                CordobaScenenManager.instance.opcion2.SetActive(true);
                _opcion1.text = "Me quedo con el jarron";
                _opcion2.text = "No quiero nada";

            }
            else if (Dialog.instance.numdialog == 59)
            {
                Dialog.instance.activaCuadroDialogo();
                _texto.gameObject.SetActive(false);
                CordobaScenenManager.instance.opcion1.SetActive(true);
                CordobaScenenManager.instance.opcion2.SetActive(true);
                _opcion1.text = "corro";
                _opcion2.text = "voy anadando";

            }
        }

    }
    public void actualizaMonedas(int num)
    {
        _nummonedas.text = num.ToString();

    }
    public void actualizadialogo(string text)
    {
        _texto.text = text;
    }
    public void clicknonojarron()
    {
        if (_escena8.activeSelf)//escena del bar opcion2 andar
        {
            CordobaScenenManager.instance.opcion1.SetActive(false);
            CordobaScenenManager.instance.opcion2.SetActive(false);
            _texto.gameObject.SetActive(true);
            actualizadialogo(Dialog.instance.specificText(69));
            Dialog.instance.setnum(69);
        }
        else
        {
            CordobaScenenManager.instance.opcion1.SetActive(false);
            CordobaScenenManager.instance.opcion2.SetActive(false);
            _texto.gameObject.SetActive(true);
            actualizadialogo(Dialog.instance.specificText(63));
            Dialog.instance.setnum(63);
        }
        
    }
    public void clickjarron()
    {
        if (_escena8.activeSelf)//escena del bar opcion1 correr
        {
            CordobaScenenManager.instance.opcion1.SetActive(false);
            CordobaScenenManager.instance.opcion2.SetActive(false);
            _texto.gameObject.SetActive(true);
            actualizadialogo(Dialog.instance.specificText(70));
            Dialog.instance.setnum(70);
        }
        else
        {
            CordobaScenenManager.instance.opcion1.SetActive(false);
            CordobaScenenManager.instance.opcion2.SetActive(false);
            _texto.gameObject.SetActive(true);
            actualizadialogo(Dialog.instance.specificText(64));
            Dialog.instance.setnum(64);
        }
       
    }

}
