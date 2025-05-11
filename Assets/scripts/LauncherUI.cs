using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class LauncherUI : MonoBehaviour
{
    public InputField nicknameInput;
    public Button playButton;

    void Start()
    {
        playButton.onClick.AddListener(OnPlayClicked);
    }

    void OnPlayClicked()
    {
        string nickname = nicknameInput.text;

        if (string.IsNullOrEmpty(nickname))
        {
            Debug.LogWarning("Nickname is empty.");
            return;
        }

        PhotonNetwork.NickName = nickname;

        // On active le Launcher script une fois que le pseudo est défini
        FindObjectOfType<Launcher>().enabled = true;
    }
}
