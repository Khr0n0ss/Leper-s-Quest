
using UnityEngine;
using UnityEngine.UI;
public class Clickable : MonoBehaviour
{
    public Membre_Stat self;
    private string name; 
    private string description;
    private int dégâts;
    private int PVMax;
    private Sprite sprite;


    void Start()
    {
        name = self.MembreName;

        description = self.Description;

        dégâts = self.dégâts;

        PVMax = self.PVMax;
        
        sprite = self.sprite;
    }

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