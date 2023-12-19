using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;
    public static GameManager instance;

    public AudioSource[] sonidos = new AudioSource[3];
    public enum music { Dos_aguas,reflejo_de_luna,rio_ancho};
    private music current_music;
    private music save=music.Dos_aguas;
    const int n_music = 3;
    bool fadingOut = false;
    float duracionFadeOut = 3.0f;
    float duracionFadeIn = 5.0f;
     public float max_volume=0.25f;
    public Text texto; //texto 
    [SerializeField] private GameObject g;
    public GameObject[] imagenes=new GameObject[2];  // Lista de imágenes que componen la secuencia
    private int indiceActual = 0;
    private enum states {menu, almeria,granada,malaga,jaen};
    states curr=states.menu;
     //                    cordoba, cadiz, granada
    public bool[] juegosjugados ={ false, false,false};
    public string[] names = { "GRANADA", "CORDOBA", "CADIZ" };
    public string DondeTurismo; //string para la escena de turismo
    private void Awake()
    {
        // Verifica si ya existe una instancia del GameManager.
        if (instance == null)
        {
            // Si no existe, establece esta instancia como la instancia única.
            instance = this;
           DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, destruye esta para evitar duplicados.
            Destroy(gameObject);
        }
      
    }
    public void Start_Scene(string name)
    {

        SceneManager.LoadScene(name);
        if(name == "Granada")
        {
            StartCoroutine(FadeOut());
            save = music.rio_ancho;
            curr = states.granada;
        }
 
    }
    public void VuelveGranada()
    {
        GameObject canvas = GameObject.Find("UI");
      //  Debug.Log(canvas);
        uiManager = canvas.GetComponent<UIManager>();
        uiManager.reinicio();
        juegosjugados[0] = true;
        for(int i = 0; i < 3; ++i)
        {
            if (juegosjugados[i])
            {
                GameObject granada = GameObject.Find(names[i]);
                granada.SetActive(true);

            }
        }
    }
    IEnumerator FadeOut()
    {
        fadingOut = true;
        float startVolume = sonidos[(int)current_music].volume;
        float timer = 0f;

        while (timer < duracionFadeOut)
        {
            Debug.Log(timer);
            timer += Time.deltaTime;
            sonidos[(int)current_music].volume = Mathf.Lerp(startVolume, 0, timer / duracionFadeOut);
            yield return null;
        }
        sonidos[(int)current_music].volume = 0;
        sonidos[(int)current_music].Stop();
        fadingOut = false;
        current_music = save;
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
 
        sonidos[(int)current_music].Play();
        float startVolume = 0;
        sonidos[(int)current_music].volume = startVolume;
        float timer = 0f;

        while (timer < duracionFadeIn)
        {
            timer += Time.deltaTime;
            sonidos[(int)current_music].volume = Mathf.Lerp(startVolume, max_volume, timer / duracionFadeIn);
            yield return null;
        }

        sonidos[(int)current_music].volume = max_volume;
    }
    // Start is called before the first frame update
    void Start()
    {
      
        for (int i = 0; i < n_music; i++)
        {
            sonidos[i].Stop();
            sonidos[i].volume = 0;
        }
       
        current_music = music.Dos_aguas;
        StartCoroutine(FadeIn());
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    void AvanzarImagen()
    {
        indiceActual++;
        if (indiceActual <2)
        {
            MostrarImagenActual();
        }
        else
        {
            // La secuencia de imágenes ha llegado al final
            Debug.Log("Secuencia de imágenes completada.");
        }
    }
    void MostrarImagenActual()
    {
        if (indiceActual < 2)
        {
            imagenes[indiceActual].SetActive(true);
            imagenes[indiceActual].GetComponent<Image>().enabled = true;
        }
    }
    void Ocultartexto()
    {
        // Accede al objeto Text
        texto = GameObject.Find("Intro").GetComponent<Text>();
        texto.enabled = false;
    }
    public void GranadeVisible()
    {
        g.SetActive(true);

    }


}
