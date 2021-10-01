using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public float rotSpeed = 30;
    public Transform player;    

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying){
            // Task 1
            // Put code here to draw the gizmos
            // Use sin and cos to calculate the positions of the waypoints 
            // You can draw gizmos using
            // Gizmos.color = Color.green;
            // Gizmos.DrawWireSphere(pos, 1);

            Vector3 gizmoPos;
            Gizmos.color = Color.green;

            // rotation translation calculator for gismos;
            float theta = (Mathf.PI * 2.0f / numWaypoints); 
            for(int i = 0; i < numWaypoints; i++){

                // Translation math
                gizmoPos =  new Vector3(Mathf.Cos(i*theta)*10,0,Mathf.Sin(i*theta)*10);
                gizmoPos = gizmoPos + this.transform.position;
                
                // Adding the gizmos
                Gizmos.color = Color.green; 
                Gizmos.DrawWireSphere(gizmoPos,2);

                
            }
            

        }
    }

    // Use this for initialization
    void Awake () {
        // Task 2
        // Put code here to calculate the waypoints in a loop and 
        // Add them to the waypoints List
        Vector3 gizmoPos;
        Gizmos.color = Color.green;

        // rotation translation calculator for gismos;
        float theta = (Mathf.PI * 2.0f / numWaypoints); 
        for(int i = 0; i < numWaypoints; i++){

            // Translation math
            gizmoPos =  new Vector3(Mathf.Cos(i*theta)*10,0,Mathf.Sin(i*theta)*10);
            gizmoPos = gizmoPos + this.transform.position;

            // Adding position to list
            waypoints.Add(gizmoPos);
        }
    }

    // Update is called once per frame
    void Update () {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one
        
        //localise position of gizmo
        
        //1. translate calculation to origin.
        Vector3 translatedPoint = waypoint[current] - this.transform.position;

        float angleToGizmo = translatedPoint.y
        


        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
        

        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
    }
}
