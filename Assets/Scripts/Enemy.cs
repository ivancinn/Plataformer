using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform playerTransform;
    private UnityEngine.AI.NavMeshAgent nav;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = playerTransform.position;
    }
}
