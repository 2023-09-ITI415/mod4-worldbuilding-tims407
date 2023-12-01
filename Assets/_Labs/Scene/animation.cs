using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator anim;
    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hdirection;
        float vdirection;
        hdirection = Input.GetAxis("Horizontal");
        vdirection = Input.GetAxis("vertical");

        if (hdirection > 0)
        {
            anim.SetInteger("Direction", 1); // layer or number of paremetersvc
        }
        if (hdirection < 0)
        {
            anim.SetInteger("Direction", 3);
        }
        if (vdirection > 0)
        {
            anim.SetInteger("Direction", 0);
        }
        if (vdirection < 0)
        {
            anim.SetInteger("Direction", 2);
        }
    }
}
