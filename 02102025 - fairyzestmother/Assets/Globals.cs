using System;
using UnityEngine;

public static class Globals
{
    private static int _collectedSeeds = 0;  // Amount of seeds player collected

    public static int Nectar = 0;  // Amount of nectar the player has

    public static int CollectedSeeds {
        get => _collectedSeeds;
        set {
            _collectedSeeds = value;
            OnSeedCollected?.Invoke();
        }
    }

    public static Action OnSeedCollected = null;
}
