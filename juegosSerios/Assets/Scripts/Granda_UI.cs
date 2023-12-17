using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Granda_UI : MonoBehaviour
{

    [SerializeField] private TMP_Text _text;
    [SerializeField] Dialog _Dialog;
    [SerializeField] bool[] paso_dialogos;
    int currentmax = 7;
    int resart = 0;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = _Dialog.nextText();
    }
    
    public void netText()
    {
      
        _text.text = _Dialog.nextText();
        int a = _Dialog.getnum();
        Debug.Log(a);
        //Debug.Log(a);
        //if (paso_dialogos[a])
        //{
        //    _Dialog.desactivaCuadroDialogo();
        //}
        if (currentmax == a)
        {
            _Dialog.setnum(resart);
            _Dialog.desactivaCuadroDialogo();
        }
       
    }
    public void setNati()
    {
        resart = 8; currentmax = 21; _Dialog.setnum(8);
    }
    public void setAbuela()
    {
        resart = 21; currentmax = 26; _Dialog.setnum(21);
    }
    public void ActivarDialogo()
    {
        _Dialog.activaCuadroDialogo();
        _text.text = _Dialog.nextText();
    }
    public void start_minijuegueGranade()
    {
        GameManager.instance.Start_Scene("Granada_Minijuego");
    }

}
