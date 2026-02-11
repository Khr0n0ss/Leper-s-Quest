using UnityEngine;

[CreateAssetMenu(fileName = "Membre", menuName = "Scriptable Objects/Membre")]
public class Membre_Stat : ScriptableObject
{
    public string MembreName;
    public string Description;
    public int dégâts;
    public int PVMax;
    public Sprite sprite;
    private bool isNain;
}
