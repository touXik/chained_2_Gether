using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro; // Ajoute ceci pour utiliser TMP_InputField

public class LauncherUI : MonoBehaviour
{
    public TMP_InputField nicknameInput;  // ✅ TMP_InputField au lieu de InputField
    public Button playButton;
    public Launcher launcherScript;

    private void Start()
    {
        // Vérifie que tout est bien assigné dans l'inspector
        if (nicknameInput == null)
            Debug.LogError("nicknameInput n'est pas assigné dans le script LauncherUI.");
        if (playButton == null)
            Debug.LogError("playButton n'est pas assigné dans le script LauncherUI.");
        if (launcherScript == null)
            Debug.LogError("launcherScript n'est pas assigné dans le script LauncherUI.");

        // Ajoute l'action du bouton Play
        playButton.onClick.AddListener(Connect);
    }

    public void Connect()
    {
        string nickname = nicknameInput.text;

        if (!string.IsNullOrEmpty(nickname))
        {
            PhotonNetwork.NickName = nickname;
            launcherScript.gameObject.SetActive(true); // Active le GameObject contenant le script Launcher
            Debug.Log("Connexion avec le pseudo : " + nickname);
        }
        else
        {
            Debug.LogWarning("Le champ du pseudo est vide !");
        }
    }
}
