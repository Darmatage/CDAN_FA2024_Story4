using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5a1Dialogue:MonoBehaviour
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
    public GameObject ArtChar2a;//neighbor1Happy
    public GameObject ArtChar2b;//neighbor1grateful
    public GameObject ArtChar3a;//daughterneutral
    public GameObject ArtChar3b;//daughtergrateful
    
    
    public GameObject ArtBg1;
    //public GameObject ArtBg2;
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
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
    

        //prop_HOAflyer.SetActive(false);
        //prop_HOApamphlet.SetActive(false);
        ArtBg1.SetActive(true);
        //ArtBg2.SetActive(true);
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
            Char1speech.text = "<i> knock knock <i>";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
        ArtChar3a.SetActive(true);
        ArtChar3b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "Oh, it's you, New Neighbor!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {	//DialogueDisplay.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Yep, is your mom here?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "MOM, THE NEW NEIGHBOR IS HERE!";
        }
        else if (primeInt == 6)
        {
        ArtChar2a.SetActive(true);
        ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "Wow, what a pleasant surprise.";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 7)
        {
            Char1name.text = playerName;
            Char1speech.text = "Do I remember correctly, you said you like astronomy?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "Yeah!";
        }
        else if (primeInt == 9)
        {
            Char1name.text = playerName;
            Char1speech.text = "I decided to swing by the library like you suggested. There's a new Hobbyist Astronomy Organization!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "Aw, swell, sounds like a blast.";
        }
		else if (primeInt == 11)
        {
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "Sounds like we're going then, maybe they've got a roof for you to sit on.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
			
            Char1name.text = playerName;
            Char1speech.text = "Well, actually, about that. There's a program to help you build an observatory on your roof, free of cost.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "Sweet!";
        }
        else if (primeInt == 14)
        {
        ArtChar2a.SetActive(true);
        ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "What about the HOA though?";
            Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //hide next button, display choice buttons:
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }


//after choice 1a:
        else if (primeInt == 20)
        {
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "Hah! Yeah. I really don't";
            Char3name.text = "";
            Char3speech.text = "";
            primeInt=39;
        }



//after choice 1a:
        else if (primeInt == 30)
        {
        ArtChar2a.SetActive(true);
        ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "How so?";
            Char3name.text = "";
            Char3speech.text = "";
            primeInt=39;
        }



        else if (primeInt == 40)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "It's a government funded project, the HOA legally has to allow it with no obstacles.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 41)
        {
        ArtChar3a.SetActive(true);
        ArtChar3b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "5H3RYL's Daughter";
            Char3speech.text = "Is it unobtrusive looking?";
        }
        else if (primeInt == 42)
        {
            Char1name.text = playerName;
            Char1speech.text = "From my understanding, not at all.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 43)
        {
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text ="5H3RYL";
            Char2speech.text = "Perfect.";
            Char3name.text = "";
            Char3speech.text = "";
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
        Char1speech.text = "Do we really want to allow this corrupt HOA to dictate every part of our lives?";
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
        Char1speech.text = "I think we can get around that here.";
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
        SceneManager.LoadScene("Scenec1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene5c1");
    }
}