using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetController : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("trion")){
            //gr.material.color = new Color(173, 255, 47);
            Destroy(this.gameObject);
        }
    }
    

    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log(collider.gameObject.tag);
        if (collider.gameObject.CompareTag("trion")){
            Destroy(this.gameObject);
        }
    }
}
