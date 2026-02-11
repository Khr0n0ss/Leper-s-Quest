using UnityEngine;

[CreateAssetMenu(fileName = "Membre", menuName = "Scriptable Objects/Membre")]
public class Membre_Script : ScriptableObject
{
    public string MembreName;
    public string Description;
    public int dégâts;
    public int PVMax;
    public Sprite sprite;
}
