using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreativeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Obtén el componente Image
        Image imageComponent = this.GetComponent<Image>();

        // Asegúrate de que la textura sea legible
        if (imageComponent.sprite != null && imageComponent.sprite.texture.isReadable)
        {
            // Accede a la textura a través de Texture2D
            Texture2D texture = imageComponent.sprite.texture;
           
            // Verifica si la textura está utilizando compresión Crunch
            // Verifica si la textura es legible
            if (texture.format == TextureFormat.ARGB32 || texture.format == TextureFormat.RGBA32)
            {
                // Tu lógica aquí
                imageComponent.alphaHitTestMinimumThreshold = 0.1f;
            }

            else
            {
                Debug.LogError("La textura no está utilizando compresión Crunch.");
                Debug.Log(this.name);
            }
        }
        else
        {
            Debug.LogError("La textura no es legible.");
        }
    }
}
