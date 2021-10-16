using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Transform.Rotate example
    //
    // This script creates two different cubes: one red which is rotated using Space.Self; one green which is rotated using Space.World.
    // Add it onto any GameObject in a scene and hit play to see it run. The rotation is controlled using xAngle, yAngle and zAngle, modifiable on the inspector.


    public float rate = 10f;

    void Awake()
    {
        var tmp = gameObject.GetComponent<Renderer>();
        tmp.material.SetColor("_Color", Color.red);
    }

    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward, rate*Time.deltaTime);
    }
}