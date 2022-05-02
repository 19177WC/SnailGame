using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCode : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Move Vehicle Forward
        // Vector*Time*Meters per second
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}