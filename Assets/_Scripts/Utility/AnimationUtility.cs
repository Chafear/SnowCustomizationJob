using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUtility : MonoBehaviour
{
    public void Animate(GameObject gameObject, float smoothTime, Vector3 offset, float delay = 0)
    {
        StartCoroutine(Entry(gameObject, smoothTime, offset,delay));
    }

    IEnumerator Entry(GameObject gameObjectToAnimate, float smoothTime,Vector3 offset,float delay)
    {
        Vector3 velocity = Vector3.zero;
        Vector3 targetPosition = gameObjectToAnimate.transform.position;
        gameObjectToAnimate.transform.position +=offset;

        yield return new WaitForSeconds(delay);

        while (gameObjectToAnimate.transform.position != targetPosition)
        {
            gameObjectToAnimate.transform.position = Vector3.SmoothDamp(gameObjectToAnimate.transform.position, 
                                                                        targetPosition, 
                                                                        ref velocity, 
                                                                        smoothTime);
            yield return new WaitForEndOfFrame();
        }
    }

}
