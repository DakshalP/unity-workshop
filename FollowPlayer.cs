using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // the position of the player
    public Transform playerTransform;
    
    //how much you want to offset the camera by in 3D space
    public Vector3 offset = new Vector3(0f, 2f, -5f);

    void Update() {
        //if you want it to always follow
        //transform.position = playerTransform.position + offset;

        //follow, but stop at a certain point so you can see pins falling
        if(transform.position.z < 15) transform.position = playerTransform.position + offset;
    }
}
