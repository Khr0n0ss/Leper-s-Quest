using UnityEngine;

public class S_TurnBase : MonoBehaviour
{
    public bool isPlayerTurn;

    void Start()
    {
        bool isPlayerTurn = Random.value < 0.5f;
        Debug.Log(isPlayerTurn);
    }
}
