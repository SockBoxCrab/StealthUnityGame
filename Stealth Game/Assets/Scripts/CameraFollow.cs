using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerForm;

    private float yOffset = 4.25f;//Used to keep camera certain distance away
    private float zOffset = -7.5f;//from the player as they move

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        float posX = playerForm.position.x;
        float posY = playerForm.position.y + yOffset;
        float posZ = playerForm.position.z + zOffset;
        Vector3 pos = new Vector3(posX, posY, posZ);
        gameObject.transform.position = pos;
    }
}
