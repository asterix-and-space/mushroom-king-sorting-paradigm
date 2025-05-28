# Mushroom-King Sort (MK-Sort) Example
#
# Copyright © 1965–2025 asterix-and-space organisation. All rights reserved.
#
# This code is strictly proprietary. See licence.txt in the repository root for terms.

def mk_sort(data):
    """
    Sorts a list of (mushroom_mentions, reign_duration) tuples by mushroom_mentions descending,
    then by reign_duration ascending.
    """
    return sorted(data, key=lambda x: (-x[0], x[1]))

if __name__ == "__main__":
    # Example usage
    dataset = [
        (42, 10),
        (42, 5),
        (7, 20),
        (100, 1)
    ]
    result = mk_sort(dataset)
    print("I am the mushroom king")
    print(result)
