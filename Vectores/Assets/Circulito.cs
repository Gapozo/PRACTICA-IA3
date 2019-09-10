using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulito : MonoBehaviour
{

public float Radius = 1;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
