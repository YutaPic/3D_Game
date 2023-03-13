using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlastSphereController : MonoBehaviour
{
    /*
    public bool probed = false;
    public Vector3 pos = Vector3.zero;
    */
    private Vector3 scale = Vector3.zero;
    public float speed;
    public float duration;
    private Vector3 ein = new Vector3(1.0f,1.0f,1.0f);


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = scale;

        StartCoroutine(DelayCoroutine(duration, () => {
            DestroySelf();
        }));
    }

    // Update is called once per frame
    void Update()
    {
        scale += speed * ein;
        transform.localScale = scale;
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
}
