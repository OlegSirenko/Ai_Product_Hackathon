//
// Created by tehnokrat on 6/10/24.
//

#include "imageWindow.h"



void ImageWindow::Render() {
    if(ImGui::Begin("Scene")){
        ImGui::Image(current_scene_texture, ImVec2(900, 900));
    }
    ImGui::End();

}

void ImageWindow::LoadTexturesFromDirectory(const std::string &directoryPath) {
    for (const auto& entry : std::filesystem::directory_iterator(directoryPath)) {
        if (entry.is_regular_file()) {
            std::string filePath = entry.path().string();
            ImTextureID texture = ImageProcessor::GetTexture(filePath.c_str());
            textures.push_back(texture);
        }
        current_scene_texture = textures.front();
    }
}
