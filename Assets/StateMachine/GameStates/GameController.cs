using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class GameController : MonoBehaviour
{
    public PlayerOnCollideLogic playerOnCollideLogic;
    public TMP_Text stateText;
    public GameObject gameSetUpUI;
    public Button gameSetUpButton;
    public WeaponFollow playerWeaponFollowLogic;
    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioSource audioSource;
}
