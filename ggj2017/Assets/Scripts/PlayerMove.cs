using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;
    private string dir = "straight";
    void Start()
    {

    }

    public void Move()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (dir == "up")
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        if (dir == "down")
            transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if (dir == "up")
            {
                dir = "down";
            }
            else if (dir == "down")
            {
                dir = "up";
            }
            else if (dir == "straight")
            {
                dir = "up";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}