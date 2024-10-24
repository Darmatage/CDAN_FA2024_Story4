using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5b1Dialogue : MonoBehaviour
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
    //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
    public GameObject ArtBg1;//bg_your_house_interior_doorclosed
    public GameObject ArtBg2;//bg_your_house_interior_dooropen
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public string playerName;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        playerName = GameHandler.playerName;
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
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
            Char1speech.text = "Ok, everybody, I'm so sorry, but I need all of you to leave right now";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 3)
        {
            
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Yeah, you heard 'em, we gotta pack up.";
        }

        else if (primeInt == 4)
        {
            ArtBg1.SetActive(false);
            ArtBg2.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Wow. Huh. That was fast.";
            Char2name.text = "";
            Char2speech.text = "";
        }

         else if (primeInt == 5)
        {
            
            Char1name.text = playerName;
            Char1speech.text = "Just in time, too! I think I just heard the HOA lady pull up!";
            Char2name.text = "";
            Char2speech.text = "";
        }

         else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Hey man, I just gotta give you a big thank you. We couldn't have thrown The Great Slungus Going-Away Blowout Bash without you.";
        }
        
         else if (primeInt == 7)
        {
            
            Char1name.text = playerName;
            Char1speech.text = "Really? I thought you were mad at me for making you end the party so suddenly.";
            Char2name.text = "";
            Char2speech.text = "";
        }

         else if (primeInt == 8)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Mad at you?";
        }

        

 
 

        else if (primeInt == 9)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "...yeah...";
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
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Aww, dude...";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "You really thought I'd be mad?";
			primeInt = 39;
        }

        // after choice 1b
        else if (primeInt == 30)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Hey, don't talk about yourself like that, bro!";
			primeInt = 39;
        }
 
		//conversation continues from both story choices:
		 else if (primeInt == 39)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = " Dude, after the party we just had, I could never be mad at you!";
        }

         else if (primeInt == 40)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "You're the best bro ever!";
        }
       else if (primeInt == 41)
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
        Char1speech.text = "Yeah, you guys just looked like you were having so much fun, and I thought I was gonna ruin your night-";
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
        Char1speech.text = "Haha, yeah, I guess it sounds dumb, but-";
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
        SceneManager.LoadScene("SceneWin");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}