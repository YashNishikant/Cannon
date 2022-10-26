using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateLand : MonoBehaviour
{

    [SerializeField] private List<GameObject> items;
    [SerializeField] private float number;

    void Start()
    {
        spawn(240);
    }

    void spawn(int rad) {
        for (int i = 0; i < number; i++)
        {
            if(transform.rotation.y < 1) { 
                Instantiate(items[Random.Range(0, items.Count)], transform.position + transform.forward * rad, Quaternion.identity);
                transform.Rotate(0, 3, 0);
            }
        }
    }

}