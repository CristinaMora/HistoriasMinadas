using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    GameObject[] Desactivar;
    [SerializeField]
    GameObject[] Activar;
    // Start is called before the first frame update
  
    public void Clicky()
    {
        for (int i=0; i<Desactivar.Length; i++){
            Desactivar[i].SetActive(false);
        }
        for (int i = 0; i < Activar.Length; i++)
        {
            Activar[i].SetActive(true);
        }
    }
}
