//-----------------------------------------------------------------------
// <copyright file="SwitchVideos.cs" company="Google Inc.">
// Copyright (C) 2016 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleVR.VideoDemo
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;
	using UnityEngine.SceneManagement;


    /// <summary>
    /// A top-level container for different videos which can be loaded or switched between.
    /// </summary>
    public class SwitchVideos : MonoBehaviour
    {
        /// <summary>The local video sample.</summary>
        public GameObject localVideoSample;

        /// <summary>The dash video sample.</summary>
        public GameObject dashVideoSample;

        /// <summary>The pano video sample.</summary>
        public GameObject panoVideoSample;

        /// <summary>Text indicating a library is missing.</summary>
        public Text missingLibText;

        private GameObject[] videoSamples;

        /// <summary>Called by this instance's Awake step.</summary>
        public void Awake()
        {
        }

        /// <summary>Shows the main menu.</summary>
        public void ShowMainMenu()
        {
            GetComponent<Canvas>().enabled = true;
        }

        /// <summary>Called on the Flat Local event.</summary>
        public void OnFlatLocal()
        {
            SceneManager.LoadScene("HelloVR");
        }

        /// <summary>Called on the Dash event.</summary>
        public void OnDash()
        {
            SceneManager.LoadScene("Communitech");
        }

        private void ShowSample(int index)
        {
        }
    }
}
