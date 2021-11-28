using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updown : MonoBehaviour
{

    [SerializeField] public float speed = 1;
    [SerializeField] float adjust = 0;
    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 4) + adjust;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
