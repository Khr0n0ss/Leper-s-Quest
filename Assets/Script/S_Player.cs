using UnityEngine;
using UnityEngine.UI;

public class S_Player : MonoBehaviour
{
    public Button _AtkButton;

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
            CanAttack();
        }
    }

    public void CanAttack()
    {
        if (_AtkButton.interactable)
        {
            _AtkButton.interactable = false;
        }
        else
        {
            _AtkButton.interactable = true;
        }
    }
}
