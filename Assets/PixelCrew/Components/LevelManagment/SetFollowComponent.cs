using System;
using Cinemachine;
using PixelCrew.Creatures.Hero;
using UnityEngine;

namespace PixelCrew.Components.LevelManagment
{
    [RequireComponent(typeof(CinemachineVirtualCamera))]
    
    public class SetFollowComponent: MonoBehaviour
    {
        private void Start()
        {
            var vCamera = GetComponent<CinemachineVirtualCamera>();
            vCamera.Follow = FindObjectOfType<Heroes>().transform; 
        }
    }
}