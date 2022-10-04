using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        
        // The following sections allow the character to move diagonally
        if (Input.GetKey("e"))
        {
            pos.y += speed * Time.deltaTime;
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("q"))
        {
            pos.y += speed * Time.deltaTime;
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey("c"))
        {
            pos.y -= speed * Time.deltaTime;
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("z"))
        {
            pos.y -= speed * Time.deltaTime;
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
