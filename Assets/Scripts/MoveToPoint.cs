using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveToPoint : MonoBehaviour
{
    public Transform goal; // The point to move towards
    [SerializeField] public float speed = 1f; 
    private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float accuracy = 0.01f; // How close the object needs to be to the goal to consider it "reached"

    private void Start()
    {
       // waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    }
    void Update()
    {
        // this.transform.Translate(goal);
        // goal = goal  *0.5f;
        //this.transform.Translate(goal * Time.deltaTime);
        //goal.y += aceleracionSubida * Time.deltaTime;
        //
       //if (waypoints.Length == 0) return; // If there are no waypoints, exit the method

        //goal = waypoints[currentWaypointIndex].transform; // Set the goal to the first waypoint
        float currentspeed = speed;
        Vector3 direction = (goal.position - this.transform.position);
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, Time.deltaTime);
        if (Keyboard.current.spaceKey.isPressed) 
            
            currentspeed = speed*2;
            
        else speed = speed;
        //7a. if(direction.magnitude > accuracy)
        //7b. if (Vector3.Distance(this.transform.position, goal.position) > accuracy)
        //this.transform.Translate(Vector3.forward * currentspeed * Time.deltaTime);
        //this.transform.Translate(direction.normalized * currentspeed*Time.deltaTime, Space.World);
        this.transform.position = Vector3.MoveTowards(this.transform.position, goal.position, currentspeed * Time.deltaTime);
       // if (Vector3.Distance(this.transform.position, goal.position) < accuracy)
       // {
       //     currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Move to the next waypoint
       // }
       Debug.DrawRay(this.transform.position, Vector3.forward, Color.red);
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(goal.position, 0.5f);
    }
}
