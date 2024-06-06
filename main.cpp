//
// Created by tehnokrat on 6/6/24.
//
#include <opencv2/opencv.hpp>
#include <fstream>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>

int main()
{
    // Load the image
    cv::Mat img = cv::imread("/home/tehnokrat/Pictures/500c63158d064dcf5af0a14224223025.jpg", cv::IMREAD_GRAYSCALE);

    // Check if image is loaded fine
    if(img.empty()){
        printf("Error opening image\n");
        return -1;
    }

    // Create a matrix of the same type and size as src (for edges)
    cv::Mat edges(img.size(), img.type());

    // Blur the image to reduce noise
    cv::blur(img, edges, cv::Size(3,3));

    // Apply Canny edge detection
    cv::Canny(edges, edges, 5, 70, 3);

    // Display the edges
    cv::namedWindow("Edges", cv::WINDOW_NORMAL);
    cv::imshow("Edges", edges);

    // Wait until user exit program by pressing a key
    cv::waitKey(0);

    return 0;
}
