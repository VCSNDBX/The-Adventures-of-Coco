using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMapManager : MonoBehaviour
{
    private GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        SelectLevel();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SelectLevel()
    {
        RaycastHit hit;
        Ray ray = maincamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log(objectHit.name);
        }
    }
}
