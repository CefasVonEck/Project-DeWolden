using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private const string IDLE = "idle";
    private const string WALK = "walk";
    private const string PUNCH = "punch";
    private const string FRONT = "front";
    private const string SIDE = "side";
    private const string BACK = "back";

    [Header("References")]
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject waterParticles;
    [SerializeField] private Transform waterTransform;

    private Direction direction;

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }

    private void Start()
    {

    }

}
