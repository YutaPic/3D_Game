using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HoundController : MonoBehaviour
{
    public float duration = 10.0f;
    public float damage = 10.0f;
    //private float launch_time = 0.0f;
    //private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
    public ProbingSphereController psc;

    void Start()
    {
        StartCoroutine(DelayCoroutine(duration, () => {
            DestroySelf();
        }));
    }

    void Update()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody> ();
        //Debug.Log (rb.velocity.magnitude);
        //Debug.Log (rb.position);
        Vector3 force = Force2Enemy(rb.position, rb.velocity);
        rb.AddForce(force);
    }

    private void DestroySelf()
    {
        Destroy(this.gameObject);
    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player"){
            Destroy(this.gameObject);
        }
    }

    private Vector3 Force2Enemy(Vector3 pos, Vector3 vec)
    {
        const float lambda = 0.8f;
        if (psc.probed){
            Debug.Log(psc.pos);
            Vector3 dir = psc.pos - pos;
            return lambda * ((Vector3.Dot(vec, vec) / Vector3.Dot(vec, dir)) * dir - vec);
        }
        else{
            return Vector3.zero;
        }
    }
}
 