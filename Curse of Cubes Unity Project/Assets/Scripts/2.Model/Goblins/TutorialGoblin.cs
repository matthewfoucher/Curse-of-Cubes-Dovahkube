﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialGoblin : MonoBehaviour
{
    public GameObject player;
    public Text dialog0;

    public Button dialog1;
    public Button dialog2;

    public RawImage box;
    private bool pressed = false;
    private EnemyAttack aggro;
    int dialogueLevel; // Which part of the dialogue we are in.
    // Use this for initialization
    void Start()
    {
        box.gameObject.SetActive(false);
        aggro = GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Player").GetComponent<PlayerAttack>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<SmoothMouseLook>().enabled = false;

            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance <= 5.0f)
            {
                pressed = true;
                transform.LookAt(player.transform);
                box.gameObject.SetActive(true);
                dialog0.gameObject.SetActive(true);
                dialog1.gameObject.SetActive(true);
                dialog2.gameObject.SetActive(true);

                dialog0.text = "Yaargh, welcome, welcome. If yargh confused let me break down thar controls.";
                dialog1.GetComponentInChildren<Text>().text = "Um, I would rather not.";
                dialog2.GetComponentInChildren<Text>().text = "... What?";

                dialog1.onClick.AddListener(Um);
                dialog2.onClick.AddListener(What);
            }
            else if (pressed == true)
            {
                pressed = false;
                box.gameObject.SetActive(false);
            }
        }
    }

    void Um()
    {
        dialog0.gameObject.SetActive(false);
        dialog1.gameObject.SetActive(false);
        dialog2.gameObject.SetActive(false);
        box.gameObject.SetActive(false);

        GameObject.Find("Player").GetComponent<PlayerAttack>().enabled = true;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<SmoothMouseLook>().enabled = true;
    }

    void What()
    {
        dialog0.text = "WASD to move of course. Space to hop hop. Shift to slide around real quickie.";
        dialog1.GetComponentInChildren<Text>().text = "What are you talking about?";
        dialog2.gameObject.SetActive(false);

        dialog1.onClick.RemoveAllListeners();
        dialog1.onClick.AddListener(Whatare);
    }

    void Whatare()
    {
        dialog0.text = "Move yaargh mousie around to move thar cam. Left click to attack to hearts desire. Move thar cross hairs over an item to put it in yur pocket and over someone and press E to talkie... but you musta figured that out already to talk to me yarharhar.";
        dialog1.GetComponentInChildren<Text>().text = "Mousies... WHAT? I don't understand what you're saying. Why are you green too?";
        dialog2.gameObject.SetActive(false);

        dialog1.onClick.RemoveAllListeners();
        dialog1.onClick.AddListener(Mousies);
    }

    void Mousies()
    {
        dialog0.text = "Yarhar... Press Q to use tha health potions. And mostie importantly press I to open up thar inventory to see all yees items and J for thar questies. \n\n Oh Ima green cus Ima a goblin. FITE ME!!";
        dialog1.GetComponentInChildren<Text>().text = "BRING IT!";
        dialog2.gameObject.SetActive(false);
        dialog1.onClick.RemoveAllListeners();

        dialog1.onClick.RemoveAllListeners();
        dialog1.onClick.AddListener(Bring);
    }

    void Bring()
    {
        box.gameObject.SetActive(false);
        dialog0.gameObject.SetActive(false);
        aggro.hostile = true;

        GameObject.Find("Player").GetComponent<PlayerAttack>().enabled = true;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<SmoothMouseLook>().enabled = true;
    }
}