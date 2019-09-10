using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour{

   [Range(1, 5)]
    [SerializeField]
    private int Radius = 1;
    private int Radius2;

      [SerializeField]
    private Transform Target;

    private bool IsEnter = false;

    //Agent
    Vector3 Velocity = Vector3.zero;
    Vector3 Desired = Vector3.zero;
    Vector3 Steer = Vector3.zero;
    float maxSpeed = 5;
    float maxSteer = 5;

    //...
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("target").transform;

        //desired
        Desired = -(target.position - transform.position).normalized * maxSpeed;
        //steer
        Steer = Vector3.ClampMagnitude(Desired - Velocity, maxSteer);
        Velocity += Steer * Time.deltaTime;
        transform.position += Velocity * Time.deltaTime;



        //mitad del radio
        float distance = (Target.position - transform.position).magnitude;
        if(distance <= Radius)
        {
            if (!IsEnter)
            {
                IsEnter = true;
                print("Entró");// sumar mate
                Destroy(gameObject);
            }
            print("Adentro");
        }
        else
        {
            if (IsEnter)
            {
                IsEnter = false;
                print("Afuera");
            }
        }

         if(transform.position.y <-9){
            Destroy(gameObject);
        }
        
        if(transform.position.y > 9){
                 Destroy(gameObject);
        }

        if(transform.position.x < -12){
                 Destroy(gameObject);
        }

        if(transform.position.x > 12){
                  Destroy(gameObject);
        }
    }

     private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
