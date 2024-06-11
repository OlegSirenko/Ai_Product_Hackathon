//
// Created by tehnokrat on 6/10/24.
//

#include <iostream>
#include "controlPanel.h"
#include "imageProcessor.h"
#include "filesystem"

void ControlPanel::Render() {
    if(ImGui::Begin("Control Panel")){
        if(ImGui::BeginChild("PropImage", ImVec2(200,150))){
            ImGui::ImageButton("Image of prop",  current_item_texture, ImVec2(140, 140));
        }
        ImGui::EndChild();
        ImGui::SameLine();
        if(ImGui::BeginChild("Inspector",ImVec2(400, 150)) ){
            strncpy(buffer, name_of_item.c_str(), sizeof(buffer));
            buffer[sizeof(buffer) - 1] = 0;  // Ensure null-termination
            if (ImGui::InputText("Name", buffer, sizeof(buffer))) {
                // Copy the buffer back to the std::string
                name_of_item = buffer;
            }
            ImGui::InputDouble("Width", &width);
            ImGui::InputDouble("Length", &length);
            ImGui::InputDouble("Height", &height);
            // Display the current value of the std::string
            ImGui::Text("Current string is: %s", name_of_item.c_str());
        }
        ImGui::EndChild();

        ImGui::SeparatorText("Items");
        if(ImGui::BeginChild("All props")){
            int counter = 0;
            for (ImTextureID texture : textures) {
                if(ImGui::ImageButton(std::string("Image of prop"+std::to_string(counter)).c_str(), texture, ImVec2(128, 128))){
                    current_item_texture = texture;
                    std::cout<<"Button pressed"<<std::endl;
                }
                counter++;
                if (counter % 3 != 0)  // if counter is not divisible by 3
                    ImGui::SameLine();
                else
                    ImGui::NewLine();  // move to next line after every 3 images
            }
            current_item_texture = textures.front();
        }
        ImGui::EndChild();
    }
    ImGui::End();
}

void ControlPanel::LoadTexturesFromDirectory(const std::string &directoryPath) {
    for (const auto& entry : std::filesystem::directory_iterator(directoryPath)) {
        if (entry.is_regular_file()) {
            std::string filePath = entry.path().string();
            ImTextureID texture = ImageProcessor::GetTexture(filePath.c_str());
            textures.push_back(texture);
        }
    }
}
