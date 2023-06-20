using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Throwing"))
        {
            var smoke = Instantiate(explosionPrefab, other.gameObject.transform.position, other.gameObject.transform.rotation);
            ParticleSystem ps = smoke.GetComponent<ParticleSystem>();
            var main = ps.main;
        }
    }

}
