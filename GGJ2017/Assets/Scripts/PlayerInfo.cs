﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    // Static (global) vars. Don't use globals, except for the GLOBAL GAME JAM!!!
    public static bool[] ClaimedPlayerIndices = new bool[] { false, false, false, false };

    // Public vars.
    public int PlayerIndex = -1;

    // Private vars.
    private Transform[] wizardModels = new Transform[4];

    void Start()
    {
        if (PlayerIndex == -1)
        {
            for (int i = 0; i < 4; ++i)
            {
                if (ClaimedPlayerIndices[i] == false)
                {
                    Debug.Log(gameObject.name + " with index " + i.ToString() + " has joined the game.");

                    PlayerIndex = i;

                    ClaimedPlayerIndices[i] = true;

                    SetCharacterModel();

                    break;
                }
            }
        }
    }

    private void SetCharacterModel()
    {
        wizardModels[0] = transform.Find("WizardBlue");
        wizardModels[1] = transform.Find("WizardGreen");
        wizardModels[2] = transform.Find("WizardRed");
        wizardModels[3] = transform.Find("WizardYellow");

        for (int i = 0; i < 4; ++i)
        {
            if (PlayerIndex == i)
            {
                wizardModels[i].gameObject.SetActive(true);
            }
            else
            {
                wizardModels[i].gameObject.SetActive(false);
            }
        }

        Debug.Log(gameObject.name + " is " + wizardModels[PlayerIndex].name);
    }
}
