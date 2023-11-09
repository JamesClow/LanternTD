using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Camera cam;
    public UnityEngine.AI.NavMeshAgent agent;

    // Update is called once per frame
    void Start()
    {
        agent.SetDestination(HomeBase.getInstance().transform.position);
    }
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //         RaycastHit hit;

    //         if (Physics.Raycast(ray, out hit))
    //         {
    //             agent.SetDestination(hit.point);
    //         }
    //     }
    // }
}
