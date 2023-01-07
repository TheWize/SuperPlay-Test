using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DynamicNumber : MonoBehaviour
{
    private TextMeshProUGUI text;
    [SerializeField] private Slider slider;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        UpdateNumber();
    }
    public void UpdateNumber()
    {
        text.SetText(slider.value.ToString());
    }
}
