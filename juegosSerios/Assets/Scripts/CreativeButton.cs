using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreativeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Obt�n el componente Image
        Image imageComponent = this.GetComponent<Image>();

        // Aseg�rate de que la textura sea legible
        if (imageComponent.sprite != null && imageComponent.sprite.texture.isReadable)
        {
            // Accede a la textura a trav�s de Texture2D
            Texture2D texture = imageComponent.sprite.texture;
           
            // Verifica si la textura est� utilizando compresi�n Crunch
            // Verifica si la textura es legible
            if (texture.format == TextureFormat.ARGB32 || texture.format == TextureFormat.RGBA32)
            {
                // Tu l�gica aqu�
                imageComponent.alphaHitTestMinimumThreshold = 0.1f;
            }

            else
            {
                Debug.LogError("La textura no est� utilizando compresi�n Crunch.");
                Debug.Log(this.name);
            }
        }
        else
        {
            Debug.LogError("La textura no es legible.");
        }
    }
}
