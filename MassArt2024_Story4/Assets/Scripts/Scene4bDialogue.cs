using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    public TMP_Text Char3name;
    public TMP_Text Char3speech;

    public GameObject DialogueDisplay;
    public GameObject ArtChar2a;//chara_HOAlady_happy
    public GameObject ArtChar2b;//chara_HOAlady_angry
    public GameObject ArtChar2c; //chara_HOAlady_pleased
    public GameObject ArtChar3a;//Splatthew Neutral
    public GameObject ArtChar3b;//Splathew Happy
    public GameObject ArtChar3c;//Splatthew Sad
    
    public GameObject ArtBg1;
    public GameObject ArtBg2;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    private bool allowSpace = true;
    string playerName;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        playerName = GameHandler.playerName;
        DialogueDisplay.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar3c.SetActive(false);

        //prop_HOAflyer.SetActive(false);
        //prop_HOApamphlet.SetActive(false);
        ArtBg1.SetActive(false);
        ArtBg2.SetActive(true);
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
            Char1speech.text = "Uh, hey, haha, how are you doing?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(true);
        ArtChar2c.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = "What is it?";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {	//DialogueDisplay.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I've got an emergency and I need you and only you to help me out as soon as possible!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
			//DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = "...Okay?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = playerName;
            Char1speech.text = "So there's this super specific part on my water heater that just broke, and the only place that sells them nearby is Gleebus's Hardware.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = "You mean, the Gleebus's Hardware that's a two hour drive away?";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
            Char1name.text = playerName;
            Char1speech.text = "Yeah, I know, and my car's been giving me trouble.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = "Are you sure you need me to do all that?";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }
		else if (primeInt == 20)
        {
            DialogueDisplay.SetActive(true);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(true);
        ArtChar2c.SetActive(false);
            //prop_HOApamphlet.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = "Okay, okay, I don't need to know. I'll get it right away.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 30)
        {
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA lady";
            Char2speech.text = " ...Huh. Okay. I'll get it right away.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 31)
        {
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtBg1.SetActive(true);
        ArtBg2.SetActive(false);
			
            Char1name.text = playerName;
            Char1speech.text = "Dude, she's gone! We've got about four hours starting now!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 32)
        {
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(true);
        ArtChar3c.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Splatthew";
            Char3speech.text = "Aw man, thanks so much for everything!";
        }
        else if (primeInt == 33)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Splatthew";
            Char3speech.text = "The Great Slungus Going-Away Blowout Bash has been a great success and shows no signs of slowing down!";
            // Turn off the "Next" button, turn on "Choice" buttons
            //nextButton.SetActive(false);
           // allowSpace = false;
           // Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 34)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = playerName;
            Char1speech.text = "On that note, actually... The HOA Lady's supposed to be back in fifteen minutes.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 35)
        {
            Char1name.text = playerName;
            Char1speech.text = "If you wanna keep living here, we've gotta start wrapping up now.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Splatthew";
            Char3speech.text = "But dude, we're having so much fun! We can't stop now! My friends are gonna be so mad if I tell ‘em they need to leave.";
			primeInt = 39;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "Yeah, right away! I'm... allergic to the cold. Severely allergic. I get horrible hives all over my-";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "Yeah, right away! You see, my... my pet iguana gets violent whenever it drops below 60 degrees. I have the scars to prove it";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }




    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene5b1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene5b2");
    }
}