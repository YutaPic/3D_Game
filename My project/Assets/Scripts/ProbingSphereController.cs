using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbingSphereController : MonoBehaviour
{
    public bool probed = false;
    public Vector3 pos = Vector3.zero;

    void OnTriggerStay(Collider collision){
        //Debug.Log(collision.gameObject.tag);
        GameObject target = collision.gameObject;
        if (target.tag == "Enemy"){
            probed = true;
            pos = collision.transform.position;
        }
    }
}
