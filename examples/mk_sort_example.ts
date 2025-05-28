// Mushroom-King Sort (MK-Sort) Example
//
// Copyright © 1965–2025 asterix-and-space organisation. All rights reserved.
//
// This code is strictly proprietary. See licence.txt in the repository root for terms.

type MushroomKingTuple = [number, number];

function mkSort(data: MushroomKingTuple[]): MushroomKingTuple[] {
    return data.sort((a, b) => {
        if (b[0] !== a[0]) return b[0] - a[0];
        return a[1] - b[1];
    });
}

const dataset: MushroomKingTuple[] = [
    [42, 10],
    [42, 5],
    [7, 20],
    [100, 1]
];

console.log("I am the mushroom king");
console.log(mkSort(dataset));
