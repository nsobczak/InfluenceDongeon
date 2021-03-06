﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatEnhancement : MonoBehaviour
{
    #region Attributes

    public BattlerController battler;

    public int hpMax, mpMax, atk, mag, def, res, init;
    public float fireRes, iceRes, thunderRes;

    #endregion
    
    //___________________________________________________

    #region Methods

    public void EnhanceStat(string stat, float amount, int duration)
    {
        switch (stat)
        {
            case "hpMax":
                hpMax += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "mpMax":
                mpMax += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "atk":
                atk += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "mag":
                mag += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "def":
                def += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "res":
                res += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "init":
                init += Mathf.RoundToInt(amount);
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "fireRes":
                fireRes += amount;
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "iceRes":
                iceRes += amount;
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
            case "thunderRes":
                thunderRes += amount;
                StartCoroutine(EnhanceEnd(stat, amount, duration, battler.turn));
                break;
        }
    }

    IEnumerator EnhanceEnd(string stat, float amount, int duration, int startTurn)
    {
        while (battler.turn - startTurn < duration)
        {
            yield return null;
        }

        switch (stat)
        {
            case "hpMax":
                hpMax -= Mathf.RoundToInt(amount);
                break;
            case "mpMax":
                mpMax -= Mathf.RoundToInt(amount);
                break;
            case "atk":
                atk -= Mathf.RoundToInt(amount);
                break;
            case "mag":
                mag -= Mathf.RoundToInt(amount);
                break;
            case "def":
                def -= Mathf.RoundToInt(amount);
                break;
            case "res":
                res -= Mathf.RoundToInt(amount);
                break;
            case "init":
                init -= Mathf.RoundToInt(amount);
                break;
            case "fireRes":
                fireRes -= amount;
                break;
            case "iceRes":
                iceRes -= amount;
                break;
            case "thunderRes":
                thunderRes -= amount;
                break;
        }
    }

    public void Reinit()
    {
        StopAllCoroutines();
        hpMax = mpMax = atk = mag = def = res = init = 0;
    }

    #endregion
}