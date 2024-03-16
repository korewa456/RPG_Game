using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatDataManager : MonoBehaviour
{
    #region Singleton Pattern

    // The private static instance of the singleton
    private static CombatDataManager instance;

    // Public static method to access the instance
    public static CombatDataManager Instance
    {
        get
        {
            if (instance == null)
            {
                // Find existing instance in the scene or create new one if it doesn't exist
                instance = FindObjectOfType<CombatDataManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("CombatDataManager");
                    instance = obj.AddComponent<CombatDataManager>();
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

    public List<EntityInfo> PlayerEntities;

    



}
