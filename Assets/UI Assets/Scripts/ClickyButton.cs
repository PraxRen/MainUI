using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ClickyButton : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private Sprite _pressedSprite;
    [SerializeField] private AudioClip _compressAudioClip;
    [SerializeField] private AudioClip _uncompressAudioClip;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private TMP_Text _text;

    public void Down()
    {
        _image.sprite = _pressedSprite;
        _audioSource.PlayOneShot(_compressAudioClip);
        _text.alignment = TextAlignmentOptions.Bottom;
    }

    public void Up()
    {
        _image.sprite = _defaultSprite;
        _audioSource.PlayOneShot(_uncompressAudioClip);
        _text.alignment = TextAlignmentOptions.Center;
    }
}