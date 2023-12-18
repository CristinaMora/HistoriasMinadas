using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Movement : MonoBehaviour
{
    public Rigidbody2D _myrigidbody;
   
    public float speedjump;
    [SerializeField] private GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _myrigidbody.velocity = Vector2.up * speedjump ;
        }
        if (transform.position.y > 4.5)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
        else if(transform.position.y < -4.7)
        {
            transform.position = new Vector3(transform.position.x, -4.7f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        CadizUI.instance.GameOver();
    }
}
