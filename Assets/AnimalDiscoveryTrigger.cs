using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalDiscoveryTrigger : MonoBehaviour
{
    [SerializeField]
    string animalName;
    [SerializeField]
    Text iconLabelText;
    // Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {
            PauseManager.instance.ShowMessagePanel("You have found <color=Yellow>" + animalName + "</color>!");
            AudioManager.instance.PlaySoundEffect("newDiscovery");
            iconLabelText.text = "found";
            iconLabelText.color = Color.yellow;

            GameManager.instance.foundAnimalNum += 1;
        }
        gameObject.SetActive(false);
    }
}
