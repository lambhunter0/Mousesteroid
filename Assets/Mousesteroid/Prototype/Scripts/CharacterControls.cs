﻿using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] private GameObject actor;
    [SerializeField] private float moveSpeedModifier = 3;

    private Vector3 mousePosition;
    private Vector3 lookDirection;

    public void FixedUpdate()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        Quaternion lookRotation = GetMouseInput();
        actor.transform.rotation = lookRotation;

        Vector3 moveDirection = GetInput();
        actor.transform.Translate(moveDirection * Time.deltaTime * moveSpeedModifier, Space.World);
    }

    private Vector3 GetInput()
    {
        Vector3 input = Vector3.zero;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        return input;
    }

    private Quaternion GetMouseInput()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 relativeMousePos = new Vector2(mousePos.x - (Screen.width/2), mousePos.y - (Screen.height/2));
        //Debug.Log(""+ relativeMousePos.x+" "+ relativeMousePos.y);
        float angle = Mathf.Atan2(relativeMousePos.y, relativeMousePos.x) * Mathf.Rad2Deg - 90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        return rotation;
    }
}