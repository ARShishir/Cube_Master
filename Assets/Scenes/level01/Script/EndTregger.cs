using UnityEngine;

public class EndTregger : MonoBehaviour
{
    public GameManager gameManager; 

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }
}
