using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum LevelState
{
    INTRO,
    REVISION,
    CHECKING,
    RESULTS,
    END
}
public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Level Manager: Instance ya tiene información");
            return;
        }
        else
        {
            Debug.Log("Level Manager: Instance NO tiene información");
            Instance = this;
        }
    }
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
