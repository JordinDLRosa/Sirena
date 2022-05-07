using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{

    public Transform camTarget;
    public Transform cam;
    public float pLerp = .02f;
    public float rLerp = .01f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, Time.deltaTime * 2);
        transform.rotation = Quaternion.Slerp(transform.rotation, cam.rotation, Time.deltaTime * 2);
    }
}
