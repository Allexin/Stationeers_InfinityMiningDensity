# Infinity Mining Density

A Stationeers mod that prevents mining density from dropping below 0.1 and provides minimum ore yield when density reaches the floor.

## Description

In the endgame, I like to build a spaceport where rockets continuously fly on their own to mine ice. Since rockets were replaced with new ones controlled by computer, this became impossible because mining resources are finite. This mod changes the situation. 

Now, when density reaches 0.1, it stops decreasing, but mining yield drops to 25%. As a result, rockets become less efficient but fully automated. This allows you to completely step away from base management and enjoy your creations from the sidelines, only occasionally changing consumables.

## Features

- Prevents mining density from dropping below 0.1
- Provides 25% mining yield when density reaches the minimum floor
- Enables fully automated mining operations
- Save safe - does not affect save file integrity

## Requirements

This is a Plugin Mod that requires:
- [BepInEx](https://github.com/BepInEx/BepInEx)
- [StationeersLaunchPad](https://github.com/StationeersLaunchPad/StationeersLaunchPad) plugin

## Installation

### Prerequisites
1. Install [StationeersLaunchPad](https://github.com/StationeersLaunchPad/StationeersLaunchPad) (includes BepInEx)
2. Make sure Stationeers is closed before installation

### From GitHub
1. Download the latest release from the [Releases](../../releases) page
2. Extract the downloaded archive
3. Copy the mod files to your Stationeers BepInEx plugins directory:
   - Default path: `%USERPROFILE%\AppData\LocalLow\Rocketwerkz\Stationeers\BepInEx\plugins\`
   - Or navigate to your Stationeers installation folder: `\BepInEx\plugins\`
4. Launch Stationeers through StationeersLaunchPad

### Manual Build from Source
1. Clone this repository: `git clone https://github.com/Allexin/Stationeers_InfinityMiningDensity.git`
2. Open the project in your preferred C# IDE
3. Build the project (requires Stationeers game references)
4. Copy the compiled `.dll` file to the BepInEx plugins directory

## Usage

Once installed, the mod works automatically. Mining operations will maintain a minimum density of 0.1 with reduced yield, allowing for infinite but less efficient resource extraction.

## Alternative Installation Methods

- **Steam Workshop**: [Infinity Mining Density](https://steamcommunity.com/sharedfiles/filedetails/?id=2876605527)

## Author

@!!ex