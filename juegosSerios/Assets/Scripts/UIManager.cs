using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region references
    [SerializeField] private Image _fondo;
    [SerializeField] private GameObject _titulo;
    [SerializeField] private GameObject _play;
    [SerializeField] private GameObject _exit;
    [SerializeField] private GameObject _cadiz;
    [SerializeField] private GameObject _huelva;
    [SerializeField] private GameObject _sevilla;
    [SerializeField] private GameObject _almeria;
    [SerializeField] private GameObject _cordoba;
    [SerializeField] private GameObject _granada;
    [SerializeField] private GameObject _jaen;
    [SerializeField] private GameObject _malaga;
    [SerializeField] private GameObject insigniacordoba;
    [SerializeField] private GameObject insigniacadiz;
    [SerializeField] private GameObject insigniagranada;
    #endregion

    public bool[] juegosjugados;
    // Start is called before the first frame update
    void Start()
    {
        _titulo.SetActive(true);
        _play.SetActive(true);
        _exit.SetActive(true);
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _fondo.GetComponent<Image>().enabled = true;
        _almeria.SetActive(false); 
        _cordoba.SetActive(false); 
        _granada.SetActive(false); 
        _jaen.SetActive(false); 
        _malaga.SetActive(false);
        insigniacordoba.SetActive(false);
        insigniacadiz.SetActive(false);
        insigniagranada.SetActive(false);

    }

    public void reinicio()
    {
        _titulo.SetActive(false);
        _play.SetActive(false);
        _exit.SetActive(false);
        _cadiz.SetActive(true);
        _huelva.SetActive(true);
        _sevilla.SetActive(true);
        _almeria.SetActive(true);
        _cordoba.SetActive(true);
        _granada.SetActive(true);
        _jaen.SetActive(true);
        _malaga.SetActive(true);
    }
    public void PlayMenu()
    {
        _titulo.SetActive(false);
        _play.SetActive(false);
        _exit.SetActive(false);
        _cadiz.SetActive(true);
        _huelva.SetActive(true);
        _sevilla.SetActive(true);
        _almeria.SetActive(true);
        _cordoba.SetActive(true);
        _granada.SetActive(true);
        _jaen.SetActive(true);
        _malaga.SetActive(true);

        juegosjugados = GameManager.instance.juegosjugados;
        if (juegosjugados[0])
        {
            insigniacordoba.SetActive(true);
           
        }
        if (juegosjugados[1])
        {
            insigniacadiz.SetActive(true);
           
        }
        if (juegosjugados[2])
        {
            insigniagranada.SetActive(true);
        }

    }
    public void Cadiz()
    {
        _cadiz.SetActive(true);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
        GameManager.instance.Start_Scene("Cadiz");
    }

    public void Sevilla()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(true);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
    }
    public void Almeria()
    {

        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(true);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
      
    }
    public void Cordoba()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(true);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
        GameManager.instance.Start_Scene("Cordoba");

    }
    public void Granada()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(true);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
        GameManager.instance.Start_Scene("Granada");

    }
    public void Jaen()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(true);
        _malaga.SetActive(false);
    }
    public void Malaga()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(false);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(true);
    }
    public void Huelva()
    {
        _cadiz.SetActive(false);
        _huelva.SetActive(true);
        _sevilla.SetActive(false);
        _almeria.SetActive(false);
        _cordoba.SetActive(false);
        _granada.SetActive(false);
        _jaen.SetActive(false);
        _malaga.SetActive(false);
    }
    public void InfoTurismo()
    {
        
        string nombreBoton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        GameManager.instance.DondeTurismo = nombreBoton;
        GameManager.instance.Start_Scene("Informacion");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
