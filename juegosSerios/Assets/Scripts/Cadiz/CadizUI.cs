using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CadizUI : MonoBehaviour
{

    [SerializeField] private GameObject border;
    [SerializeField] private GameObject cadiz;
    [SerializeField] private GameObject almadraba;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject explicacion;
    [SerializeField] private GameObject fish;
    [SerializeField] private GameObject generator;
    [SerializeField] private GameObject tartarimage;
    [SerializeField] private GameObject dialogo;
    [SerializeField] private GameObject pescadora;

    // Start is called before the first frame update
    void Start()
    {
        cadiz.SetActive(true);
        button.SetActive(true);
        almadraba.SetActive(true);
        explicacion.SetActive(true);
        border.SetActive(true);
        fish.SetActive(false);
        generator.SetActive(false);
        tartarimage.SetActive(false);
        dialogo.SetActive(false);
        pescadora.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {

    }

     public void PlayButton()
    {
        cadiz.SetActive(false);
        button.SetActive(false);
        almadraba.SetActive(false);
        border.SetActive(false);
        explicacion.SetActive(false);
        dialogo.SetActive(true);
        pescadora.SetActive(true);
    }
    public void Play()
    {
        dialogo.SetActive(false);
        fish.SetActive(true);
        generator.SetActive(true);
        pescadora.SetActive(false);
    }
}
