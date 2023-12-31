using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Horizontal_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float dead = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed)*Time.deltaTime;
        if(transform.position.x < dead) {
            Destroy(gameObject);
        }
    }
}
