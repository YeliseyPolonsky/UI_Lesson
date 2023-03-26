using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameNick : MonoBehaviour
{
    public string Name;
    [SerializeField] private TextMeshProUGUI _name;

    private void OnGUI()
    {
        Name = GUI.TextArea(new Rect(Screen.width/2 - Screen.width / 16, Screen.height / 2, Screen.width / 8,30),Name,10);
        _name.text = Name;
    }
}
