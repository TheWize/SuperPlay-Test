using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetNumbers : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private float duration = 1f;
    [SerializeField] private float delay = 2.2f;
    private Popup popup;
    private void Start()
    {
        slider = GetComponent<Slider>();
        popup = FindObjectOfType<Popup>();
    }
    public void SetNumberWithDelay(int number)
    {
        StopAllCoroutines();
        StartCoroutine(SetNumberWithDelayCorutine(number));
    }
    public void SetRandomBar()
    {
        StopAllCoroutines();
        StartCoroutine(SetNumberCorutine(Mathf.RoundToInt(Random.Range(slider.maxValue / 10, slider.maxValue))));
    }
    public void FillBar()
    {
        StopAllCoroutines();
        StartCoroutine(SetNumberCorutine(Mathf.RoundToInt(slider.maxValue)));
    }
    public void EmptyBar()
    {
        StopAllCoroutines();
        StartCoroutine(SetNumberCorutine(Mathf.RoundToInt(slider.minValue)));
    }
    private IEnumerator SetNumberCorutine(int endValue)
    {
        float currDurr;
        int startValue = Mathf.RoundToInt(slider.value);
        currDurr = 0;

        while (currDurr < 1)
        {
            currDurr += Time.deltaTime / duration;

            slider.value = Mathf.RoundToInt(Mathf.Lerp(startValue, endValue, currDurr));
            if (slider.value == slider.maxValue)
            {
                popup.Open();
            }
            yield return null;
        }
    }
    private IEnumerator SetNumberWithDelayCorutine(int endValue)
    {
        yield return new WaitForSeconds(delay);
        float currDurr;
        int startValue = Mathf.RoundToInt(slider.value);
        currDurr = 0;

        while (currDurr < 1)
        {
            currDurr += Time.deltaTime / duration;

            slider.value = Mathf.RoundToInt(Mathf.Lerp(startValue, endValue, currDurr));
            if (slider.value == slider.maxValue)
            {
                popup.Open();
            }
            yield return null;
        }
    }
}
