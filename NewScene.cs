using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewScene : MonoBehaviour
{
    public int nextScene;
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    public void sceneLoader()
    {
        if (nextScene != 2)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
