using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    [SerializeField]
    [Range(1,10)]
    private float movementSpeed = 3;

    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x += movementSpeed * horizontal * Time.deltaTime;
        position.y += movementSpeed * vertical * Time.deltaTime;
        transform.position = position;
    }
}
