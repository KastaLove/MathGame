using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public string scene;
    public void OpenScene()
    {
        SceneManager.LoadScene(scene);
    }

    void Start()
    {
    }
}
