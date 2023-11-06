using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
     float max_volume=0.5f;
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

    public void Start_Granada()
    {


        SceneManager.LoadScene("Granada");
        StartCoroutine(FadeOut());
        //sonidos[(int)current_music].Stop();
        save = music.rio_ancho;
        Debug.Log("workin");
        //sonidos[(int)current_music].Play();
       

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
        Debug.Log((int)save);
        Debug.Log((int)current_music);
        Debug.Log(sonidos.Length);
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
        Debug.Log("cuanto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
