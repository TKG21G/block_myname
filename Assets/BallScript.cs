using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * speed,
            ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
