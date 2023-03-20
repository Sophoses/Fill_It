using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidePunchController : MonoBehaviour
{
    public static bool punchLock = false;
    public GameObject punchFX; //HJ
    Rigidbody rb; //HJ


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); //HJ

    }


    private void OnCollisionEnter(Collision other)
    {
        if (punchLock)
        {
            if (other.gameObject.CompareTag("bear") || other.gameObject.CompareTag("bug"))
            {
                punchFX.GetComponent<ParticleSystem>().Play(); //HJ

            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (this.gameObject.CompareTag("bear") || this.gameObject.CompareTag("bug"))
        {
            punchFX.GetComponent<ParticleSystem>().Stop(); //HJ
        }
    }
}
