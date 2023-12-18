using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class romper : MonoBehaviour
{
    int c = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (c >= 3)
        {
            CordobaScenenManager.instance.cambiajarrones();
        }
    }
    public void onckiky()
    {
        c++;
    }
}
