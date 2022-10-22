using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField] private float rotatespeed;
    [SerializeField] private GameObject barrel;
    [SerializeField] private ParticleSystem muzzleflash;
    [SerializeField] private List<GameObject> animals;
    [SerializeField] private bool rapidfire;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotatespeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            barrel.transform.Rotate(-rotatespeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            barrel.transform.Rotate(rotatespeed * Time.deltaTime, 0, 0);
        }

        if (rapidfire)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject p = Instantiate(animals[Random.Range(0, 3)], barrel.transform.position + barrel.transform.forward * 4, Quaternion.identity);
                p.GetComponent<Rigidbody>().AddRelativeForce(barrel.transform.forward * 100, ForceMode.Impulse);

                ParticleSystem s = Instantiate(muzzleflash, barrel.transform.position + barrel.transform.forward * 4, Quaternion.Euler(-90, 0, 0));
                s.Play();
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject p = Instantiate(animals[Random.Range(0, 3)], barrel.transform.position + barrel.transform.forward * 4, Quaternion.identity);
                p.GetComponent<Rigidbody>().AddRelativeForce(barrel.transform.forward * 100, ForceMode.Impulse);

                ParticleSystem s = Instantiate(muzzleflash, barrel.transform.position + barrel.transform.forward * 4, Quaternion.Euler(-90, 0, 0));
                s.Play();
            }
        }
        if (barrel.transform.rotation.eulerAngles.x < 30)
            barrel.transform.rotation = Quaternion.Euler(360, barrel.transform.rotation.eulerAngles.y, barrel.transform.rotation.eulerAngles.z);


    }
}



