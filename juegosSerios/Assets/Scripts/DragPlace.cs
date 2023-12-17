using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragPlace : MonoBehaviour, IDropHandler
{
    public GameObject items;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(items);
        if (!items)
        {
            Debug.Log("entra");
            items = Draghandler.itemDragging;
            items.transform.SetParent(transform);
            items.transform.position=transform.position;
            if (items.gameObject.name == "Alfombra")
            {

            }
            else
            {
                CordobaScenenManager.instance.monedas[2] = false;
                CordobaScenenManager.instance.addMoneda();
            }
            
        }
    }

    

    // Update is called once per frame
    void Update()
    {
      
        if (items!=null && items.transform.parent != transform)
        {
            items=null;
        }
        
    }
}
