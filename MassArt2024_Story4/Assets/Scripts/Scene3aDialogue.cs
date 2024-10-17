using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour
{
    public int primeInt = 1;       
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    public TMP_Text Char3name;
    public TMP_Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;//chara_neighbor1_happy
    public GameObject ArtChar1b;//chara_neighbor1_concerned
    public GameObject ArtChar1c;//chara_neighbor1_arguing
    public GameObject prop_plate;
    public GameObject ArtChar2a;//chara_daughter_grateful
    public GameObject ArtChar2b;//chara_daughter_neutral
    public GameObject ArtChar2c;//chara_daughter_arguing
    public GameObject ArtBg1;//bg_neighbor1_exterior_doorclosed
    public GameObject ArtBg2;//bg_neighbor1_exterior_dooropen
    public GameObject Choice1a;//it was great
    public GameObject Choice1b;//it was fine
    public GameObject Choice1c;//it sucked
    public GameObject Choice2a;//panic
    public GameObject Choice2b;//this is fine
    public GameObject NextScene1Button;//explore the backyard
    public GameObject NextScene2Button;//go find the hoa lady
    public GameObject NextScene3Button;//head to the library
    public GameObject nextButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        prop_plate.SetActive(false);
        ArtBg1.SetActive(true);
        ArtBg2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
            Char1speech.text = "I should probably return the cookie plate before it gets lost in my hordes of boxes.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "<b><i>knock knock </b></i>";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 4)
        {	
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "<b>COMING</b>";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "<i>HELLO!</i>";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
          
            Char1name.text = "YOU";
            Char1speech.text = "Hi! I’m just bringing your plate back.";
            Char2name.text = "";
            Char2speech.text = " ";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
          
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Aw, you didn’t have to do that, I have plenty of plates.\r\n";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            
            Char1name.text = "YOU";
            Char1speech.text = "No, I really did, my house is a mess and it would’ve been lost forever otherwise.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
          
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Whatever helps you sleep at night";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
      
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "<i>5H3RYL takes the plate from you</i>";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "What did you think of your first day?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true);
        }

        // after choice 1a
        else if (primeInt == 15)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I had a really fun time! I’m really enjoying having moved here so far.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "I’m glad! I’ve been living here for eight years so far and have yet to regret it even if the HOA lady makes me come close.\r\n";
            Char3name.text = "";
            Char3speech.text = "";
            primeInt = 30;
        }

        // after choice 1b
        else if (primeInt == 20)
        {
            
            Char1name.text = "YOU";
            Char1speech.text = "It was okay, it’s hard to judge after just one day.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
      
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "That makes sense I suppose. I’m sure you’ll warm up to it!\r\n";
            Char3name.text = "";
            Char3speech.text = "";
            primeInt = 30;
        }

        // after choice 1c
        else if (primeInt == 25)
        {

            Char1name.text = "YOU";
            Char1speech.text = "It sucked and was awful, it’s a wonder anybody stays.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
         
        }
        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "That feels harsh… I’m sure you’ll feel differently once you’re all settled in.";
            Char3name.text = "";
            Char3speech.text = "";
            primeInt = 30;
        }

        //conversation continues from both story choices:
        else if (primeInt == 30)
        {
         
            Char1name.text = "YOU";
            Char1speech.text = "Of course, it’s only been one day. I’ll probably feel differently once it no longer takes me twenty minutes and several boxes to find anything.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 31)
        {
            
            Char1name.text = "YOU";
            Char1speech.text = "It took me an unspeakable amount of time to get dressed this morning.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Haha, I feel you. The family and I went off planet for a few days last summer and we still have to fish things out of the suitcase every now and then.\r\n";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "<i><b> a large thump can be heard coming from the roof</i></b>";
        }
        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
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
        else if (primeInt == 35)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "I’m slightly concerned by the scale of your response.\r\n";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 36)
        {
            
            Char1name.text = "YOU";
            Char1speech.text = "I’ve lived a colorful life, you don’t know where I’ve been.\r\n";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 37)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Interesting… anyway that’s probably my daughter WHO ISN’T SUPPOSED TO BE ON THE ROOF!\r\n";
            Char3name.text = "";
            Char3speech.text = "";
        }

        else if (primeInt == 38)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "<i>another loud thump can be heard, it's closer than the one before</i>";
        }

        else if (primeInt == 39)
        {
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "D0TT13";
            Char3speech.text = "";
         
        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 39)
        {

            Char1name.text = "";
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
        Char1speech.text = "Living the dream!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 15;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "I am standing in the middle of the road.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 20;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1cFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "I regret everything that's lead up to this point.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 25;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Aaaaaah, the sky is falling!\r\n";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 35 ;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = " … okay then\r\n";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 35 ;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3b");
    }
}