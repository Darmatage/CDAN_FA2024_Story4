using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

        public static int HOAcomplaints = 0;
		public TMP_Text complaintsText;
		public GameObject complaintsBG; 
        public static string playerName = "YOU";

        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
				
				// Stat display:
				if (GameObject.FindWithTag("Complaints") != null){
					complaintsBG = GameObject.FindWithTag("Complaints");
				}
				DisplayStats();
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){ Resume(); }
                        else{ Pause(); }
                }
                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}

				
        }

		public void DisplayStats(){
			complaintsText.text = "COMPLAINTS: " + HOAcomplaints;
			
			if (HOAcomplaints <= 0){
				complaintsBG.SetActive(false);
			} 
			else {
				complaintsBG.SetActive(true);
			}

			if (HOAcomplaints >= 2){
				SceneManager.LoadScene("SceneLose_Complaints");
			}
		}

        public void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }


        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
                // Please also reset all static variables here, for new games!
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
    public void UpdateName(string newName)
    {
        playerName = newName;
        Debug.Log("name changed to " + playerName);
    }
    public string GetName()
    {
        return playerName;
    }
	
}
