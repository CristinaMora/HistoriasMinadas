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
   

    // Start is called before the first frame update
    void Start()
    {
        cadiz.SetActive(true);
        button.SetActive(true);
        almadraba.SetActive(true);
        explicacion.SetActive(true);
        border.SetActive(true);

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
        explicacion?.SetActive(false);
       
    }
}
