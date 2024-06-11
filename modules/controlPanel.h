//
// Created by tehnokrat on 6/10/24.
//

#ifndef AI_PRODUCT_HACKATHON_CONTROLPANEL_H
#define AI_PRODUCT_HACKATHON_CONTROLPANEL_H

#include <string>
#include <vector>
#include "imgui.h"
#include "imageProcessor.h"


class ControlPanel {
public:
    void Render();
    void LoadTexturesFromDirectory(const std::string& directoryPath);
private:
    std::string name_of_item;
    double width, length, height;
    char buffer[256] = {0};  // Initialize all elements to zero
    ImTextureID current_item_texture = ImageProcessor::GetTexture("/home/tehnokrat/Downloads/gartentisch-teak-massiv-colchester-beistelltisch-quadratisch-54x54cm-niedrig-hochwertig-frontansicht_550x550 1.png");
    std::vector<ImTextureID> textures;

};


#endif //AI_PRODUCT_HACKATHON_CONTROLPANEL_H