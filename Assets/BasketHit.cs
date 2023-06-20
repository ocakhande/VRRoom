using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketHit : MonoBehaviour
{
    public int counter = 0;
    public GameObject explosionPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            OnBasketHit(other);
        }
    }

    public void OnBasketHit(Collider other)
    {
        var explosion = Instantiate(explosionPrefab, other.gameObject.transform.position, other.gameObject.transform.rotation);
        ParticleSystem ps = explosion.GetComponent<ParticleSystem>();
        var main = ps.main;
        counter++;
    }
}
