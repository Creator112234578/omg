using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshing : MonoBehaviour
{
    [SerializeField] public Transform Scout;
    private NavMeshAgent Heavy;
    
    void Start()
    {
        Heavy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Heavy.destination = Scout.position;
    }
}
