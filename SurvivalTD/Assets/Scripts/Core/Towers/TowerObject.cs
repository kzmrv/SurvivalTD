using System;
using UnityEngine;

namespace TD
{
    public class TowerObject : MonoBehaviour
    {
        public abstract class Tower
        {
            public float Hp;
            public GameObject Prefab;
            public virtual void Shoot()
            {
                throw new NotImplementedException();
            }
        }
    }
}