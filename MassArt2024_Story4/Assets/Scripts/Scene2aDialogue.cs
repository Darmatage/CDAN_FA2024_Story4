using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    //public TMP_Text Char3name;
    //public TMP_Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;//chara_neighbor1_happy
    public GameObject ArtChar1b;//chara_neighbor1_concerned
    public GameObject ArtChar1c; //chara_neighbor1_arguing
    public GameObject prop_cookies;
    //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
    public GameObject ArtBg1;//bg_your_house_interior_doorclosed
    public GameObject ArtBg2;//bg_your_house_interior_dooropen
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;
    string playerName;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        playerName = GameHandler.playerName;
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        prop_cookies.SetActive(false);
        ArtBg1.SetActive(true);
        ArtBg2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    // Use the spacebar as a faster "Next" button:
    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
        }
    }

    //Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt += 1;
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {

            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Damn, I didn't realize I had so much stuff.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = playerName;
            Char1speech.text = "I don't even really have hobbies, why are there so many boxes? Guess I better start cracking.";
            Char2name.text = "";
            Char2speech.text = "";
      
        }
        else if (primeInt == 4)
        {	
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "<i><b> knock knock </i></b>";
        }
        else if (primeInt == 5)
        {
            ArtBg1.SetActive(false);
            ArtBg2.SetActive(true);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Hello, I live next door! I saw the moving truck sitting out front yesterday and was baking some cookies earlier so I figured I�d pop on by.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = playerName;
            Char1speech.text = "Oh, wow, you didn�t have to do that, thank you.";
            Char2name.text = "";
            Char2speech.text = " ";
        }
        else if (primeInt == 7)
        {
            ArtChar1a.SetActive(false);
            DialogueDisplay.SetActive(false);
            prop_cookies.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = " ";
        }
        else if (primeInt == 8)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            prop_cookies.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "It's no trouble, I remember when I first moved in and didn't know anybody yet so I wanted to be a friendly face.";
        }
        else if (primeInt == 9)
        {
            Char1name.text = playerName;
            Char1speech.text = "Oh?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
           
        }
        // after choice 1a
        else if (primeInt == 10)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "The HOA woman was here earlier, she seemed nice. Was she not here when you first moved in?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "<i>sigh</i> She hasn't even been living here as long as my toddler has and yet she�s dead set on sucking all the personality out of the street.";
            primeInt = 15;
        }

        // after choice 1b
        else if (primeInt == 12)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "";
            Char2name.text = "Ugh, I am so glad. An awful HOA woman was here earlier and she really wasn�t getting my hopes up about making new friends in the neighborhood.";
            Char2speech.text = "";
            primeInt = 15;
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Everybody else in the neighborhood is very friendly, I promise. It can get a little rambunctious, but it�s great fun.";
            primeInt = 15;
        }

        //conversation continues from both story choices:
        else if (primeInt == 15)
        {

            Char1name.text = playerName;
            Char1speech.text = "How come the HOA has such a prominent presence? It sounds like everything was going just fine without it.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 16)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "It was! Her husband slid the mayor a generous gift and got town hall to pass some fluff law requiring an HOA for our street.";
        }
        else if (primeInt == 17)
        {

            Char1name.text = playerName;
            Char1speech.text = "That sounds illegal?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 18)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "It definitely is, but she gets bored staying home all the time and she refuses to get a real job or a hobby.";
        }
        else if (primeInt == 19)
        {
            ArtChar1b.SetActive(true);
            ArtChar1c.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Her pushover of a husband would do anything to make her happy, the poor sap�";
        }
        else if (primeInt == 20)
        {

            Char1name.text = playerName;
            Char1speech.text = "Well, whatever works for them?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 21)
        {
            ArtChar1b.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Oh! Would you look at the time! I need to go pick up junior from soccer practice.";
        }

        
        else if (primeInt == 22)
        {
            ArtChar1a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "She was nice.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 23)
        {
            Char1name.text = playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }


        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "The HOA woman was here earlier, she seemed nice. Was she not here when you first moved in?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 9;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "Ugh, I am so glad. An awful HOA woman was here earlier and she really wasn�t getting my hopes up about making new friends in the neighborhood.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 12;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }




    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene3a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}