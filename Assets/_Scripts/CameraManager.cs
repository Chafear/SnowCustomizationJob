using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Entry());
    }


    IEnumerator Entry()
    {
        float smoothTime = 1f;

        Vector3 velocity = Vector3.zero;
        Vector3 targetPosition = transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);

        while (transform.position!=targetPosition)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            yield return new WaitForFixedUpdate();
        }
    }
}
