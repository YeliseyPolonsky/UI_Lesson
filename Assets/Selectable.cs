using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void DisSelect()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }


}
