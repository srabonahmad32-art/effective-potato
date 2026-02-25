using UnityEngine;
using UnityEngine.AI;

public class GrannyAI : MonoBehaviour
{
    public GrannyState currentState;
    public Transform player;
    public Transform[] patrolPoints;

    private NavMeshAgent agent;
    private int patrolIndex;

    public float sightRange = 12f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentState = GrannyState.Patrol;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case GrannyState.Idle:
                break;

            case GrannyState.Patrol:
                Patrol();
                if (distance < sightRange)
                    currentState = GrannyState.Chase;
                break;

            case GrannyState.Search:
                Search();
                break;

            case GrannyState.Chase:
                agent.SetDestination(player.position);
                if (distance > sightRange)
                    currentState = GrannyState.Search;
                break;
        }
    }

    void Patrol()
    {
        agent.SetDestination(patrolPoints[patrolIndex].position);

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            patrolIndex = (patrolIndex + 1) % patrolPoints.Length;
    }

    void Search()
    {
        agent.SetDestination(transform.position);
        currentState = GrannyState.Patrol;
    }
}