using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    
    public AudioSource audioSource; // 引用要控制音量的AudioSource组件
    public Slider volumeSlider; // 引用UI滑动条组件


    // Use this for initialization
    void Start()
    {
        // 初始化滑动条的值与音频源的音量一致
        if (audioSource != null && volumeSlider != null)
        {
            volumeSlider.value = audioSource.volume;
            // 监听滑动条值的变化事件
            volumeSlider.onValueChanged.AddListener(OnVolumeSliderValueChanged);
        }
        else
        {
            Debug.LogError("VolumeSliderController: Missing references to AudioSource or Slider.");
        }
    }


    // 当滑动条值变化时调用的方法
    void OnVolumeSliderValueChanged(float newValue)
    {
        // 将滑动条的值设置为音频源的音量
        if (audioSource != null)
        {
            audioSource.volume = newValue;
        }
    }
}

