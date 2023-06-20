using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BulletManager : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    //public GameObject sound;
    public float fireSpeed = 200;
    public GameObject impactPrefab;



    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }


    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        spawnedBullet.transform.position = spawnPoint.position;
        this.GetComponent<AudioSource>().Play();
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        
        Destroy(spawnedBullet,1);
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ShootTarget"))
        {
            var explosion = Instantiate(impactPrefab, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            ParticleSystem ps = explosion.GetComponent<ParticleSystem>();
            var main = ps.main;


        }
    }


}
