using UnityEngine;
public class TransformMover : MonoBehaviour
{
    public float speed = 2f;
    public float range = 2f;
    private Vector3 startPos;
    void Start() => startPos = transform.position;
    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, range * 2) - range;
        transform.position = startPos + new Vector3(offset, 0, 0);
        
    }
}
