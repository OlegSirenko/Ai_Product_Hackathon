//
// Created by tehnokrat on 6/10/24.
//

#ifndef AI_PRODUCT_HACKATHON_IMAGEPROCESSOR_H
#define AI_PRODUCT_HACKATHON_IMAGEPROCESSOR_H
#include "stb_image.h"

#include "imgui.h"
//#include <GL/glew.h>
#include <GLFW/glfw3.h> // Will drag system OpenGL headers

class ImageProcessor {
public:
    static ImTextureID GetTexture(const char* filepath);
};


#endif //AI_PRODUCT_HACKATHON_IMAGEPROCESSOR_H
