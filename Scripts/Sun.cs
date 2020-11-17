using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    float timeLeft = 25.0f;
    float timeToUpdate = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            if (timeToUpdate > 0)
            {
                transform.RotateAround(Vector3.zero, Vector3.right, 70f * Time.deltaTime);
                transform.LookAt(Vector3.zero);
                timeToUpdate -= Time.deltaTime;
            }
       
        }

    }
}
