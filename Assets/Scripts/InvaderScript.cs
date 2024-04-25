using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public Sprite[] animationSprites;

    public float animationTime;

    private SpriteRenderer _spriteRenderer;

    private int _animationFrame;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(animateSprite), this.animationTime, this.animationTime);
        
    }

    private void animateSprite()
    {

    }
}
