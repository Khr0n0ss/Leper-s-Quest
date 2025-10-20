using UnityEngine;


public class BattleSystemStateMachine
{
    public enum PerformAction {
        WAIT,
        TAKEACTION,
        PERFORMACTION,

    }
    public PerformAction battleStates;
    /* 
    public List<HandleTurn> PerformList = new List<HandlesTurn> (); // Liste des attaquants.
    public List<GameObject> HerosInBattle = new List<GameObject> (); // Liste des attacques du héros à faire
    public List<GameObject> EnemysInBattle = new List<GameObject> (); // List des enemies à faire
    */

    void Start() {
        battleStates = PerformAction.WAIT;
        /* EnemysInBattle.Add(GameObject.FindGameObjectWithTags("Enemy")); // Créer un GAME OBJECT ENEMY */

    }

    void Update() {
        
        switch (battleStates) 
        {
            case(PerformAction.WAIT) :

            break; 
            case(PerformAction.TAKEACTION) :
            
            break; 
            case(PerformAction.PERFORMACTION) :
            
            break; 
        }
    }
}
