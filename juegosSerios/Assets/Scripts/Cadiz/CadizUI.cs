using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CadizUI : MonoBehaviour
{
    public static CadizUI instance;
    [SerializeField] private GameObject borderimage;
    [SerializeField] private GameObject paquitatext;
    [SerializeField] private GameObject almadrabatext;
    [SerializeField] private GameObject buttonplay;
    [SerializeField] private GameObject explicaciontext;
    [SerializeField] private GameObject fishplayer;
    [SerializeField] private GameObject redgenerator;
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject playagainbutton;
    [SerializeField] private GameObject puertoimage;
    [SerializeField] private GameObject barcoimage;
    [SerializeField] private GameObject dialogoobject;
    [SerializeField] private TMP_Text dialogotext;
    [SerializeField] private GameObject pescadoraimage;
    [SerializeField] private GameObject fondoimage;
    [SerializeField] private GameObject fondoimage2;
    private bool gameoverbool = false;
    private float timer = 0;

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
        dialogoobject.SetActive(true);
        Play();

        //borderimage.SetActive(true);
        //paquitatext.SetActive(true);
        //almadrabatext.SetActive(true);
        //buttonplay.SetActive(true);
        //explicaciontext.SetActive(true);
        //fishplayer.SetActive(false); 
        //redgenerator.SetActive(false);
        //gameover.SetActive(false);
        //playagainbutton.SetActive(false);
        //puertoimage.SetActive(false);
        //barcoimage.SetActive(false);
        //dialogoobject.SetActive(false);
        //pescadoraimage.SetActive(false);
        //fondoimage.SetActive(false);
        //fondoimage2.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
        if (gameoverbool==true)
        {
            
            if (timer > 3)
            {
                timer = 0;
                playagainbutton.SetActive(true);
                gameoverbool = false;

            }
            timer += Time.deltaTime;
        }
    }

     public void PlayButton()
    {
        borderimage.SetActive(false);
        paquitatext.SetActive(false);
        almadrabatext.SetActive(false);
        buttonplay.SetActive(false);
        explicaciontext.SetActive(false);
        puertoimage.SetActive(true);
        dialogoobject.SetActive(true);
        pescadoraimage.SetActive(true);
        
    }
    public void Play()
    {
        Dialog.instance.desactivaCuadroDialogo();
        barcoimage.SetActive(false);
        fishplayer.SetActive(true);
        redgenerator.SetActive(true);
        pescadoraimage.SetActive(false);
        fondoimage.SetActive(true);
        fondoimage2.SetActive(true);
    }
    public void PlayAgain()
    {
        Dialog.instance.desactivaCuadroDialogo();
        pescadoraimage.SetActive(false);
        gameover.SetActive(false);
        playagainbutton.SetActive(false);
        fishplayer.SetActive(true);
        redgenerator.SetActive(true);
        fondoimage.SetActive(true);
        fondoimage.GetComponent<Fondo_Movement>().start();
        fondoimage2.SetActive(true);
        fondoimage2.GetComponent<Fondo_Movement>().start();


    }

    public void dialogofunction()
    {
        int ndialog = Dialog.instance.numdialog;
        if(ndialog == 7) {
            puertoimage.SetActive(false);
            barcoimage .SetActive(true);
            dialogotext.text = Dialog.instance.nextText();
        }
        else if(ndialog == 14)
        {
            Play();
        }
        else if (ndialog == 17)
        {
            PlayAgain();
        }
        else
        {
           dialogotext.text = Dialog.instance.nextText();
        }
    }
    public void GameOver()
    {
        fishplayer.SetActive(false);
        redgenerator.SetActive(false);
        gameover.SetActive(true);
        gameoverbool = true;
        fondoimage.SetActive(false);
        fondoimage2.SetActive(false);
    }
    public void FirstCheckPoint()
    {
        pescadoraimage.SetActive(true);
        redgenerator.SetActive(false);
        fishplayer.SetActive(false);
       
        Dialog.instance.activaCuadroDialogo();
        Dialog.instance.setnum(15);
        fondoimage.GetComponent<Fondo_Movement>().stop();
        fondoimage2.GetComponent<Fondo_Movement>().stop();



    }
    public void Win()
    {
        Debug.Log("jbbc");
    }
}
