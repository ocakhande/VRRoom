using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitForceController : MonoBehaviour
{
    public Slider sliderObject;


    void Update()
    {

        SwordManager swordManager= FindObjectOfType<SwordManager>();
        sliderObject.value=swordManager.handSpeed;

    }



}
