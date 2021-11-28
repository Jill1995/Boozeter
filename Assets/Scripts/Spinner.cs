using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        float xAng = xAngle * Time.deltaTime;
        float yAng = yAngle * Time.deltaTime;
        float zAng = zAngle * Time.deltaTime;
        transform.Rotate(xAng, yAng, zAng);
    }
}
