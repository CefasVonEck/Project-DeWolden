using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransportScriptData : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour scriptToReplace;

    [SerializeField]
    private String thisScene;
    [SerializeField]
    private String keepSceneLoaded;

    [SerializeField]
    private String gameobjectNameWithScript;

    // Start is called before the first frame update
    void Start(){}

    private int isReturningtoScene = 0;

    // Update is called once per frame
    void Update()
    {
        if (isReturningtoScene == 0)
        {
            LoadSceneAdditively(keepSceneLoaded);

            isReturningtoScene = 1;
        }

        if (isReturningtoScene > 0)
        {
            ++isReturningtoScene;

            if (isReturningtoScene == 5 && scriptToReplace != null)
            {
                GameObject obj = SceneManager.GetSceneByName(keepSceneLoaded).GetRootGameObjects()[0];
                obj = FindObjectRecursive(obj.transform, gameobjectNameWithScript);

                if (obj != null)
                {
                    // Get the script component attached to the GameObject
                    MonoBehaviour script = obj.GetComponentInChildren<MonoBehaviour>();

                    if (script != null)
                    {
                        // Call methods or access properties of the script
                        Destroy(obj.GetComponentInChildren<MonoBehaviour>());
                        obj.AddComponent(scriptToReplace.GetType());

                        Debug.LogError("Script replaced!");
                    }
                    else
                    {
                        Debug.LogError("Script component not found on GameObject.");
                    }
                }
                else
                {
                    Debug.LogError("GameObject not found in the additive scene.");
                }
                
            }
            else if(isReturningtoScene == 10)
            {
                SceneManager.UnloadSceneAsync(thisScene);
            }
        }
    }

    void LoadSceneAdditively(string sceneName)
    {
        // Check if the scene is already loaded
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            // Load the scene additively
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }
    }

    GameObject FindObjectRecursive(Transform parent, string name)
    {
        GameObject resulting = null;

        // Check if the current GameObject matches the target name
        if (parent.name == name)
        {
            resulting = parent.gameObject;
        }

        // Iterate through all children of the current GameObject
        foreach (Transform child in parent)
        {
            // Recursively search through children
            GameObject result = FindObjectRecursive(child, name);
            if (result != null)
            {
                resulting = result;
            }
        }

        return resulting;
    }
}
