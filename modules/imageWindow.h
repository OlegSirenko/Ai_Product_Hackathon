//
// Created by tehnokrat on 6/10/24.
//

#ifndef AI_PRODUCT_HACKATHON_IMAGEWINDOW_H
#define AI_PRODUCT_HACKATHON_IMAGEWINDOW_H

#include <iostream>
#include "controlPanel.h"
#include "imageProcessor.h"
#include "filesystem"

class ImageWindow {
public:
    void Render();
private:
    ImTextureID current_scene_texture = ImageProcessor::GetTexture("/home/tehnokrat/Ai_Product_Hackathon/cmake-build-debug/scenes/2024_06_05_0k3_Kleki 1.png");
};


#endif //AI_PRODUCT_HACKATHON_IMAGEWINDOW_H
