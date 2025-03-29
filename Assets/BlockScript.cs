using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collion)
    {
        if (collion.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }



}
