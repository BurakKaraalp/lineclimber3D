using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAnimatorController : MonoBehaviour
{
    public Animator animator;
    public float animationSpeed;
    void Start()
    {
        animator.speed = animationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
