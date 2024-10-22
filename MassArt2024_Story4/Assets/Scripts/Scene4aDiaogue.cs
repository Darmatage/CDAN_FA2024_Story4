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

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
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
            Char1name.text = "YOU";
            Char1speech.text = "I should probably return the cookie plate before it gets lost in my hordes of boxes.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "<b><i>knock knock </b></i>";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "<b>COMING!</b>";

        }
        else if (primeInt == 5)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "<i>HELLO!</i>";

        }
        else if (primeInt == 6)
        {

            Char1name.text = "YOU";
            Char1speech.text = "Hi! I’m just bringing your plate back.";
            Char2name.text = "";
            Char2speech.text = " ";

        }
        else if (primeInt == 7)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Aw, you didn’t have to do that, I have plenty of plates.";

        }
        else if (primeInt == 8)
        {

            Char1name.text = "YOU";
            Char1speech.text = "No, I really did, my house is a mess and it would’ve been lost forever otherwise.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 9)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Whatever helps you sleep at night";

        }
        else if (primeInt == 10)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "<i>5H3RYL takes the plate from you</i>";

        }
        else if (primeInt == 11)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "What did you think of your first day?";

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
        else if (primeInt == 15)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I had a really fun time! I’m really enjoying having moved here so far.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 16)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "I’m glad! I’ve been living here for eight years so far and have yet to regret it even if the HOA lady makes me come close.";
            primeInt = 30;
        }

        // after choice 1b
        else if (primeInt == 20)
        {

            Char1name.text = "YOU";
            Char1speech.text = "It was okay, it’s hard to judge after just one day.";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "That makes sense I suppose. I’m sure you’ll warm up to it!";

            primeInt = 30;
        }

        // after choice 1c
        else if (primeInt == 25)
        {

            Char1name.text = "YOU";
            Char1speech.text = "It sucked and was awful, it’s a wonder anybody stays.";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 26)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "That feels harsh… I’m sure you’ll feel differently once you’re all settled in.";
            primeInt = 30;
        }

        //conversation continues from both story choices:
        else if (primeInt == 30)
        {

            Char1name.text = "YOU";
            Char1speech.text = "Of course, it’s only been one day. I’ll probably feel differently once it no longer takes me twenty minutes and several boxes to find anything.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 31)
        {

            Char1name.text = "YOU";
            Char1speech.text = "It took me an unspeakable amount of time to get dressed this morning.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 32)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Haha, I feel you. The family and I went off planet for a bit last summer and we still fish things out of the suitcase every now and then.";

        }
        else if (primeInt == 33)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 40)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "I’m slightly concerned by the scale of your response.";

        }

        else if (primeInt == 41)
        {

            Char1name.text = "YOU";
            Char1speech.text = "I’ve lived a colorful life, you don’t know where I’ve been.";
            Char2name.text = "";
            Char2speech.text = "";

        }

        else if (primeInt == 42)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Interesting… anyway that’s probably my daughter WHO ISN’T SUPPOSED TO BE ON THE ROOF!";

        }

        else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }

        else if (primeInt == 44)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 45)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = " It’s true, I don’t. But the HOA lady does! And she’s relentless";

        }
        else if (primeInt == 46)
        {

            Char1name.text = "YOU";
            Char1speech.text = "Relentless? She certainly was pushy about the pamphlets.";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 47)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 48)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "PERSISTENT WOMAN. She’s a persistent woman.";

        }
        else if (primeInt == 49)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 50)
        {

            Char1name.text = "YOU";
            Char1speech.text = "She’s banned you from looking at the sky?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 51)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Not quite.";

        }
        else if (primeInt == 52)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 53)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "The HOA lady is displeased with my daughter taking her astronomy stuff up on the roof at night. Keeps threatening to fine us.";


        }
        else if (primeInt == 54)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 55)
        {

            Char1name.text = "YOU";
            Char1speech.text = "I didn’t know drones and satellites took pictures of the neighborhood";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 56)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 57)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "AH! That was rude, go do homework";


        }
        else if (primeInt == 58)
        {

            Char1name.text = "YOU";
            Char1speech.text = "She seems rambunctious";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 59)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "She’s too bright for her own good. It’s what I get for taking her to the\r\nlibrary all the time.";


        }
        else if (primeInt == 60)
        {

            Char1name.text = "YOU";
            Char1speech.text = "The library!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 61)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "5H3RYL";
            Char2speech.text = "Yeah, the public library! You should go if you haven’t been yet. Everybody\r\nshould have a library card";


        }
        else if (primeInt == 62)
        {

            Char1name.text = "YOU";
            Char1speech.text = "Maybe I will go check it out.";
            Char2name.text = "";
            Char2speech.text = "";


        }
        else if (primeInt == 63)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
            NextScene3Button.SetActive(true);
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
            primeInt = 15;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice1bFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "I am standing in the middle of the road.";
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