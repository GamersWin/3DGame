using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFPS : MonoBehaviour
{
    public float speed = 0.25f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX, 0, deltaZ);
    }
}
