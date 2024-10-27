using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour
{
    public int primeInt = 1;
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;//chara_neighbor1_happy
    public GameObject ArtChar1b;//chara_neighbor1_excited
    public GameObject ArtChar1c;//chara_neighbor1_thinking
    public GameObject prop_flyer;
    public GameObject prop_grantbooklet;
    public GameObject ArtBg1;//bg_library
    public GameObject Choice1a;//it was great
    public GameObject Choice1b;//it was fine
    public GameObject NextScene1Button;//explore the backyard
    public GameObject NextScene2Button;//go find the hoa lady
    public GameObject NextScene3Button;//head to the library
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
        prop_flyer.SetActive(false);
        prop_grantbooklet.SetActive(false);
        ArtBg1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
            Char1name.text = playerName;
            Char1speech.text = "You know it's a wonder I haven't been to the library earlier";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            prop_flyer.SetActive(true);
            DialogueDisplay.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            prop_flyer.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Yo! An incredibly convenient flyer about the thing the neighbor's kid is into!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 5)
        {
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Did I hear there are children into astronomy?";

        }
        else if (primeInt == 6)
        {

            Char1name.text = playerName;
            Char1speech.text = "Yeah, my neighbor's daughter.";
            Char2name.text = "";
            Char2speech.text = " ";

        }
        else if (primeInt == 7)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Oh, that's fantastic! I'm delighted.";

        }
        else if (primeInt == 8)
        {

            Char1name.text = playerName;
            Char1speech.text = "It's pretty cool of her. Who are you?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 9)
        {
            ArtChar1b.SetActive (false);
            ArtChar1a.SetActive (true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Oh, how rude of me! I was so caught up in the whimsy and joy of young people being interested in the stars.";

        }
        else if (primeInt == 10)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = " I'm the head of the Hobbyist Astronomy Organization.";

        }
        else if (primeInt == 11)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "I see you've come across our flyer. Are you interested in learning about astronomy?";

        }
        else if (primeInt == 12)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "You should come to our meeting next week! There will also be themed snacks.";
            primeInt = 29;

        }
      
        // after choice 1b
        else if (primeInt == 21)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "Ahh, you're missing out. I can connect you with the Ground Hobbyist sometime";
            primeInt = 29;


        }
        //conversation continues from both story choices:
        else if (primeInt == 30)
        {
            ArtChar1a.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Regardless of my interest in the group, do you have any resources for my neighbor's kid?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 31)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "Ah, the enlightened teen, yes, I do. We have little booklets with information about a grant program to build a home rooftop observatory.";

        }
        else if (primeInt == 32)
        {
            DialogueDisplay.SetActive(false);
            prop_grantbooklet.SetActive(true);
            ArtChar1c.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 33)
        {
            DialogueDisplay.SetActive(true);
            prop_grantbooklet.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oh, the HOA doesn't allow for things being on the roof.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 34)
        {
            ArtChar1c.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "Not an issue, it's a national government program, it's illegal to block it.";
        }

        else if (primeInt == 35)
        {

            Char1name.text = playerName;
            Char1speech.text = "Wow, that's fantastic news, thank you so much.";
            Char2name.text = "";
            Char2speech.text = "";

        }

        else if (primeInt == 36)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Hobbyist";
            Char2speech.text = "No problem, tell her to come to our next meeting, we have a couple other teens who plan to show up.";

        }
        else if (primeInt == 37)
        {
            Char1name.text = playerName;
            Char1speech.text = "I will, thank you so much.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 38)
        {
            ArtChar1b.SetActive(false);
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
            Char1speech.text = "I'm always down to know more!";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 15;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice1bFunct()
        {
            Char1name.text = playerName;
            Char1speech.text = "Nah, I prefer focusing on the planet around me.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 20;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }


        public void SceneChange1()
        {
            SceneManager.LoadScene("Scene5a1");
        }
        public void SceneChange2()
        {
            SceneManager.LoadScene("Scene5a2");
        }
        public void SceneChange3()
        {
            SceneManager.LoadScene("Scene4b");
        }

    }