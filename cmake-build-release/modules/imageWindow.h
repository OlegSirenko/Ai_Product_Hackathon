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
    void LoadTexturesFromDirectory(const std::string &directoryPath);
private:
    ImTextureID current_scene_texture;
    std::vector<ImTextureID> textures;
};


#endif //AI_PRODUCT_HACKATHON_IMAGEWINDOW_H
