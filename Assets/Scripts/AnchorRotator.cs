using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorRotator : MonoBehaviour
{
    public GameObject Target;
    public float maxAngle = 20;
    public void OnEnable()
    {
        Target = GameObject.Find("Main Camera");

    }
    public void Update()
    {
        var Forward = gameObject.transform.forward;
        var TargetVec = Target.transform.position - gameObject.transform.position;
        float angle = Vector3.SignedAngle(TargetVec, Forward, Vector3.up);
        if (angle > maxAngle || angle < -maxAngle)
        gameObject.transform.Rotate(new Vector3(0, angle, 0));
        print(angle);
    }
}
