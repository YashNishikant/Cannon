using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    float time = 0;

    void Update()
    {

        time += Time.deltaTime;

        if (time > 10)
            Destroy(this.gameObject);
    }
}
