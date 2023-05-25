using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveSettingsButton : MonoBehaviour
{
    public Slider soundSlider; // reference to the sound slider
    public Slider musicSlider; // reference to the music slider
    public Slider sensitivitySlider; // reference to the sensitivity slider

    private const string SOUND_KEY = "sound"; // key for the sound setting in player preferences
    private const string MUSIC_KEY = "music"; // key for the music setting in player preferences
    private const string SENSITIVITY_KEY = "sensitivity"; // key for the sensitivity setting in player preferences

    public void SaveSettingsAndReturnToMenu()
    {
        // Save the sound, music, and sensitivity settings to player preferences
        PlayerPrefs.SetFloat(SOUND_KEY, soundSlider.value);
        PlayerPrefs.SetFloat(MUSIC_KEY, musicSlider.value);
        PlayerPrefs.SetFloat(SENSITIVITY_KEY, sensitivitySlider.value);
        PlayerPrefs.Save(); // Ensure changes are saved immediately

        // Return to the menu scene
        SceneManager.LoadScene("Menu");
    }

    private void Start()
    {
        // Load the saved sound, music, and sensitivity settings, and set the sliders' positions
        if (PlayerPrefs.HasKey(SOUND_KEY))
        {
            float soundValue = PlayerPrefs.GetFloat(SOUND_KEY);
            soundSlider.value = soundValue;
        }

        if (PlayerPrefs.HasKey(MUSIC_KEY))
        {
            float musicValue = PlayerPrefs.GetFloat(MUSIC_KEY);
            musicSlider.value = musicValue;
        }

        if (PlayerPrefs.HasKey(SENSITIVITY_KEY))
        {
            float sensitivityValue = PlayerPrefs.GetFloat(SENSITIVITY_KEY);
            sensitivitySlider.value = sensitivityValue;
        }
    }
}