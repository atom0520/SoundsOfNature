using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {

    static public PauseManager instance;

    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    [SerializeField]
    GameObject pausePanel;

    [SerializeField]
    GameObject rulePanel;

    [SerializeField]
    GameObject pauseMask;

    [SerializeField]
    GameObject messagePanel;
    [SerializeField]
    Text messagePanelText;

    [SerializeField]
    GameObject winGamePanel;

    // Use this for initialization
    void Start () {
        instance = this;
        rulePanel.SetActive(true);
        Pause();
        //ShowMessagePanel("You have found <color=Yellow>Elephant</color>!");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && rulePanel.activeSelf == false) 
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
            Pause();
        }
    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            paused.TransitionTo(0);
            pauseMask.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            unpaused.TransitionTo(0);
            pauseMask.SetActive(false);
        }   
    }

    public void ShowMessagePanel(string newText)
    {
        messagePanelText.text = newText;
        messagePanel.SetActive(true);
        Pause();
    }

    public void ShowWinGamePanel()
    {
        winGamePanel.SetActive(true);
        Pause();
    }
    //void Lowpass()
    //{
    //    if (Time.timeScale == 0)
    //    {
    //        paused.TransitionTo(0);
    //    }
    //    else
    //    {
    //        unpaused.TransitionTo(0);
    //    }
    //}

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
