using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    Rigidbody rb;
    //bool kmatic = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
           // kmatic = true;

        }
        else
            rb.isKinematic = false;

        if (other.gameObject.CompareTag("Table"))
        {

            rb = GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            //freeze = true;
        }

        //if (other.gameObject.CompareTag("Hand")&& kmatic==true )
        //{
        //    rb = GetComponent<Rigidbody>();
        //    rb.isKinematic = false;     
        //    kmatic = false;
        //}
    }

}
