using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    int cont = 0;
    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aa");
        if(collision.gameObject.name == "maceta")
        {
            collision.gameObject.SetActive(false);
            cont++;
            if (cont == 7)
            {
                CordobaScenenManager.instance.monedadeestatua();
            }
        }

    }
    
}
