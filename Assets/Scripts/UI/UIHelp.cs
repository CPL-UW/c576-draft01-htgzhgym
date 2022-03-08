using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHelp : MonoBehaviour
{


    [SerializeField]
    private Button m_backButton;

    private void Awake()
    {
        m_backButton.onClick.AddListener(HandleBack);
    }
    private void HandleBack()
    {
        SceneManager.LoadScene("MainMenu"); // change to whichever scene is your next
        AudioManager.instance.PlayOneShot("menu-click-default");
    }

}
