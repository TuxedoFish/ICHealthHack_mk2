
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; //reference playerMovement script

    void OnCollisionEnter(Collision collisionInfo)
    {//check object we cllided with has tag obstacle
        if (collisionInfo.GetComponent<Collider>().tag == "obstacle")
        {
            movement.enabled = false; //Disables player movement

           
        }
    }
}
