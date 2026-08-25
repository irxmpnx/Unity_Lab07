using UnityEngine;

public class KinematicMover : MonoBehaviour
{
    public float speed = 2f;
    public float range = 2f;
    private Rigidbody rb;
    private Vector3 startPos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = rb.position;
    }
    void FixedUpdate()
    {
        float offset = Mathf.PingPong(Time.time * speed, range * 2) - range;
        rb.MovePosition(startPos + new Vector3(offset, 0, 0));
    }
}