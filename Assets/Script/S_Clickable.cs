
using UnityEngine;
public class Clickable : MonoBehaviour
{
    public Membre_Stat self;
    public S_TurnBase _interaction;

    SpriteRenderer sprite;

    void Start()
    {
        // sprite = GetComponent<SpriteRenderer>();

        // sprite.sprite = self.sprite;

        

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