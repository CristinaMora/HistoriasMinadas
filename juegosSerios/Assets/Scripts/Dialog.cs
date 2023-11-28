using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{

    [SerializeField]
    LevelData _levelData;

    int numdialog; //numero del dialogo por el que vas

    // Start is called before the first frame update
    void Start()
    {
        numdialog = 0;
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
            return _levelData.texto[numdialog];
        else return "fallo";
    }
    public void  changenumdialog(int num)
    {
        numdialog = num;
    }
}
