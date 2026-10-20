using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Vector3 goal; // The point to move towards
    private float speed = 1f; 
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
        this.transform.Translate(goal.normalized * speed*Time.deltaTime);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(goal, 0.5f);
    }
}
