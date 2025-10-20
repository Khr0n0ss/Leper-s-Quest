using UnityEngine;

[System.Serializable]
public struct Statistique
{
    public string name;
    public float degat;
    public float pv;
    public int necrose;
}

public class S_Statistique : MonoBehaviour
{
    public Statistique stat;
}
