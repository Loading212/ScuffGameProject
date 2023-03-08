using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(1, 10)]
    public int PlayerSpeed = 5;

    Vector3 Velocity;

    public Animator playerAnim;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Velocity);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x,
            transform.position.y,
            transform.position.z - 10);

        Velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.Play("PlayerWalk_Up");
            Velocity += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerAnim.Play("PlayerWalk_Down");
            Velocity += Vector3.down;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerAnim.Play("PlayerWalk_Right");
            Velocity += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerAnim.Play("PlayerWalk_Left");
            Velocity += Vector3.left;
        }
        Velocity *= PlayerSpeed;

        transform.position += Velocity * Time.deltaTime;

    }
}
