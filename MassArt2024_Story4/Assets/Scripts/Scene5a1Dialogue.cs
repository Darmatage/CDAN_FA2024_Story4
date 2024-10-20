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

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
    

        //prop_HOAflyer.SetActive(false);
        //prop_HOApamphlet.SetActive(false);
        ArtBg1.SetActive(false);
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
            Char1name.text = "YOU";
            Char1speech.text = "<i> knock knock <i>";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Neighbor 1's Daughter";
            Char3speech.text = "Oh, it's you, PLAYER'S NAME.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {	//DialogueDisplay.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yep, is your mom here?";
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
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Neighbor 1's Daughter";
            Char3speech.text = "MOM, PLAYER'S NAME IS HERE!";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Neighbor 1";
            Char2speech.text = "Wow, what a pleasant surprise.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I decided to swing by the library and there's a Hobbyist Astronomy Organization that's apparently pretty new.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Neighbor 1's Daughter";
            Char3speech.text = "Aw, swell, sounds like a blast.";
        }
		else if (primeInt == 9)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, yeah, apparently other teens plan on going to their next meeting.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Choice1a.SetActive(true);
            //Choice1b.SetActive(true);
        }
		else if (primeInt == 20)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Neighbor 1";
            Char2speech.text = "Sounds like we're going then, maybe they've got a roof for you to sit on.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 30)
        {
			
            Char1name.text = "YOU";
            Char1speech.text = "Well, actually, about that. Theres a program that would allow you to build an observatory on your roof free of cost.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Neighbor 1's Daughter";
            Char3speech.text = "Sweet!";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Neighbor 1";
            Char2speech.text = "What about the HOA though?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 33)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "It's a government funded project, the HOA legally has to allow it with no obstacles.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Neighbor 1's Daughter";
            Char3speech.text = "Is it unobtrusive looking?";
        }
        else if (primeInt == 35)
        {
            Char1name.text = "YOU";
            Char1speech.text = "From my understanding, not at all.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Neighbor 1";
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

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene5b1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene5b2");
    }
}