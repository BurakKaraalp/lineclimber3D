using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if(transform.position == new Vector3(0, 0, 0))
        {
            transform.position = new Vector3(0, -0.45f, 0);
        } 
       if(transform.gameObject.tag == "Homeroad")
        {
            transform.position = new Vector3(0, -0.37f, 0);
        }
    }
   
}
