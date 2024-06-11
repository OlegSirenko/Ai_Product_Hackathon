#include "imageProcessor.h"



ImTextureID ImageProcessor::GetTexture(const char *filepath) {
    int width, height, channels;
    unsigned char* image = stbi_load(filepath, &width, &height, &channels, 0);
    GLuint textureId;
    glGenTextures(1, &textureId);
    glBindTexture(GL_TEXTURE_2D, textureId);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
    glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, image);
    stbi_image_free(image);
    return (void*)(intptr_t)textureId;
}
