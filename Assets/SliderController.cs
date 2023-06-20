using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;


    void Update()
    {

        HammerManager hammerManager = FindObjectOfType<HammerManager>();
        slider.value = hammerManager.handSpeed;
        //StartCoroutine(Waiting());

    }




    //public IEnumerator Waiting()
    //{
    //    yield return new WaitForSeconds(3);
    //    slider.value = 0;
    //}
}
