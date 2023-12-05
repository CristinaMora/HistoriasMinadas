using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turismo : MonoBehaviour
{
    [SerializeField] private TMP_Text _titulo;
    // Start is called before the first frame update
    void Start()
    {
        _titulo.gameObject.SetActive(true);
        _titulo.text = GameManager.instance.DondeTurismo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
