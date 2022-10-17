using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpsManager : MonoBehaviour
{
    public bool powerupsready, powerupactivated;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FreezeTime()
    {
        powerupactivated = true;
    }

    public void PowerUpsEffect()
    {
        FreezeTime();
        powerupsready = false;
    }

}
