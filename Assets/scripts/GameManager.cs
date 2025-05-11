using Photon.Pun;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
    }
}

