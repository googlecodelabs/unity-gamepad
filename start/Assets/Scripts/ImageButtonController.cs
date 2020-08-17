// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ImageButtonController : MonoBehaviour
{
    public Image buttonImage;
    public Text buttonText;

    // Reference to the image to update when a button is selected
    private Image currentImage;

    private void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetupButton(string assetPath, Sprite newSprite,
        Image currentImageRef)
    {
        buttonImage.sprite = newSprite;
        currentImage = currentImageRef;

        // Trim the path and just use the asset name for the button text
        buttonText.text = Path.GetFileName(assetPath);
    }

    public void ImageButtonOnClick()
    {
        currentImage.sprite = buttonImage.sprite;
    }
}
