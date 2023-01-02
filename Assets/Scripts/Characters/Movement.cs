using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigi;
    [SerializeField] private float velocity;
    [SerializeField] private InputCustom input;
    private InputCustom _inputTemplate;

    public void Configurate(InputCustom inputTemplate)
    {
        _inputTemplate = inputTemplate;
    }

    private void Awake()
    {
        Configurate(input);
    }

    private void Update()
    {
        rigi.velocity = _inputTemplate.Direction * (velocity * Time.deltaTime);
    }
}