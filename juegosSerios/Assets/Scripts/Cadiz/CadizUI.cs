using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CadizUI : MonoBehaviour
{

    [SerializeField] private GameObject borderimage;
    [SerializeField] private GameObject paquitatext;
    [SerializeField] private GameObject almadrabatext;
    [SerializeField] private GameObject buttonplay;
    [SerializeField] private GameObject explicaciontext;
    [SerializeField] private GameObject fishplayer;
    [SerializeField] private GameObject redgenerator;
    [SerializeField] private GameObject tartarimage;
    [SerializeField] private GameObject puertoimage;
    [SerializeField] private GameObject barcoimage;
    [SerializeField] private GameObject dialogoobject;
    [SerializeField] private TMP_Text dialogotext;
    [SerializeField] private GameObject pescadoraimage;
   

    // Start is called before the first frame update
    void Start()
    {
        
        borderimage.SetActive(true);
        paquitatext.SetActive(true);
        almadrabatext.SetActive(true);
        buttonplay.SetActive(true);
        explicaciontext.SetActive(true);
        fishplayer.SetActive(false); 
        redgenerator.SetActive(false);
        tartarimage.SetActive(false);
        puertoimage.SetActive(false);
        barcoimage.SetActive(false);
        dialogoobject.SetActive(false);
        pescadoraimage.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

     public void PlayButton()
    {
        borderimage.SetActive(false);
        paquitatext.SetActive(false);
        almadrabatext.SetActive(false);
        buttonplay.SetActive(false);
        explicaciontext.SetActive(false);
        puertoimage.SetActive(false);
        dialogoobject.SetActive(true);
        pescadoraimage.SetActive(true);
    }
    public void Play()
    {
        //dialogo.SetActive(false);
        fishplayer.SetActive(true);
        redgenerator.SetActive(true);
        pescadoraimage.SetActive(false);
    }
    public void dialogofunction()
    {
        int ndialog = Dialog.instance.numdialog;
        if(ndialog == 7) {
            puertoimage.SetActive(false);
            barcoimage .SetActive(true);
        }
        else if(ndialog == 7)
        {
            Dialog.instance.desactivaCuadroDialogo();
            Play();
        }
        else
        {
           dialogotext.text = Dialog.instance.nextText();
        }
    }
}
