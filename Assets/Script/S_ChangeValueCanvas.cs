using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class S_ChangeValueCanvas : MonoBehaviour
{
    public List<TMP_Text> _txtMembre = new List<TMP_Text>();

    void Start()
    {
        changeText();
    }

    public void changeText()
    {
        foreach(TMP_Text _text in _txtMembre)
        {
            _text.text += " " + "3 / 3" ;
        }
    }
}
