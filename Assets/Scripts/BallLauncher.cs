using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public Rigidbody ballPrefab;
    public float moveSpeed = 5f;
    public float force = 30f;

    void Update()
    {
        // Move green left/right
        float h = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(
            0f,
            0f,
            h * moveSpeed * Time.deltaTime
        );

        // Shoot slightly below green
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition =
                transform.position + Vector3.down * 0.2f;

            Rigidbody ball = Instantiate(
                ballPrefab,
                spawnPosition,
                Quaternion.identity
            );

            // Shoot LEFT
            ball.AddForce(
                Vector3.left * force,
                ForceMode.Impulse
            );
        }



    }
}
