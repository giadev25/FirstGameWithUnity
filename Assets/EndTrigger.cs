using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            gameManager.completeLevel();
        }
    }

}
