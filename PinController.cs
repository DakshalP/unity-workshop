using UnityEngine;

public class PinController : MonoBehaviour
{
    Transform t;

    bool pinChecked = false;

    void Start() {
        t = GetComponent<Transform>();
    }

    void OnCollisionEnter(Collision collision) {
        //if it hits anything other than the ground
        if(collision.gameObject.name != "Ground") {
            //PinHit()

            //wait 2 seconds to allow it to tip
            Invoke("PinHit", 2);
        }
    }

    void PinHit() {
        if(pinChecked) {
            return;
        }

        pinChecked = true;

        //Debug.Log("Pin Hit")

        //check if tipped
        float currentRotation = t.rotation.eulerAngles.z;
        if( !(currentRotation < 10 || currentRotation > 350)) {

            Debug.Log("Tipped over");

        } else {

            Debug.Log("Not tipped over");

        }
    }
}
