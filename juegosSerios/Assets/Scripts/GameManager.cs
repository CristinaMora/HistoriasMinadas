using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;
    public static GameManager instance;
    private void Awake()
    {
        // Verifica si ya existe una instancia del GameManager.
        if (instance == null)
        {
            // Si no existe, establece esta instancia como la instancia única.
            instance = this;
        }
        else
        {
            // Si ya existe una instancia, destruye esta para evitar duplicados.
            Destroy(gameObject);
        }
    }

    public void Start_Granada()
    {
        



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
