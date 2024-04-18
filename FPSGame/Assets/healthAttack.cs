using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeoFPS.ModularFirearms;

namespace NeoFPS.ModularFirearms
{
    public class healthAttack : MonoBehaviour
    {

        public int Health;

        public void damage(int value)
        {
            Health -= value;

        }
    }
}