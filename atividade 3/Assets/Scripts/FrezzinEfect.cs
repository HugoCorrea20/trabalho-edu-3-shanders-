using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrezzinEfect : MonoBehaviour
{
    public Material frozenMaterial;
    private Material originalMaterial;
    private float freezeInterpolationTime = 0.1f;
    private float freezeTime = 2.0f;
    private bool isFrozen = false;

     void Start()
    {
        originalMaterial = GetComponent<Renderer>().material;
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFrozen = !isFrozen;
            freezeTime = 2.0f;
        }

        if (isFrozen)
        {
            if (freezeTime > 0)
            {
                freezeTime -= Time.deltaTime;
            }
        }
        else
        {
            isFrozen = false;
            freezeInterpolationTime = 0.2f;
            GetComponent<Renderer>().material = originalMaterial;
        }
    }
}
