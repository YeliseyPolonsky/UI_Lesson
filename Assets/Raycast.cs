using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Transform pointer;
    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        Debug.DrawRay(Camera.main.transform.position, Input.mousePosition * 100, Color.yellow);

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit))
        {
            pointer.position = hit.point;

            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
                selectable.Select();
        }
            
    }
}
