using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour
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
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
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
        Debug.Log("primeInt = " + primeInt);
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I guess I should go and meet my other neighbors. I can't show up empty handed, maybe I can offer some of that soda I just bought?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "<i><b> knock knock </i></b>";
            Char2name.text = "";
            Char2speech.text = "";
      
        }
        else if (primeInt == 4)
        {	
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Dude, someone's at the door... I'LL COME OUT IN JUST A SEC, BRO!";
        }
        else if (primeInt == 5)
        {
            ArtBg1.SetActive(true);
            ArtBg2.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "OOOHHH! Hey, you must be the new neighbor! And you brought drinks! That's gonna be perfect for the sick party I'm gonna throw this weekend! Thanks man!";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "A party? Is it someone's birthday?";
            Char2name.text = "";
            Char2speech.text = " ";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Naw man, my best dudebro, Slungus is movin' away soon for his sick new job...  ";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "It's a total bummer!";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "But, I'm gonna throw him the BEST GOING AWAY PARTY IN THE WHOLE GALAXY!!!";
           
        }
        else if (primeInt ==10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, that sounds like a lot of fun!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "DUDE. THAT JUST GAVE ME A SICK IDEA!!! I'm trying to get everyone I can to show up, would you wanna stop by?";
        }
        else if (primeInt == 12)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "We'll have drinks, games, and loud music! IT'S GONNA BE FLORPING AWESOME!!!";
        }
        else if (primeInt == 13)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "What do you think?";
            // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }



//After choice 1a
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "YEAAH, LET'S FLORPING GOOO!!!";
            
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Let's go to the plnning committee!";
           
        }
        else if (primeInt == 22)
        {

            Char1name.text = "YOU";
            Char1speech.text = "Um... the what?";
            Char2name.text = "";
            Char2speech.text = "";
           // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

    //after choice 1b
        else if (primeInt == 30)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Awww man...";
        }

        else if (primeInt == 31)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Splatthew";
            Char2speech.text = "Well if you change your mind feel free to stop by, dude!";
        }
        else if (primeInt == 32)
        {

            Char1name.text = "You";
            Char1speech.text = "(Well, I guess I'll return my neighbor's plate)";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "YEAH, MY FELLOW DUDEBRO! LET'S PARTY!!!!";
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
        Char1name.text = "YOU";
        Char1speech.text = "Maybe not... I still have to settle down.";
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
        SceneManager.LoadScene("Scene3b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3a");
    }
}