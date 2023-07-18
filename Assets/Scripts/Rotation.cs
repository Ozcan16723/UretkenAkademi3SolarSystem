using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] Vector3 RotDirection;
    [SerializeField] int rotSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Rotate(RotDirection * rotSpeed * Time.deltaTime);
    }
}
