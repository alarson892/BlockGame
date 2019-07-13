using UnityEngine;

public class Ramp : MonoBehaviour
{
        public Rigidbody rb;
        public PlayerMovement movement;
        public float launchForce;

        void start(){
        rb = GetComponent<Rigidbody>();
         }

        void OnCollisionEnter (Collision collisionInfo)
        {
            if (collisionInfo.gameObject.name == "Ramp")
            {
                //rb.velocity = new Vector3(0, 0, 0);
                rb.velocity = new Vector3(0,launchForce,15);
            
            }
        }
}
