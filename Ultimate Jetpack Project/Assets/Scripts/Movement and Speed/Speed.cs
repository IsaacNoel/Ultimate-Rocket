using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float acceleration;
    private void Update()
    {
        speed = speed + acceleration * Time.deltaTime;
        Vector3 speedUp = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        transform.position = speedUp;
    }
}
