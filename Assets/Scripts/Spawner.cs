using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject go;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(go, transform.position, transform.rotation);
        }
    }
}
