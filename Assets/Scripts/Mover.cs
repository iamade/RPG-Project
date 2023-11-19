using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    // [SerializeField] Transform target;

    private GameObject destination;
    private NavMeshAgent agent;


    // Start is called
    // void Start()
    // {
    //     destination = GameObject.FindGameObjectWithTag("Destination");
    //     agent = GetComponent<NavMeshAgent>();
    //     agent.SetDestination(destination.transform.position);
    // }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
        UpdateAnimator();
        // Debug.DrawRay(lastRay.origin, lastRay.direction * 100);
    
        // agent.SetDestination(destination.transform.position);

        // GetComponent<NavMeshAgent>().destination = target.position;
    }

    private void MoveToCursor()
    {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    bool hasHit = Physics.Raycast(ray, out hit);
    if(hasHit)
    {
        GetComponent<NavMeshAgent>().destination = hit.point;
    }
    }

    private void UpdateAnimator() {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed =localVelocity.z;
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);
    }
}
