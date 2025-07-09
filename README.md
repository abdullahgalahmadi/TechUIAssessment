# Tech UI Skills Assessment - Unity Project

## Overview

This Unity project is a submission for the 2025 Steer Elite Internship Program – Tech UI Track. It includes all the required UI elements, animations, and interactions as described in the assessment instructions.

## What’s Included

### 1. Buttons and Hover Effects
- The scene includes three buttons: Play, Settings, and Quit
- Each button is styled and placed to match the assessment reference image
- When the mouse hovers over a button:
  - The button text changes to orange
  - The button border changes from gray to orange
  - A red hand image appears next to the button and moves to align with it
- When the mouse leaves the button:
  - The text color returns to black
  - The border color returns to gray
  - The red hand disappears

This functionality is implemented using two scripts:
- `HandFollowHover.cs`: shows and moves the red hand
- `ButtonTextColorChanger.cs`: changes the button text color

### 2. Idle Animation
- The "INTRO TO" wooden label rotates slightly back and forth
- The animation loops continuously without jumping
- This was created using Unity's animation tools with keyframes on the Z-axis (rotation)

### 3. Responsive Layout
- The UI layout works in both portrait and landscape orientations
- Anchors and scaling are set to keep all elements in place when the screen size changes

## How to Run the Project

1. Open Unity Hub
2. Click "Open Project" and select the folder named `TechUIAssessment`
3. Open the scene located at `Assets/Scenes/SampleScene.unity`
4. Press Play to test the UI


## Notes

- The red hand is hidden by default and only becomes visible when hovering on a button
- The animation uses keyframes at frame 15, 5, 15 to create smooth rotation


## Status

All features from the assessment instructions are implemented and the project is complete.


