using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CordobaUI : MonoBehaviour
{
    [SerializeField] private GameObject _imagenini;
    [SerializeField] private GameObject _textoini;
    [SerializeField] private GameObject _fotopatios;
    [SerializeField] private GameObject _isabel;
    [SerializeField] private Button _inicio;
    // Start is called before the first frame update
    void Start()
    {
        _imagenini.SetActive(true);
        _textoini.SetActive(true);
        _isabel.SetActive(false);
        _fotopatios.SetActive(false);
        _inicio.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void patios()
    {
        _imagenini.SetActive(false);
        _textoini.SetActive(false);
        _isabel.SetActive(true);
        _fotopatios.SetActive(true);
        _inicio.gameObject.SetActive(false);


    }
}
