cmake_minimum_required(VERSION 3.26)
project(AI_Product_Hackathon)

set(CMAKE_CXX_STANDARD 17)
find_package( OpenCV REQUIRED )
include_directories( ${OpenCV_INCLUDE_DIRS} )
add_executable(AI_Product_Hackathon main.cpp)
target_link_libraries(AI_Product_Hackathon ${OpenCV_LIBS})

