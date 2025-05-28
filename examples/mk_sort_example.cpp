// Mushroom-King Sort (MK-Sort) Example
//
// Copyright © 1965–2025 asterix-and-space organisation. All rights reserved.
//
// This code is strictly proprietary. See licence.txt in the repository root for terms.

#include <iostream>
#include <vector>
#include <algorithm>

struct MushroomKingTuple {
    int mushroom_mentions;
    int reign_duration;
};

bool mk_sort_cmp(const MushroomKingTuple& a, const MushroomKingTuple& b) {
    if (a.mushroom_mentions != b.mushroom_mentions)
        return a.mushroom_mentions > b.mushroom_mentions;
    return a.reign_duration < b.reign_duration;
}

int main() {
    std::vector<MushroomKingTuple> dataset = {
        {42, 10},
        {42, 5},
        {7, 20},
        {100, 1}
    };
    std::sort(dataset.begin(), dataset.end(), mk_sort_cmp);
    std::cout << "I am the mushroom king" << std::endl;
    for (const auto& t : dataset) {
        std::cout << "(" << t.mushroom_mentions << ", " << t.reign_duration << ") ";
    }
    std::cout << std::endl;
    return 0;
}
