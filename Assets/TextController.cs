using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI text;
 

    void Update()
    {
        HammerManager hammerManager = FindObjectOfType<HammerManager>();


        text.text = hammerManager.handSpeed.ToString();
    }
}
