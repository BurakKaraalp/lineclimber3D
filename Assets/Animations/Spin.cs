using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    Quaternion myRotation = Quaternion.identity;
    public float speed = 5;
    float y = 0;
    void Update()
    {
        y += 1 * speed;
        myRotation.eulerAngles = new Vector3(0, y, 0);
        transform.rotation = myRotation;
    }
    
}
