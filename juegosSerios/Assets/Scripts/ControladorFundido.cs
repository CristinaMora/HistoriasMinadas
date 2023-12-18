using UnityEngine;
using UnityEngine.UI;

public class ControladorFundido : MonoBehaviour
{
    public Button[] botones;
    public Image panelNegroImage = null;
    public SpriteRenderer panelNegroSpriteRenderer = null;
    public float velocidadFundido = 2.0f;

    private bool fundidoActivo = false;
    private float alpha = 0.0f;
    bool apagade=false;
    void Start()
    {
        // Desactiva el panel al inicio (opcional, dependiendo de tu dise�o)
        // panelNegro.gameObject.SetActive(false);
    }

    void Update()
    {
        if (fundidoActivo)
        {
            if (panelNegroImage != null)
            {
                // Ajusta solo la transparencia del panel gradualmente (para UI Images)
                Color nuevoColor = panelNegroImage.color;
                nuevoColor.a = Mathf.Lerp(nuevoColor.a, alpha, velocidadFundido * Time.deltaTime);
                panelNegroImage.color = nuevoColor;
            }
            else if (panelNegroSpriteRenderer != null)
            {
                // Ajusta solo la transparencia del panel gradualmente (para Sprites)
                Color nuevoColor = panelNegroSpriteRenderer.color;
                nuevoColor.a = Mathf.Lerp(nuevoColor.a, alpha, velocidadFundido * Time.deltaTime);
                panelNegroSpriteRenderer.color = nuevoColor;
            }

            // Si la transparencia es casi completa, activa el siguiente bot�n
            //if (Mathf.Abs(alpha - 1.0f) < 0.05f)
            //{
            //    MostrarSiguienteBoton();
            //}
        }
    }

    public void ComenzarFundido()
    {
        if (!apagade)
        {
            apagade = true;
            Debug.Log("fundir "+this.name);
            // Ajusta la transparencia al m�nimo y activa el panel
            alpha = 0.0f;
            fundidoActivo = true;
        }
    
    }

    public void ComenzarDesvanecer()
    {
        if (!apagade)
        {
            apagade = true;
            Debug.Log("desvanecer "+this.name);
            // Ajusta la transparencia al m�ximo y activa el panel
            alpha = 1.0f;
            fundidoActivo = true;
        }
       
    }

    void MostrarSiguienteBoton()
    {
       
        // Desactiva el panel y muestra el siguiente bot�n
        if (panelNegroImage != null)
        {
            panelNegroImage.gameObject.SetActive(false);
        }
        else if (panelNegroSpriteRenderer != null)
        {
            panelNegroSpriteRenderer.gameObject.SetActive(false);
        }

        fundidoActivo = false;

        // Implementa la l�gica para mostrar el siguiente bot�n aqu�
        // Por ejemplo, activar el siguiente GameObject que contiene el bot�n
    }
}
