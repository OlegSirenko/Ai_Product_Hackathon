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
