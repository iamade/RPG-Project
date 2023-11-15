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
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Destination");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.transform.position);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     GetComponent<NavMeshAgent>().destination = target.position;
    // }
}
