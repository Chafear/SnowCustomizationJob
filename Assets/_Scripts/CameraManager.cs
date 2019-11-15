using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(Entry());
        var cam = Camera.main.gameObject;
        GetComponent<AnimationUtility>().Animate(cam, 1f, new Vector3(0, 10f, 0));
    }
    /*
    IEnumerator Entry()
    {
        float smoothTime = 1f;

        Vector3 velocity = Vector3.zero;
        Vector3 targetPosition = transform.position;
        Vector3 v = new Vector3(0, 10f, 0);
        //transform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
        transform.position += v;
        while (transform.position != targetPosition)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            yield return new WaitForFixedUpdate();
        }
    }*/
}
