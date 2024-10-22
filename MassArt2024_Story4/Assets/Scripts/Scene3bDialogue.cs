using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour
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
       //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
    public GameObject ArtBg1;//bg_your_house_interior_doorclosed
    //public GameObject ArtBg2;//bg_your_house_interior_dooropen
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
        ArtBg1.SetActive(true);
        //ArtBg2.SetActive(false);
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
            Char1speech.text = "Hey, nice living room";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 3)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Never mind the living room! We have an emergency!";
        }

        else if (primeInt == 4)
        {
            Char1name.text = playerName;
            Char1speech.text = "Wait, what? I thought we were planning your friend's party?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 5)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "So, I know I already told you about <b>The Great Slungus Going-Away Blowout Bash</b>...";
        }

         else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "...but I've gotta ask you a <b>huuuuuuge</b> favor. That head HOA lady, let's just say she's not too big on fighting for your right to party.";
        }

        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Apparently we got the cops called on us one too many times for 'disturbing the peace.' ...Whatever that means.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 8)
        {	
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "And if she hears one more noise complaint she's gonna foreclose on the house!";
            
        }
        else if (primeInt == 9)
        {	
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "But man, I can't cancel The Great Slungus Going-Away Blowout Bash!";
            
        }
      

        else if (primeInt == 10)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "I might never see my man again! Do you know how expensive flights to Epsilon Tauri are right now?";
            
        }

         else if (primeInt == 11)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "(Yeesh... What is he expecting from me?)";
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
            Char2speech.text = "I thought you'd never ask!";
            primeInt=39;
            
        }
       

        // after choice 1b
        else if (primeInt == 30)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "I know, I know, it's a lot to take in.";
			primeInt = 39;
        }
 
		//conversation continues from both story choices:
		else if (primeInt == 40)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = " Well, you see, you've got a squeaky clean reputation with the head HOA lady.";
            
        }

        	else if (primeInt == 41)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "You've gotta find some way to... I don't know... get rid of her! Just for the night. So, what do you say?";
            
        }
		
       else if (primeInt == 42)
        {
            Char1name.text = playerName;
            Char1speech.text = "Uh...";
            Char2name.text = "";
            Char2speech.text = "";
            
        }

        else if (primeInt == 43)
        {
            DialogueDisplay.SetActive(false);
            Char1name.text = "";
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
        Char1speech.text = "Alright, I'm hearing you out, but where do I come into this plan?";
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
        Char1speech.text = "...whuh? Huh whuh??";
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
        SceneManager.LoadScene("Scene4b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3a");
    }
}