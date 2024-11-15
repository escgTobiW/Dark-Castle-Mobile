using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{

    public Transform[] points;
    private NavMeshAgent nav;
    private int destPoint;


    Animator anim;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    

    void FixedUpdate()
    {

        if (!nav.pathPending && nav.remainingDistance < 0.5f)
        {
            GoToNextPoint();
            anim.SetBool("fly", true);
        }
            
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }
        nav.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

}
