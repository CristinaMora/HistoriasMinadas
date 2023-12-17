using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
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
    private void Awake()
    {
        // Verifica si ya existe una instancia 
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
        if (a!= 5 && a!= 8 && a != 6 && a != 7 && a != 17 && a != 27 && a != 28 && a != 21 && a != 32 && a != 39 && a != 40 && a != 46 && a != 55)
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
            else if (Dialog.instance.numdialog == 21)
            {
                if (CordobaScenenManager.instance.monedas[3])
                {
                    CordobaScenenManager.instance.addMoneda();
                    CordobaScenenManager.instance.monedas[3] = false;
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
            Dialog.instance.desactivaCuadroDialogo();
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
}
