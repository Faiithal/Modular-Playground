using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class pauseMenu : MonoBehaviour
{
    Button settingsBtn, resumeBtn, exitBtn, pauseBtn;
    VisualElement pauseContainer;
    VisualElement root;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        settingsBtn = root.Q<Button>("settingsButton");
        resumeBtn = root.Q<Button>("resumeButton");
        exitBtn = root.Q<Button>("exitButton");
        pauseBtn = root.Q<Button>("pauseButton");
        pauseContainer = root.Q<VisualElement>("pauseContainer");
    }

    private void OnEnable()
    {
        pauseBtn.clicked += ShowPauseMenu;
        resumeBtn.clicked += ExitPauseMenu;
    }

    private void OnDisable()
    {
        pauseBtn.clicked -= ShowPauseMenu;
        resumeBtn.clicked -= ExitPauseMenu;
    }

    void ShowPauseMenu()
    {
        pauseContainer.style.display = DisplayStyle.Flex;
        Time.timeScale = 0f;
    }

    void ExitPauseMenu()
    {
        pauseContainer.style.display = DisplayStyle.None;
        Time.timeScale = 1f;
    }

    void ExitGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void ShowSettingsMenu()
    {
        // TODO: Add Settings code idk.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
