using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragPlace : MonoBehaviour, IDropHandler
{
    public GameObject items;
    public void OnDrop(PointerEventData eventData)
    {
        if (!items)
        {
            items = Draghandler.itemDragging;
            items.transform.SetParent(transform);
            items.transform.position=transform.position;
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
