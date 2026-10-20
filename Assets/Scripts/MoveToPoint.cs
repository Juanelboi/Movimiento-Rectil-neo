using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Transform goal; // The point to move towards
    public float speed = 1f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }


    void Update()
    {
        // this.transform.Translate(goal);
        // goal = goal  *0.5f;
        //this.transform.Translate(goal * Time.deltaTime);
        //goal.y += aceleracionSubida * Time.deltaTime;
        //
        this.transform.LookAt(goal.position);
        Vector3 direction = (goal.position - this.transform.position);
        this.transform.Translate(direction.normalized * speed*Time.deltaTime, Space.World);
        Debug.DrawRay(this.transform.position, direction, Color.red);
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(goal.position, 0.5f);
    }
}
