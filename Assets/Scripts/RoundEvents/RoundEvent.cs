﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class RoundEvent{

    public string eventName;
    public int eventID;
    public int eventPrice;
    public string eventDescription;
    public Texture2D eventImage;

    //이미지는 이벤트이름(eventName)과 똑같은 파일명을 가진 걸 자동으로 사용하도록 했음
    public RoundEvent(string name, int ID, int price, string desc)
    {
        eventName = name;
        eventID = ID;
        eventPrice = price;
        eventDescription = desc;
        eventImage = Resources.Load<Texture2D>("Event Icons/" + name);
    }

    public RoundEvent()
    {

    }
}