using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*
    test code: 
    (just to learn, don't put this in the final game)

    //runs once
    void Start() {
        Debug.Log("Hello World");
    }

    //runs every frame
    void Update() {
        if(Input.GetKey("a")) {
            Debug.Log("You pressed A");
        }
    }

    */

   //game code
   public Rigidbody rb;
   public float thrust = 20.0f;
   public float sidewaysThrust = 400.0f;

   public bool spacePressed = false;

   void Update () {
       if(Input.GetKeyDown("space")) {
           spacePressed = true;
       }

       //step 5
       if(gameObject.transform.position.y < -50) {
           FindObjectOfType<GameManager>().EndGame();
       }
   }

   //also called once per frame, but adjusts for different framerates
   void FixedUpdate() {
       if(spacePressed) {
           rb.AddForce(0, 0, thrust * Time.deltaTime, ForceMode.Acceleration);
       } else {
           if(Input.GetKey("d")) {
                rb.AddForce(sidewaysThrust * Time.deltaTime, 0, 0);
            }
            else if(Input.GetKey("a")) {
                rb.AddForce(-sidewaysThrust * Time.deltaTime, 0, 0);
            }
       }
       
   }
}
