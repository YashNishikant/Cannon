using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    [SerializeField] private List<GameObject> contents;
    [SerializeField] private float contentAmount;
    [SerializeField] private ParticleSystem psystem;

    private void OnCollisionEnter(Collision collision)
    {

        ParticleSystem p = Instantiate(psystem, transform.position, Quaternion.identity);
        p.Play();

        for (int i = 0; i < contentAmount; i++) {
            GameObject n = Instantiate(contents[Random.Range(0, 2)], transform.position, Quaternion.identity);
            n.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-100,100), Random.Range(-100, 100), Random.Range(-100, 100)), ForceMode.Impulse);
        }
        Destroy(this.gameObject);
    }

}
