using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    public float turnSpeed = 100.0f;
    
    private float h;
    private float v;

    private void Update()
    {
        h = Input.GetAxis("Horizontal");  // -1.0f ~ 1.0f
        v = Input.GetAxis("Vertical");     // -1.0f ~ 1.0f

        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * v);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * h);
    }
}