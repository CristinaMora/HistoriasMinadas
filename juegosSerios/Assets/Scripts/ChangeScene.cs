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
    { // Desactivar los GameObjects especificados en el array Desactivar
        foreach (GameObject desactivarObjeto in Desactivar)
        {
            desactivarObjeto.SetActive(false);

            // Activar cada hijo del GameObject actual
            foreach (Transform hijoTransform in desactivarObjeto.transform)
            {
                hijoTransform.gameObject.SetActive(false);
            }
        }

        // Activar los GameObjects especificados en el array Activar
        foreach (GameObject activarObjeto in Activar)
        {
            activarObjeto.SetActive(true);
            // Desactivar cada hijo del GameObject actual
            foreach (Transform hijoTransform in activarObjeto.transform)
            {
                hijoTransform.gameObject.SetActive(true);
            }
        }
    }
}
