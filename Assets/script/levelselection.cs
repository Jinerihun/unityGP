using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelselection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Choose()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("choose");
    }
}
