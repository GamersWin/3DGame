using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDoorOpen : MonoBehaviour
{

    private Animator doorAnim;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }


    public void Open()
    {
        doorAnim.SetBool("ParOpen", true);
    }
    public void Close()
    {
        doorAnim.SetBool("ParOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
