using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Vector3 goal; // The point to move towards
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    public float aceleracionSubida = 0.5f;

    void Update()
    {
        this.transform.Translate(goal * Time.deltaTime);
        goal.y += aceleracionSubida * Time.deltaTime;  
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(goal, 0.5f);
    }
}
