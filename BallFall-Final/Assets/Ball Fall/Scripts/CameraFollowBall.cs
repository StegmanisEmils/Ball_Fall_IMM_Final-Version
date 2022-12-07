using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public Transform followBall;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.transform.position.y > 23.6)
        {
            //Keeps existing distant between Camera and Ball while updating the Y position as ball falls. (Offset by 5 to keep ball higher on screen.)
            this.transform.position = new Vector3(this.transform.position.x, followBall.position.y - 5, followBall.position.z - 10);
        }
    }
}