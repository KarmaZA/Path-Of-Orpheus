using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
//using UnityEngine.UI;


public class HoverTimer : MonoBehaviour
{
    public Collider sphere;
    public int waitTime;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        
    }

    // Update is called once per frame
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(waitTime);
        sphere.attachedRigidbody.useGravity =true;

    }
}
