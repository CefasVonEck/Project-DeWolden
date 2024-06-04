using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement; //this allows this script to access unity's scene manager 
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public void LoadLevelPls (int sceneIndex)
    {
        StartCoroutine(Loading(sceneIndex));
    }

    IEnumerator Loading (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {

            float loadingProgress = Mathf.Clamp01(operation.progress / .9f);
            
            //UnityEngine.Debug.Log(loadingProgress);
            slider.value = loadingProgress;
            progressText.text = loadingProgress * 100f + "%";

            yield return null;

        }
    }

}
