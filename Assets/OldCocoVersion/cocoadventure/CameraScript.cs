using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject CameraPos;
    private Vector3 cameraposition;
    // Start is called before the first frame update
    void Start()
    {
        CameraPos = GameObject.Find("CameraPosition");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = CameraPos.transform.position;
    }
}
