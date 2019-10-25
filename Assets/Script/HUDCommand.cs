using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDCommand : MonoBehaviour
{
    public Text HungerText;
    public Text FriendshipText;
    public Text isSickText;


    public GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /*HungerText.text = "I'm Hungry";
        FriendshipText.text = "Hello";
        isSickText.text = "Healthy";*/

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rock != null)
        {
            HungerText.text = "Hungary: " + Rock.GetComponent<RockController>().hunger.ToString();
            FriendshipText.text = "Fwiendship OwO: " + Rock.GetComponent<RockController>().friendship.ToString();
            isSickText.text = "Achoo: " + Rock.GetComponent<RockController>().IsSick.ToString();
        }
        
    }

    public void FeedRock()
    {
        if (Rock != null)
        Rock.GetComponent<RockController>().hunger += 2;
    }
    public void PlayWithRock()
    {
        if (Rock != null)
        Rock.GetComponent<RockController>().friendship += 2;
    }

    public void Vet()
    {
        if (Rock != null)
        Rock.GetComponent<RockController>().IsSick = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.LogError("Game Quit");
    }
}


