using System;
using UnityEngine;

public static class Globals
{
    private static int _collectedSeeds = 0;  // Amount of seeds player collected

    public static int Nectar = 1000;  // Amount of nectar the player has
    // why does this not work

    public static int CollectedSeeds {
        get => _collectedSeeds;
        set {
            _collectedSeeds = value;
            OnSeedCollected?.Invoke();
        }
    }

    public static Action OnSeedCollected = null;
}
