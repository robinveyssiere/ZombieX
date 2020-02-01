using UnityEngine;

public class movement : MonoBehaviour
{

    public float MovementSpeed;

    void Update()
    {
        Vector3 direction = CalculateDirection();
        transform.Translate(direction * MovementSpeed * Time.deltaTime);
    }

    public Vector3 CalculateDirection()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direction.y += 1.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direction.x -= 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction.y -= 1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direction.x += 1.0f;
        }
        return direction.normalized;
    }
}