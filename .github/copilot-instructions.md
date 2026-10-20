# GitHub Copilot Instructions for Weather Control Device (Continued)

Welcome to the development guide for the **Weather Control Device (Continued)** mod for RimWorld! This guide will help you understand the mod's purpose, key features, and development practices, as well as provide you with instructions on how to effectively use GitHub Copilot for contributing to this project.

## Mod Overview and Purpose

**Weather Control Device (Continued)** is an updated and maintained version of the original mod by MrGlasses. The primary purpose of this mod is to introduce a weather control system for RimWorld players. With this mod, players can build a console that allows them to manipulate the weather in a localized area around their base using algorithmic hacking of defunct terraforming satellites.

### Key Aspects:
- **Weather Control Console**: Players can build a console under the "Misc" tab once they complete Microelectronics research.
- **Power Management**: The device requires a constant power supply of 1000 W and will short out if exposed to rain.
- **User Interface and Graphics**: Utilizes a modified version of the old communications console for its interface.

## Key Features and Systems

1. **Weather Modification**: The central feature is the ability to change and maintain specific weather conditions in the game.
2. **Power Integration**: The console requires continuous power and interacts with in-game power systems.
3. **Research Restriction**: Locked behind the Microelectronics research, adding a strategic layer to its use.

## Coding Patterns and Conventions

- **C# Structure**: The codebase consists of cleanly organized classes, such as `BCS_CompProperties`, `BCS_CompWeatherMachine`, and `BCS_WeatherMachine`.
- **Modular Components**: Each C# file represents a specific part of the functionality, such as component properties and weather effects.
- **Consistent Naming**: Follow the existing naming conventions seen in the code, like prefixing components with `BCS_`.

## XML Integration

- **XML Files**: The XML files define in-game mod properties and translations for seamless integration.
- **Defs System**: Utilize the `ThingDefs` and `JobDefs` defined in `WeatherControlDefs.xml` to create and manage new mod objects.

## Harmony Patching

The mod uses Harmony for runtime patching to integrate with RimWorld's core systems seamlessly. Key elements include:
- **Method Patching**: Use Harmony to alter or enhance existing game methods without modifying the core game files.
- **Safety and Reversibility**: Ensure patching is safe and reversible when unloading the mod.

## Suggestions for Copilot

To efficiently utilize GitHub Copilot while working on this project:

1. **Leverage Comments**: Use detailed comments in your code for Copilot to suggest contextually relevant code snippets.
2. **Request Suggestions**: Use Copilot to autocomplete typical RimWorld modding patterns and practices.
3. **Auto-generate Repetitive Code**: Let Copilot handle repetitive tasks like XML structure generation or boilerplate code for class definitions.
4. **Review Suggestions**: Always review Copilot's suggestions for accuracy and adherence to the mod's styling conventions.

By following these guidelines, you'll maintain high-quality code contributions to the Weather Control Device (Continued) mod and efficiently use GitHub Copilot as a development assistant. Happy modding!

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

