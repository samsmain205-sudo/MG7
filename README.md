# MG7
## Devlog
  
  We use Update() so we can update every frame and calculate the distance between the tree and the player. Since we only need to calculate the distance once per frame, we do this outside the for loop so they don't disappear each time. An array is used for the list of birds. We use a for loop to loop through all of the birds and set their GameObjects to true if the distance is less than or equal to _interactDistance. Meaning, if the player approaches a certain distance, show all the sparrows.

  
## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
