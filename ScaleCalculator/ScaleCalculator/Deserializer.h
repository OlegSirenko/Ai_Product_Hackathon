#pragma once

#include <vector>
#include "FlatSurface.h"
#include "SingleVanishingPoint_simplified.h"
#include "DoubleVanishingPoint.h"
#include "Region.h"
#include <string>
#include <fstream>
#include "json.hpp"
using json = nlohmann::json;

std::vector< std::unique_ptr<Region>> DeserializeImageConfiguration(std::string fileName) {
	std::ifstream f(fileName);
	json data = json::parse(f);

	std::vector<std::unique_ptr<Region>> list;

	for (const auto &segment : data["FlatSurfaces"]) {
		auto item = std::make_unique<FlatSurface>();
		item->Deserialize(segment);
		list.push_back(std::move(item));
	}

	for (const auto& segment : data["SingleVanishingPoints"]) {
		auto item = std::make_unique<SingleVanishingPoint_simplified>();
		item->Deserialize(segment);
		list.push_back(std::move(item));
	}

	for (const auto& segment : data["DoubleVanishingPoints"]) {
		auto item = std::make_unique<DoubleVanishingPoint>();
		item->Deserialize(segment);
		list.push_back(std::move(item));
	}

	return list;
}