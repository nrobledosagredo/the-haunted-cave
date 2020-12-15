using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlayerController : MonoBehaviour
{
    private Animator anim;
    public Transform conextPosition;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (ver > 0f)
        {
            anim.SetBool("FW", true);
            anim.SetBool("BW", false);
            anim.SetBool("RW", false);
            anim.SetBool("LW", false);
        }
        else if (ver < 0f)
        {
            anim.SetBool("BW", true);
            anim.SetBool("FW", false);
            anim.SetBool("RW", false);
            anim.SetBool("LW", false);
        }
        else if (hor > 0f)
        {
            anim.SetBool("RW", true);
            anim.SetBool("FW", false);
            anim.SetBool("BW", false);
            anim.SetBool("LW", false);
        }
        else if (hor < 0f)
        {
            anim.SetBool("LW", true);
            anim.SetBool("FW", false);
            anim.SetBool("BW", false);
            anim.SetBool("RW", false);
        }
        else
        {
            anim.SetBool("FW", false);
            anim.SetBool("BW", false);
            anim.SetBool("RW", false);
            anim.SetBool("LW", false);
        }
    }
}
