﻿// ScaleCalculator.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Measures.h"
#include "SingleVanishingPoint_simplified.h"
#include "DoubleVanishingPoint.h"
#include "Deserializer.h"

int main()
{
    //SingleVanishingPoint_simplified vp({},LineSegment(Point(1343,428), Point(1343,1002), 300), Point(365, 770));

    //auto d = vp.buildEndpoint_approximate(Point(1784, 1108), LineSegment(Point(0,10), Point(0,0), 300));

    //DoubleVanishingPoint dp({}, LineSegment(Point(500, 1055), Point(1115, 1015), 280), Point(5144, 766), LineSegment(Point(1816, 1135), Point(2172, 1226), 70), Point(365, 770));
    auto regions = DeserializeImageConfiguration("D:\\undefined.json");

    auto d = regions[0]->buildEndpoint_approximate(Point(100, 1500), LineSegment(Point(0, 10), Point(0, 0), 100));
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
