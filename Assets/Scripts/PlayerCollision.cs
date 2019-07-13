using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
        public Rigidbody rb;
        public PlayerMovement movement;

        void start(){
        rb = GetComponent<Rigidbody>();
         }

        void OnCollisionEnter (Collision collisionInfo)
        {
            if (collisionInfo.gameObject.name == "Obstacle")
            {
                rb.velocity = new Vector3(0, 0, 0);
                transform.position = new Vector3(0,1,1);
            
            }
        }
}
