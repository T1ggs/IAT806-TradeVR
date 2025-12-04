using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialStep : MonoBehaviour
{

    public int currentStep;
    public int currentLevel;
    public SaveSystem saveSystem;
    public Text stepText;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        saveSystem.currentLevel = currentLevel;
    }

    public void stepAdvance()
    {
        currentStep += 1;
        stepText.text = currentStep.ToString();

        //for the save manager
        saveSystem.currentStep = currentStep;

    }

 
}


