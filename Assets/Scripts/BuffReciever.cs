﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{

    private List<Buff> buffs;


    private void Start()
    {
        GameManager.Instance.buffRecieverContainer.Add(gameObject, this);
        buffs = new List<Buff>();
    }

    public void AddBuff(Buff buff)
    {
        if (!buffs.Contains(buff))
            buffs.Add(buff);
    }

    public void RemoteBuff(Buff buff)
    {
        if (buffs.Contains(buff))
            buffs.Remove(buff);
    }

}


