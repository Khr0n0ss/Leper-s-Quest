using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class S_TurnBase : MonoBehaviour
{
    public bool isPlayerTurn;
    public Button _nextButton;

    void Start()
    {
        bool isPlayerTurn = Random.value < 0.5f;
        //Debug.Log(isPlayerTurn);
        setStartInteraction(isPlayerTurn);
    }

    void setStartInteraction(bool value)
    {
        if(value) _nextButton.interactable = true;
        else
        {
            _nextButton.interactable = false;
            StartCoroutine(endTurn());
        }   
    }

    public IEnumerator endTurn()
    {
        FindAnyObjectByType<S_Player>().CanAttack();
        yield return new WaitForSeconds(2f);
        _nextButton.interactable = true;
    }
}
