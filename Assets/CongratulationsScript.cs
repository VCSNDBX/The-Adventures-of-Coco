using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CongratulationsScript : MonoBehaviour
{
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Greet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Greet(){
        yield return new WaitForSeconds(5f);
        child.SetActive(true);
    }
    public void StartScene(){
        SceneManager.LoadScene(0);
    }
}
