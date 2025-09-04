# Infinity Mining Density

A Stationeers mod that prevents mining density from dropping below 0.1 and provides configurable ore yield when density reaches the floor.

## Description

In the endgame, I like to build a spaceport where rockets continuously fly on their own to mine ice. Since rockets were replaced with new ones controlled by computer, this became impossible because mining resources are finite. This mod changes the situation. 

Now, when density reaches 0.1, it stops decreasing, but mining yield drops to a configurable percentage (default 25%). As a result, rockets become less efficient but fully automated. This allows you to completely step away from base management and enjoy your creations from the sidelines, only occasionally changing consumables.

## Features

- Prevents mining density from dropping below 0.1
- Configurable mining yield multiplier when density reaches the minimum floor (default 25%)
- Enables fully automated mining operations
- Save safe - does not affect save file integrity
- Configuration file for customizing yield multiplier

## Requirements

**IMPORTANT**: This mod requires [StationeersLaunchPad](https://github.com/StationeersLaunchPad/StationeersLaunchPad) to run properly due to configuration system dependencies. It will NOT work as a standalone BepInEx plugin.

- [StationeersLaunchPad](https://github.com/StationeersLaunchPad/StationeersLaunchPad) (includes BepInEx)

## Installation

### Prerequisites
1. Install [StationeersLaunchPad](https://github.com/StationeersLaunchPad/StationeersLaunchPad)
2. Make sure Stationeers is closed before installation

### Build from Source
1. Clone this repository: `git clone https://github.com/Allexin/Stationeers_InfinityMiningDensity.git`
2. Open the project in your preferred C# IDE (Visual Studio, Rider, etc.)
3. Add references to required Stationeers assemblies:
   - `Assembly-CSharp.dll` (from Stationeers game directory)
   - BepInEx libraries (included with StationeersLaunchPad)
4. Build the project to generate `InfinityMiningDensity.dll`
5. Copy the compiled `.dll` file to your Stationeers mods directory:
   - StationeersLaunchPad mods path: `%USERPROFILE%\AppData\Documents\My Games\Stationeers\mods\InfinityMiningDensity`
6. Copy Aboud folder in same place

## Configuration

The mod creates a configuration file that allows you to customize the yield multiplier:

- **DepletedMultiplier**: Controls how much ore is yielded when density is at minimum (default: 0.25 = 25%)
  - Range: 0.1 to 1.0
  - Higher values = more ore when depleted
  - Lower values = less ore when depleted

Configuration file location: `BepInEx/config/basovav.infinityminingdensity.cfg`

## Usage

Once installed, the mod works automatically:
1. Mining operations will maintain a minimum density of 0.1
2. When density reaches 0.1, yield is reduced by the configured multiplier
3. Deposits never become completely depleted
4. Allows for infinite but less efficient resource extraction

## Alternative Installation Methods

- **Steam Workshop**: [Infinity Mining Density](https://steamcommunity.com/sharedfiles/filedetails/?id=3561761270) (may not include latest configuration features)

## Author

@!!ex