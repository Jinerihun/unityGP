using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    
    public AudioSource audioSource; // ����Ҫ����������AudioSource���
    public Slider volumeSlider; // ����UI���������


    // Use this for initialization
    void Start()
    {
        // ��ʼ����������ֵ����ƵԴ������һ��
        if (audioSource != null && volumeSlider != null)
        {
            volumeSlider.value = audioSource.volume;
            // ����������ֵ�ı仯�¼�
            volumeSlider.onValueChanged.AddListener(OnVolumeSliderValueChanged);
        }
        else
        {
            Debug.LogError("VolumeSliderController: Missing references to AudioSource or Slider.");
        }
    }


    // ��������ֵ�仯ʱ���õķ���
    void OnVolumeSliderValueChanged(float newValue)
    {
        // ����������ֵ����Ϊ��ƵԴ������
        if (audioSource != null)
        {
            audioSource.volume = newValue;
        }
    }
}

