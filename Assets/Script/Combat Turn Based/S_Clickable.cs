
using UnityEngine;
public class Clickable : MonoBehaviour
{


    public GameObject self;
    void Update()
    {
        
    }

    //Agrandie lorsque souris dessus
    void OnMouseEnter()
    {
        self.transform.localScale = self.transform.localScale * 1.1f;
    }

    //Rétrécie lorsque souris dessus
    void OnMouseExit()
    {
        self.transform.localScale = self.transform.localScale / 1.1f;
    }

}