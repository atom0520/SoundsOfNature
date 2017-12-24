using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static public GameManager instance;

    public int foundAnimalNum { get; set; }
    public int totalAnimalNum = 8;

    [SerializeField]
    GameObject singleCamera;
    [SerializeField]
    GameObject gvrCamera;

    // Use this for initialization
    void Start()
    {
        instance = this;
        foundAnimalNum = 0;
    }

    //// Update is called once per frame
    //void Update () {

    //}
    public void CheckWinCondition()
    {
        if(foundAnimalNum == totalAnimalNum)
        {
            PauseManager.instance.ShowWinGamePanel();
            AudioManager.instance.PlaySoundEffect("winGame");
        }
    } 

    public void OnOffVRView(bool value)
    {
        if (value)
        {
            singleCamera.SetActive(false);
            gvrCamera.SetActive(true);
        }
        else
        {
            singleCamera.SetActive(true);
            gvrCamera.SetActive(false);
        }
    }

}
