using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidLauncher : MonoBehaviour
{
    public GameObject ballPrefab;
    public float speed;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            PlayerStatus playerStatus = player.GetComponent<PlayerStatus>();
            if (playerStatus.state == PlayerStatus.State.Asteroid){
                GameObject asteroid = (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
                Rigidbody ballRb = asteroid.GetComponent<Rigidbody>();
                ballRb.AddForce(transform.forward * speed);

                playerStatus.hp -= Parameters.asteroid_cost;
            }
        }
    }
}
