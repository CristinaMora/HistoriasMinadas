using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public static Dialog instance;

    [SerializeField] GameObject textodialogo;
    [SerializeField] GameObject cuadrodialogo;
    [SerializeField] GameObject botondialogo;
    [SerializeField] LevelData _levelData;

    TMP_Text _text = null;

   public int numdialog; //numero del dialogo por el que vas
    private void Awake()
    {
        // Verifica si ya existe una instancia del GameManager.
        if (instance == null)
        {
            // Si no existe, establece esta instancia como la instancia única.
            instance = this;
            //DontDestroyOnLoad(gameObject);
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
        if (textodialogo != null)
        {
            _text = textodialogo.GetComponent<TMP_Text>();
            _text.text = _levelData.texto[0];
        }
            
        numdialog = -1;
    }

    public string specificText(int num)
    {
        if (_levelData.texto.Length > num)
            return _levelData.texto[num];
        else return "fallo";
    }
    public string nextText()
    {
        numdialog++;
     
        if (_levelData.texto.Length > numdialog)
        {
            return _levelData.texto[numdialog];
        }
           
        else return "fallo";
    }
    
    public int getnum() { return numdialog; }
    public void setnum(int a) {  numdialog = a; }
    public void activaCuadroDialogo()
    {
        textodialogo.SetActive(true);
        cuadrodialogo.SetActive(true);
        botondialogo.SetActive(true);
    }
    public void desactivaCuadroDialogo()
    {
        textodialogo.SetActive(false);
        cuadrodialogo.SetActive(false);
        botondialogo.SetActive(false);
    }
}
