﻿using UnityEngine;
using UnityEngine.UI;

public class HealthBarState : MonoBehaviour
{
    [SerializeField] private Sprite[] _healthBars;
    private GameSession _gameSession;
    
    private Image _image;

    private void Awake()
    {
        _gameSession = FindObjectOfType<GameSession>();
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        ChangeAnimationUI();
    }

    public void ChangeAnimationUI()
    {
        _image.sprite = _healthBars[_gameSession.PlayerLives];
    }
}
