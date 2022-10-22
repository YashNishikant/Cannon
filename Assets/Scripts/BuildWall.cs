using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : MonoBehaviour
{

    [SerializeField] private GameObject wallcube;
    float x;
    float y;
    float z;
    float startz;

    void Start()
    {
        x = transform.position.x;
        startz = transform.position.z;
        z = transform.position.z;
        y = 1;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(wallcube, new Vector3(x, y, z), Quaternion.identity);
                z += 5;
            }
            y += 5;
            z = startz;
        }
    }
}


