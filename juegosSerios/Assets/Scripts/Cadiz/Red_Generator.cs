using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Generator : MonoBehaviour
{
    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    [SerializeField] float frecuency=2;
    private float time = 5;


    [SerializeField] public float height1 = 4;
    [SerializeField] public float height2 = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time < frecuency)
        {
           
            time += Time.deltaTime;

        }
        else
        {
            New_Red();
            time = 0;

        }
       
    }

    void New_Red()
    {
        int a = Random.Range(1, 5);
        if(a == 1 || a==2 )
        {
            float maxheight = transform.position.y + height1;
            float minheight = transform.position.y - height1;
            Instantiate(red1, new Vector3(transform.position.x, Random.Range(minheight, maxheight), 0), transform.rotation);
        }
        else if(a == 3 )
        {
            float maxheight = transform.position.y + height2;
            float minheight = 0;
            Instantiate(red2, new Vector3(transform.position.x, Random.Range(minheight, maxheight), 0), transform.rotation);

        }
        else if(a == 4)
        {
            float maxheight = transform.position.y + height1;
            float minheight = transform.position.y - height1;
            Instantiate(red3, new Vector3(transform.position.x, Random.Range(minheight, maxheight), 0), transform.rotation);
        }
        
    }
  
}
