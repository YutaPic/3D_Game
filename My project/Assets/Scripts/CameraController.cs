using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 追従する物体
    public GameObject player;
    // 回転速度
    public float rotateSpeed = 0.1f;
    private Vector3 playerPosition; 
    private Vector3 playerAngle; 
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.transform.position;
        playerAngle = player.transform.eulerAngles;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /*
        float angle = Input.GetAxis("Horizontal") * rotateSpeed;
        // 追従
        transform.position += player.transform.position - playerPosition;
        playerPosition = player.transform.position;
        // 回転
        if (Input.GetKey(KeyCode.LeftShift)){
            transform.RotateAround(player.transform.position, Vector3.up, angle);
        }
        */

        // 追従
        transform.position += player.transform.position - playerPosition;
        playerPosition = player.transform.position;

        //回転
        //transform.eulerAngles += player.transform.eulerAngles - playerAngle;
        //playerAngle = player.transform.eulerAngles;
        //transform.RotateAround(player.transform.position, Vector3.up, playerAngle);
    }
}

