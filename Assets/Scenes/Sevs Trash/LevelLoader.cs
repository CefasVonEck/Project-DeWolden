using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement; //this allows this script to access unity's scene manager 
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public TextMeshProUGUI progressText;

    public void LoadLevelPls (int sceneIndex) //this function is called when the "play" button is pressed. It triggers the Loading coroutine
    {
        StartCoroutine(Loading(sceneIndex));
    }

    IEnumerator Loading (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex); //this is a Unity function that starts loading a given scene (in this case based on its index)
        //It loads the scene in the background while still running the current active scene as well.

        loadingScreen.SetActive(true); //this shows (enables) the loading screen 

        while (!operation.isDone) //this checks how far along Unity is with loading the next scene and if its done or not
        {

            float loadingProgress = Mathf.Clamp01(operation.progress / .9f);
            
            //The 'operation' variable is a float that Unity returns upon running the LoadSceneAsync function
            //This float by default has a value from 0 to 0.9, so the line of code above converts that to be from 0 to 1 so its more readable for us humans
            
            UnityEngine.Debug.Log(loadingProgress);
            slider.value = loadingProgress;
            progressText.text = (int)(loadingProgress * 100) + "%"; //converts the loading progress float to a percentage and shows it as text on the loading bar

            yield return null;

        }
    }

}
