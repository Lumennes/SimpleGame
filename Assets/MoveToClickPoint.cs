// MoveToClickPoint.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveToClickPoint : MonoBehaviour
{
    NavMeshAgent agent;
    Transform _transform;

    void Start()
    {
        _transform = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }            
        }

        if(agent.remainingDistance < agent.stoppingDistance)
        {
            agent.destination = _transform.position;
        }
    }
}