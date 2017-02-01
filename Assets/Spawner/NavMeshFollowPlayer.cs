// MoveTo.cs
using UnityEngine;
using System.Collections;

public class NavMeshFollowPlayer : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    void Start()
    { 
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = target.position;
    }
}
