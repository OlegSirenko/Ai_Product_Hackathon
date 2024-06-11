cmake_minimum_required(VERSION 3.28)
project(Ai_Product_Hackathon)

find_package(GLEW REQUIRED)

add_subdirectory(imgui)
include_directories(modules external)

set(CMAKE_CXX_STANDARD 17)

add_executable(Ai_Product_Hackathon main.cpp
        modules/controlPanel.cpp
        modules/controlPanel.h
        modules/imageProcessor.cpp
        modules/imageProcessor.h
        external/stb_image.h
        modules/Item.cpp
        modules/Item.h
        modules/imageWindow.h
        modules/imageWindow.cpp)
target_link_libraries(Ai_Product_Hackathon PUBLIC imgui imgui-glfw imgui-opengl3 GLEW::GLEW)
