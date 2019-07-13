using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float gameForce = 400f;
    public float movSpeed = 400f;
    public float jumpForce = 5;
    public bool isGrounded;
    public int jumps = 2;
    // Update is called once per frame
       void Start()
    {
        rb = GetComponent<Rigidbody>();
    }   
        void OnCollisionEnter()
     {
         isGrounded = true;
      }
        void OnCollisionEnter (Collision collisionInfo)
        {
            if (collisionInfo.gameObject.name == ("Floor") && isGrounded == false)
            {
              isGrounded = true;
            }
        }
    void Update()
    {
        rb.AddForce (0, 0, gameForce * Time.deltaTime, ForceMode.VelocityChange);

               if(Input.GetKey("a"))
       {
                      rb.AddForce (-movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

               if(Input.GetKey("d"))
       {
                      rb.AddForce (movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }



                      if(Input.GetKey("w") && isGrounded)
       {
                      rb.AddForce (0, jumpForce * Time.deltaTime * 100, 0, ForceMode.Impulse);
                      isGrounded = false;
       }
        }

     }