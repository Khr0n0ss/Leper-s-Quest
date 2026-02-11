
using UnityEngine;
public class Clickable : MonoBehaviour
{
    //Agrandie lorsque souris dessus
    void OnMouseEnter()
    {
        transform.localScale = transform.localScale * 1.1f;
    }

    //Rétrécie lorsque souris dessus
    void OnMouseExit()
    {
        transform.localScale = transform.localScale / 1.1f;
    }

}