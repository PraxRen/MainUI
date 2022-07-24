using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearColorChangerButton : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private float _duration;
    private float _runningTime;
    private System.Random random = new System.Random();
    private Coroutine _modifyJob;

    public void Run()
    {
        Color afterColor = GetRandomColor();
        _modifyJob = StartCoroutine(Modify(afterColor));
    }

    public void Stop()
    {
        if (_modifyJob == null)
            return;

        StopCoroutine(_modifyJob);
        _runningTime = 0;
    }

    private IEnumerator Modify(Color afterColor)
    {
        while (true)
        {

            _runningTime += Time.deltaTime;
            _image.color = Color.Lerp(_image.color, afterColor, _runningTime / _duration);

            if (_image.color == afterColor)
            {
                afterColor = GetRandomColor();
                _runningTime = 0;
            }

            yield return null;
        }
    }

    private Color GetRandomColor()
    {
        int minColor = 0;
        int maxColor = 2;
        return new Color((float)random.Next(minColor, maxColor), (float)random.Next(minColor, maxColor), random.Next(minColor, maxColor));
    } 
}
