using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class MenuLauncher : MonoBehaviour
{
    [SerializeField] private Button _playAudioButton;
    [SerializeField] private Button _playNoAudioButton;
    [SerializeField] private SpriteAtlas _spriteAtlas;
    // Start is called before the first frame update
    void Start()
    {
        _playAudioButton.onClick.RemoveAllListeners();
        _playNoAudioButton.onClick.RemoveAllListeners();
        _playAudioButton.onClick.AddListener(OnWithAudioButtonClicked);
        _playNoAudioButton.onClick.AddListener(OnWithoutAudioButtonClicked);

        _playAudioButton.GetComponent<Image>().sprite = _spriteAtlas.GetSprite("BlueGradient");
        _playNoAudioButton.GetComponent<Image>().sprite = _spriteAtlas.GetSprite("RedGradient");
    }
    private void OnWithAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = true;
            SceneManager.LoadScene("Game");
        }
        private void OnWithoutAudioButtonClicked()
        {
            
            AudioManager.Instance.isAudioEnabled = false;
            SceneManager.LoadScene("Game");
        }
}
