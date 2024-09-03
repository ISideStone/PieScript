# PieScript

Welcome to the PieScript project! This repository provides a framework for writing and testing trading strategies. You can use this project to create and manage trading scripts and upload them to a server.

## Getting Started

To get started with the PieScript project, follow these instructions:

### Prerequisites

- **Visual Studio Code**: Ensure you have [Visual Studio Code](https://code.visualstudio.com/) installed on your machine.
- **Git**: Make sure Git is installed to clone the repository.

### Cloning the Repository

1. Open your terminal (Command Prompt, PowerShell, or any terminal of your choice).
2. Clone the repository using the following command:

    ```bash
    git clone https://github.com/ISideStone/PieScript.git
    ```

3. Navigate into the project directory:

    ```bash
    cd PieScript
    ```

### Opening the Project in Visual Studio Code

1. Launch Visual Studio Code.
2. Open the project folder by selecting **File > Open Folder** and choosing the `PieScript` directory you just cloned.

    Alternatively, you can use the command line to open the project in Visual Studio Code:

    ```bash
    code .
    ```


### Required Extensions

To work efficiently with the PieScript .NET C# project in Visual Studio Code, you should install the following extensions:

1. **C#**: Provides rich support for C# development, including IntelliSense and debugging.
   - **ID**: `ms-dotnettools.csharp`
   - **Publisher**: Microsoft

2. **C# Extensions**: Adds useful features for C# development, such as code navigation and code generation.
   - **ID**: `csharpextensions`
   - **Publisher**: C# Extensions

2. **.NET Install Tool**: This extension installs and manages different versions of the .NET SDK and Runtime.
   - **ID**: `ms-dotnettools.vscode-dotnet-runtime`
   - **Publisher**: .NET Install Tool


## Configuration Settings

The configuration settings are crucial for the script to function correctly. They are defined in a JSON configuration file. Here is a description of each setting:

```json
{
  "Script": {
    "Data": {
      "Id": "" // Script ID for identifying the script on the server
    }
  },
  "Headers": {
    "x-token": "", // User authentication token
    "Content-Type": "application/json" // The content type for the HTTP request
  }
}
```

### Setting Up the Project

1. Ensure you have the necessary extensions installed in Visual Studio Code for C# development.

## `SendCode.ps1` File

The `SendCode.ps1` file is a PowerShell script used to upload your trading scripts to a server. This script handles the communication between your local environment and the server where the trading scripts will be executed.

### How to Use `SendCode.ps1`

1. Open the `SendCode.ps1` file in a text editor.
2. Configure the script with the appropriate settings (see below).
3. Run the script using PowerShell:

    ```powershell
    .\SendCode.ps1
    ```
