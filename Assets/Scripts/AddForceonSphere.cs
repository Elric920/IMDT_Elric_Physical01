using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceonSphere : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(5000, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
