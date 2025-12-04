using UnityEngine;
using System.IO;


public class SaveSystem : MonoBehaviour
{
    private string savePath;
    public int currentStep;
    public int currentLevel;


    void Awake()
    {
        savePath = Application.persistentDataPath + "/save.json";
    }

    // Write current step and level
    public void Save(int currentStep, int currentLevel)
    {
        SaveData data = new SaveData();
        data.currentStep = currentStep;
        data.currentLevel = currentLevel;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);

        Debug.Log("Saved to: " + savePath);
    }

    public void SaveCurrent()
    {
        Save(currentStep, currentLevel);  // wrapper method to compensate for ui limitations
    }


    // Read current step and level
    public SaveData Load()
    {

        if (!File.Exists(savePath))
        {
            Debug.Log("No save file found.");

            // Return default data if no file exists
            SaveData defaultData = new SaveData();
            defaultData.currentStep = 0;
            defaultData.currentLevel = 0;
            return defaultData;
        }

        string json = File.ReadAllText(savePath);
        SaveData data = JsonUtility.FromJson<SaveData>(json);

        Debug.Log("Loaded Step: " + data.currentStep);
        Debug.Log("Loaded Scene: " + data.currentLevel);

        return data;
    }
}
