using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float speed = 1.5f;

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetButton("Horizontal") || (Input.GetButton("Vertical")))
        {
            Vector3 new_pos = transform.localPosition;
            new_pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            new_pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.localPosition = new_pos;
        }
    }
}
