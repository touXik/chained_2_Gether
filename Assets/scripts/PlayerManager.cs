using Photon.Pun;
using UnityEngine;

public class PlayerManager : MonoBehaviourPun
{
    void Update()
    {
        if (!photonView.IsMine) return;

        float move = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;
        transform.Translate(move, 0, 0);
    }
}

