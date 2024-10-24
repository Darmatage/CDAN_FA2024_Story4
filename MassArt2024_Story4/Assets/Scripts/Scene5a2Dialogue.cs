using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5a2Dialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;//chara_HOAlady_happy
    public GameObject ArtChar1b;//chara_HOAlady_angry
    public GameObject ArtChar1c; //chara_HOAlady_pleased
    public GameObject ArtChar1d; //chara_HOAlady_ONPHONEangry
    public GameObject ArtChar1e;//chara_HOAlady_ONPHONEexasperated
    public GameObject ArtChar1f;//chara_HOAlady_ONPHONEpleased
    public GameObject prop_booklet;
    public GameObject ArtBg1;//bg_library
    public GameObject ArtBg2;//bg_HOAlady_house
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
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtChar1f.SetActive(false);
        prop_booklet.SetActive(false);
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
            Char1speech.text = "That grant sounds like it’d really help my neighbors. But it’d upset the HOA lady and you know...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = playerName;
            Char1speech.text = "you should always aim to please people in charge regardless of whether they have your best interests in mind.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4)
        {
            ArtBg1.SetActive(false);
            ArtBg2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "<i><b>knock knock </i></b>";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Oh, hello " + playerName;
        }
        else if (primeInt == 6)
        {
          
            Char1name.text = playerName;
            Char1speech.text = "Hi, I just thought I’d pop by and tell you something since you always have people’s best interests at heart.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1a.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "They might not think I do, but I do care. Just about different things than them. I operate on a higher level, you know?";
        }
        else if (primeInt == 8)
        {
         
            Char1name.text = playerName;
            Char1speech.text = "Of course, of course, speaking of higher levels…";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Is that stupid teen hanging out on her roof like an aesthetic ruining delinquent again?";
        }
        else if (primeInt == 10)
        {
    
            Char1name.text = playerName;
            Char1speech.text = "What?";
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
            ArtChar1c.SetActive(true);
            ArtChar1b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "You know how it is, every teen and young person is stupid and reckless, but not me as a youth. I was a perfect darling baby angel";
            primeInt = 39;
        }

        // after choice 1b
        else if (primeInt == 30)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Ha! As if she cares, she’s not even around to hear me obliterate her ass.";
            primeInt = 39;
        }

        //conversation continues from both story choices:
        else if (primeInt == 40)
        {
            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Views on the teen’s worth as a person aside, it turns out there’s a Hobbyist Astronomy Organization now.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 41)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Ugh, the horror. They’re probably trying to convince more people to hang out on their roof.";
        }
        else if (primeInt == 42)
        {
            Char1name.text = playerName;
            Char1speech.text = "Well, actually, they’re providing free resources for getting home observatories built.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 43)
        {
            ArtChar1b.SetActive (false);
            DialogueDisplay.SetActive(false);
            prop_booklet.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 44)
        {
            ArtChar1b.SetActive(true);
            DialogueDisplay.SetActive(true);
            prop_booklet.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "WHAT?! This cannot be allowed to continue. Who’s in charge there?";
        }
        else if (primeInt == 45)
        {
     
            Char1name.text = playerName;
            Char1speech.text = "Some pointy eared idiot old man wearing a foolish bow tie.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 46)
        {
    
            Char1name.text = "";
            Char2name.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "I know <i>exactly</i> who you’re talking about! I’ll take care of this.";
        }

        else if (primeInt == 47)
        {
            ArtChar1b.SetActive(false);
            ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "...";
        }

        else if (primeInt == 48)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Hello! I’ve heard you’ve started a new hobbyist group. Dissolve it.";
        }
        else if (primeInt == 49)
        {
            ArtChar1f.SetActive (false);
            ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "...";
        }
        else if (primeInt == 50)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Do I sound like I care? Your granddaughter’s just started first grade, hasn’t she?";
        }
        else if (primeInt == 51)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "...";
        }
        else if (primeInt == 52)
        {
            ArtChar1e.SetActive (false);
            ArtChar1d.SetActive (true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "If you don’t dissolve it she might herself suddenly unenrolled from the only decent elementary school in the area.";
        }
        else if (primeInt == 53)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "...";
        }
        else if (primeInt == 54)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "How is that possible, that must be illegal? Pish posh, as if I give a damn about what’s illegal.";
        }
        else if (primeInt == 55)
        {
            ArtChar1d.SetActive(false);
            ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "...";
        }
        else if (primeInt == 56)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = " …excellent. I hope we don’t meet again.";
        }
        else if (primeInt == 57)
        {
            ArtChar1f.SetActive (false);
            ArtChar1c.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "That go well?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 58)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "HOA Lady";
            Char2speech.text = "Very, thank you very much for telling me about that. You’ve been useful.";
        }
        else if (primeInt == 59)
        {
            Char1name.text = playerName;
            Char1speech.text = "I aim to please.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 60)
        {
            ArtChar1c.SetActive (false);
            DialogueDisplay.SetActive(false);
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
        Char1speech.text = "Yeah, she’s stupid. It’s definitely not that adults inherently view teens as an inferior species.";
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
        Char1speech.text = "Hey! She is actually quite smart! Also it’s kind of sad for a full adult to pick on someone who can’t even drive.";
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
        SceneManager.LoadScene("Scene2b"); //placeholder need to change the scene number later
    }
}