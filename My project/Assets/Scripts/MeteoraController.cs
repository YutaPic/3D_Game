using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MeteoraController : MonoBehaviour
{
    public GameObject blastPrefab;
    public float duration = 10.0f;
    public float damage = 10.0f;
    //private float launch_time = 0.0f;
    //private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start()
    {
        StartCoroutine(DelayCoroutine(duration, () => {
            Test();
        }));
    }

    private void Test()
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
            GameObject blastob = (GameObject)Instantiate(blastPrefab, transform.position, Quaternion.identity);
        }

    }
}
 