using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HammerManager : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float handSpeed = 0f;
    bool hitTarget = false;


    void Update()
    {
        if (XRSettings.enabled)
        {
            InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
            if (device.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity))
            {
                if (hitTarget == true)
                {
                    handSpeed = velocity.magnitude;
                    hitTarget = false;

                }

            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("hammerTarget"))
        {
            hitTarget = true;
            Debug.Log("El Hýzý: " + handSpeed);
            var explosion = Instantiate(explosionPrefab, other.gameObject.transform.position, other.gameObject.transform.rotation);
            ParticleSystem ps = explosion.GetComponent<ParticleSystem>();
            var main = ps.main;

        }

    }
}

