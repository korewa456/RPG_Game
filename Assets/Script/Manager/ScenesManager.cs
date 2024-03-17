using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    #region Singleton Pattern

    // The private static instance of the singleton
    private static ScenesManager instance;

    // Public static method to access the instance
    public static ScenesManager Instance
    {
        get
        {
            if (instance == null)
            {
                // Find existing instance in the scene or create new one if it doesn't exist
                instance = FindObjectOfType<ScenesManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("ScenesManager");
                    instance = obj.AddComponent<ScenesManager>();
                }
            }
            return instance;
        }
    }

    // Ensuring that there's only one instance of this object in the scene
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); // Optional: if you want this singleton to persist across scenes
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Ensures no duplicate instances are created
        }
    }

    #endregion

    public enum Scene
    {
        //Add new scene here, make sure it order match file/build setting.
        MainMenu,
        Level01
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }


}
