﻿using MessagePack;
using UnityEngine;

namespace LightTogger.Koikatu
{
    internal class LayerDataContainer : MonoBehaviour
    {
        public int DefaultLayer;
    }

    [MessagePackObject(true)]
    public class LayerSaveData
    {
        public int DefaultLayer;
        public int NewLayer;
        public int ObjectId;
    }
}
