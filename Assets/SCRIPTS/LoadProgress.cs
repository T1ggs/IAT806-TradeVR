using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadProgress : MonoBehaviour
{
    public Text StepProgress;
    public Text LevelProgress;

    private string savePath;
    private SaveData data;

    public SaveSystem saveSystem;

    void Awake()
    {
        savePath = Application.persistentDataPath + "/save.json";
    }

    void Start()
    {
        data = Load();
        if (data.currentStep == 0 && data.currentLevel == 0 && !File.Exists(savePath))
        {
            UpdateUI("No save file!", "No save file!"); // string overload
        }
        else
        {
            UpdateUI(data.currentStep, data.currentLevel); // int overload
        }
    }

    void UpdateUI(int step, int level)
    {
        if (StepProgress != null)
            StepProgress.text = $"Current Step: {step}";
        if (LevelProgress != null)
            LevelProgress.text = $"Current Level: {level}";
    }

    void UpdateUI(string stepMessage, string levelMessage)
    {
        if (StepProgress != null)
            StepProgress.text = stepMessage;
        if (LevelProgress != null)
            LevelProgress.text = levelMessage;
    }

    public SaveData Load()
    {
        if (!File.Exists(savePath))
        {
            Debug.Log("No save file found!");
            return new SaveData
            {
                currentStep = 0,
                currentLevel = 0
            };
        }

        try
        {
            string json = File.ReadAllText(savePath);
            SaveData loadedData = JsonUtility.FromJson<SaveData>(json);

            Debug.Log("Loaded Step: " + loadedData.currentStep);
            Debug.Log("Loaded Level: " + loadedData.currentLevel);

            return loadedData;
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to load save: " + e.Message);
            return new SaveData { currentStep = 0, currentLevel = 0 };
        }
    }
}
