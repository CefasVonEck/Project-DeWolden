using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Windows;
using System.Text.RegularExpressions;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private float maxValue;
    [SerializeField]
    private float currentValue;

    [SerializeField]
    private TextMeshProUGUI textMeshPro;
    [SerializeField]
    private string textName;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = maxValue;
        slider.value = currentValue;
    }

    // Function to set the slider value
    public void SetSliderValue(float value)
    {
        slider.value = currentValue - value;
        currentValue = currentValue - value;
    }

    void FixedUpdate()
    {
       // SetSliderValue(currentValue - 0.01f);


        if (textMeshPro != null)
        {
            string result = Regex.Replace(textMeshPro.text, @"\d", "");
            textMeshPro.text = result;
            textMeshPro.text = textName + (int)currentValue + "";
        }
    }

    public float getValue()
    {
        return currentValue;
    }
}