using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int currentScene;

    public void restartScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(GoToSceneRoutine(currentScene));
    }
    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        currentScene = sceneIndex;
        SceneManager.LoadScene(sceneIndex);
    }


}
