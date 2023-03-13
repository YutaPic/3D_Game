using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoundLauncher : MonoBehaviour
{
    public GameObject houndPrefab;
    public GameObject MeteoraPrefab;
    public float speed;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            PlayerStatus playerStatus = player.GetComponent<PlayerStatus>();
            if (playerStatus.state == PlayerStatus.State.Hound){
                GameObject hound = (GameObject)Instantiate(houndPrefab, transform.position, Quaternion.identity);
                Rigidbody houndRb = hound.GetComponent<Rigidbody>();
                houndRb.AddForce(transform.forward * speed);

                playerStatus.hp -= Parameters.hound_cost;
            }
            if (playerStatus.state == PlayerStatus.State.Meteora){
                GameObject meteora = (GameObject)Instantiate(MeteoraPrefab, transform.position, Quaternion.identity);
                Rigidbody meteoraRb = meteora.GetComponent<Rigidbody>();
                meteoraRb.AddForce(transform.forward * speed);

                playerStatus.hp -= Parameters.hound_cost;
            }
        }
    }
}
