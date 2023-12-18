using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo_Movement : MonoBehaviour
{
    [SerializeField] private float speed=2;
    private Vector3 posInicio;
    private bool stopbool = false;
    private bool fp = true;
    // Start is called before the first frame update
    void Start()
    {
        posInicio = transform.position;
    }
    public void stop()
    {
        stopbool = true;
    }
    public void start()
    {
        stopbool = false;
    }
    

    // Update is called once per frame
    void Update()
    {
       
        if (stopbool == false)
        {
            transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        }
        
        if (transform.position.x <=0 && fp==true)
        {
            Debug.Log("AHORA");
            fp = false;
            CadizUI.instance.FirstCheckPoint();
            
        }
        
    }
}
