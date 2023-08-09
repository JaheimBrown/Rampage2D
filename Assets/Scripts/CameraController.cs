using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private bool followPlayer = true;


    private void Update()
    {
        if(followPlayer && player)
        {
            transform.position = new Vector3(player.position.x, player.position.y + 1.85f, transform.position.z);
        }
    }

    public void CameraStopFollowing()
    {
        followPlayer = false;
    }

    public void ResumeCameraFollow()
    {
        followPlayer = true;
    }

}
