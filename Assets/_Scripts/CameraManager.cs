using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 10f, 0);
    float smoothTime = 1f;

    void Start()
    {
        var cam = Camera.main.gameObject;
        GetComponent<AnimationUtility>().Animate(cam, smoothTime, offset);
    }

}
