using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //for NavMeshAgent

public class CubeScript : MonoBehaviour
{
    private NavMeshAgent nma = null;

    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            // a line from the eye of the camera to the point of the scene where mouseclicked
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // convert that ray into a vector3 position in the scene
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) == true)
            {
                // command the navmeshagent to start movemebt to that point
                nma.SetDestination(hit.point);
            }
        }
    }
}