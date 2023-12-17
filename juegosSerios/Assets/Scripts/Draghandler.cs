using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draghandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;//cada que hagamos drag se va a asignar esa variable
    Vector3 iniPos; //posicion inicial del objeto
    Transform startParent;//posicion inicial del otro objeto
    [SerializeField] Transform dragParent;
    void Start()
    {
        //   dragParent = ;//iguala el transform del parent a un objeto vacio

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //cuando empiece el drag
        itemDragging = gameObject;
        iniPos = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //mientras se hace el drag
        transform.position = Input.mousePosition;
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //cuando accaba el drag
        itemDragging = null;
        if(transform.parent == dragParent)//significa que nadie ha cambiado el parent y por lo tanto no es valida la posicion
        {
            transform.position = iniPos;
            transform.SetParent(startParent);

        }
    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
