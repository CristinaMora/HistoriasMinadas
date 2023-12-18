using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Movement : MonoBehaviour
{
    public Rigidbody2D _myrigidbody;
    public Transform _mytransform;
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
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        
        CadizUI.instance.GameOver();
    }
}
