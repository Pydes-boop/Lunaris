using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneBehavior : MonoBehaviour
{
   public void changeSceneTo(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void closeApplication()
    {
        Application.Quit();
    }
}
