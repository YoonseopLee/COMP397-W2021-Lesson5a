using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
