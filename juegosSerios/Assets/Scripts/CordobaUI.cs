using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CordobaUI : MonoBehaviour
{
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
        if(Dialog.instance.numdialog != 4)
        {
            _texto.text = Dialog.instance.nextText();
            
        }
        else
        {
            if (Dialog.instance.numdialog == 4)
            {
                CordobaScenenManager.instance.addMoneda();
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
