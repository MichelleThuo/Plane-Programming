using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField]public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // The camera following the plane
        transform.position = plane.transform.position + offset;
    }
}
