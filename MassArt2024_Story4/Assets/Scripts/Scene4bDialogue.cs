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
    
    //public GameObject prop_HOAflyer;
    //public GameObject prop_HOApamphlet;
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

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar3c.SetActive(false);

        //prop_HOAflyer.SetActive(false);
        //prop_HOApamphlet.SetActive(false);
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
            Char1name.text = "YOU";
            Char1speech.text = "Uh, hey, haha, how are you doing?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
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
            Char1name.text = "YOU";
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
            Char1name.text = "YOU";
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
            Char1name.text = "YOU";
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
        }
		else if (primeInt == 10)
        {
            DialogueDisplay.SetActive(true);
            ArtChar2a.SetActive(true);
            //prop_HOApamphlet.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Ldy";
            Char2speech.text = "It's riveting literature. What's your name? Let me add you to the neighborhood’s online messaging board.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
			
            Char1name.text = "YOU";
            Char1speech.text = "I just got here, what is it you do?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "The HOA makes sure the neighborhood stays presentable and... nice. ";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13)
        {
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = " The houses all match, nothing ugly like fences put up so kids don't accidentally run into the road chasing after balls.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
			DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Um...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
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
            Char2name.text = "HOA Lady";
            Char2speech.text = "What?! Haha, no. It's just that I mandate everybody plant color coordinated flowers in their yards...";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "...and it'd be such a shame if you couldn't see them all...";
            Char3name.text = "";
            Char3speech.text = "";
			primeInt = 39;
        }

        // after choice 1b
        else if (primeInt == 30)
        {
            ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "What?! They can't get crushed in the street, we don't want <i> controversy.</i>";
            Char3name.text = "";
            Char3speech.text = "";
			primeInt = 39;
        }
 
		//conversation continues from both story choices:
		else if (primeInt == 40)
        {
            ArtChar2b.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "...oh... I've been thinking about planting some hydrangeas, I've never had the space for them before.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 41)
        {
            ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Hydrangeas?! We only allow red or yellow flowers here!";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 42)
        {
            Char1name.text = "YOU";
            Char1speech.text = "But hydrangeas are my favorite flower! And it's my house!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "It might be <i> your </i> house and <i> your </i> yard, but there's someone you forgot to ask";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 44)
        {
            Char1name.text = "YOU";
            Char1speech.text = "The neighbors if they're allergic?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 45)
        {
            ArtChar2c.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Ha! As if I care what the neighbors think. No-- Me!";
            Char3name.text = "";
            Char3speech.text = "";
        }

		else if (primeInt == 46)
        {
			ArtChar2c.SetActive(false);
            Char1name.text = "";
            Char2name.text = "";
            Char2speech.text = " [<i> The HOA lady gets caught up in cackling to herself and walks off without saying good bye </i>]";
            Char3name.text = "";
            Char3speech.text = "";
        }

		else if (primeInt == 47)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Surely the neighbors can’t be all bad…";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

		else if (primeInt == 48)
        {
            Char1name.text = "YOU";
            Char1speech.text = "So what now? Do I unpack and wait for neighbors to say hi, or go out and meet them?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

       else if (primeInt == 49)
        {
            DialogueDisplay.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
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
        Char1name.text = "YOU";
        Char1speech.text = "You WANT kids to run into the street...?!?";
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
        Char1name.text = "YOU";
        Char1speech.text = "Yeah! Run into the street little gremlins, get crushed!";
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
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}