
using UnityEngine;
public class Clickable : MonoBehaviour
{
    public ScriptableObject self;
    public S_TurnBase _interaction;

    void Start()
    {
        _interaction = FindAnyObjectByType<S_TurnBase>();
    }

    //Agrandie lorsque souris dessus
    void OnMouseEnter()
    {
        if(_interaction._nextButton.interactable)
            transform.localScale = transform.localScale * 1.1f;
    }

    //Rétrécie lorsque souris dessus
    void OnMouseExit()
    {
        if(_interaction._nextButton.interactable)
            transform.localScale = transform.localScale / 1.1f;
    }

}