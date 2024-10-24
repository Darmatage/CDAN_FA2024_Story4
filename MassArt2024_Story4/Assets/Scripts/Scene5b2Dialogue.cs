using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5b2Dialogue : MonoBehaviour
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
    public GameObject ArtChar1a;//chara_HOAlady_happy
    public GameObject ArtChar1b;//chara_HOAlady_angry
    public GameObject ArtChar1c; //chara_HOAlady_pleased

    public GameObject ArtChar2a;
    public GameObject ArtChar2b;

    public GameObject ArtBg1;//bg_your_house_interior_doorclosed
    public GameObject ArtBg2;//bg_your_house_interior_dooropen
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public AudioSource SFX_Knock;
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
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);

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
            DialogueDisplay.SetActive(false);
            SFX_Knock.Play();
            Char1name.text = "";
            Char1speech.text = "<i><b> BANG BANG BANG </i></b>";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 3)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Oh no.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 4)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "WHAT DID I TELL YOU ABOUT PARTIES, SPLATTHEW? HUH?";
        }

         else if (primeInt == 5)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "YOU THOUGHT YOU COULD DISOBEY ME?";
        }

         
 

        else if (primeInt == 6)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I- I can explain!";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
       
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Aww, a going away party. How sweet. It's a shame that is EXPRESSELY FORBIDDEN!!!";
			primeInt = 39;
        }

        // after choice 1b
       
         else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Oh, how could you possibly think I'm that STUPID?!";
			primeInt = 39;
        }
 
		else if (primeInt == 39)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "WELL, I HATE TO BREAK IT TO YOU, BUT YOU'RE NOT GETTING OUT OF THIS ONE EASY!";
        }
        
         else if (primeInt == 40)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "I WANT TO SEE ALL OF YOU OUT OF THIS HOUSE, NOW!!!!!!!!!!!!";
        }


         else if (primeInt == 41)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "I KNEW I SHOULDN'T HAVE BELIEVED YOUR LITTLE STORY ABOUT THE WATER HEATER!";
        }

         else if (primeInt == 42)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "I WANT YOU BOTH OUT OF THIS NEIGHBORHOOD OR SO HELP ME ZOG!";
        }

        
         else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "I knew I shouldn't have believed your little story about the water heater.";
        }

        else if (primeInt == 44)
        {
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "I'm sorry, bro.";
        }


       else if (primeInt == 45)
        {
            DialogueDisplay.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
			NextScene1Button.SetActive(true);
            //NextScene2Button.SetActive(true);
        }


        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "W-well, Splatthew's friend is moving away... s-so, we thought... we thought it would be nice to throw a going away party...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "I- I don't know...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }




    public void SceneChange1()
    {
        SceneManager.LoadScene("SceneLose");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}