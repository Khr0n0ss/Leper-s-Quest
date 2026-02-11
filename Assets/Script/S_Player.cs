using UnityEngine;
using UnityEngine.UI;

public class S_Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTurn(Button changeInteraction)
    {
        if(changeInteraction.interactable)
        {
            changeInteraction.interactable = false; 
            S_TurnBase _button = FindAnyObjectByType<S_TurnBase>();

            StartCoroutine(_button.endTurn());
        }
        else 
        {
            changeInteraction.interactable = true;
        }
    }
}
