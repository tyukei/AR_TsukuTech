using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallEndScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
    }
    public void CallTitleScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
