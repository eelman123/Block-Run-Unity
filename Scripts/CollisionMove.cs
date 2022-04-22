using UnityEngine;

public class CollisionMove : MonoBehaviour
{
    public Movement playerMovement;



    Animator anim;

    void Start () 
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collisionInfo) 
    {
        // Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            // Play animation
            anim.SetTrigger("TurnBlack");
            FindObjectOfType<GameManager>().EndGame();


        } else if (collisionInfo.collider.tag == "Finish")
        {
            playerMovement.enabled = false;
            anim.SetTrigger("TurnGreen");
            FindObjectOfType<GameManager>().WinLevel();

        }
        
    }
}
