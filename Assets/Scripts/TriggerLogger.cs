using UnityEngine;
public class TriggerLogger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} triggered by {other.name}");
    }
}
