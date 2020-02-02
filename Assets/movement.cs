using UnityEngine;
using System.Collections.Generic;

public class movement : MonoBehaviour
{

    public List<GameObject> goList;
    public float MovementSpeed;
    public GameObject zombie;
    public float spawn_speed;

    void Start()
    {
        goList = new List<GameObject>();
    }

    void Update()
    {
        spawn_speed -= Time.deltaTime;
        Vector3 direction = CalculateDirection();
        transform.Translate(direction * MovementSpeed * Time.deltaTime);
        if (spawn_speed <= 0f && goList.Count < 5)
        {
            int rnd = Random.Range(1, 5);
            Vector3 rndPos1 = new Vector3(-6, 0, 0);
            Vector3 rndPos2 = new Vector3(4, 0, 0);
            Vector3 rndPos3 = new Vector3(0, -4, 0);
            Vector3 rndPos4 = new Vector3(0, 4, 0);
            if (rnd == 1)
            {
                goList.Add((GameObject)Instantiate(zombie, rndPos1, Quaternion.identity));
            }
            else if (rnd == 2)
            {
                goList.Add((GameObject)Instantiate(zombie, rndPos2, Quaternion.identity));
            }
            else if (rnd == 3)
            {
                goList.Add((GameObject)Instantiate(zombie, rndPos3, Quaternion.identity));
            }
            else if (rnd == 4)
            {
                goList.Add((GameObject)Instantiate(zombie, rndPos4, Quaternion.identity));
            }
            spawn_speed = 5f;
        }
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