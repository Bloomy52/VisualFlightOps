# Visual Flight Operations Management Tool
A WinForms C# app demonstrating a simple Flight Operations Management Tool.

> [!NOTE]
> This app is under development and features are being implemented. The core functionality of this app will remain the same. Any changes can be found in the changelog on the GitHub Release. The `.NET Framework` version of this app starts at `v2.0.0` and will follow semantic versioning from there. 


## Why?
I built the `Visual Flight Operations Management Tool` (`VisualFlightOps`), to help me better understand the avaiation industry and how they manage flights. It also allows me to showcase some C# skills I have been working on in a fun way.

## Using The Software
This is great that you want to use the `Visual Flight Operations Management Tool`!
But I do want to warn you that it has only been tested on a Windows 11 PC, so your milage
may vary.

Here are some ways you can install and use the `Visual Flight Operations Management Tool`:


### Downloading From GitHub Releases (Recommended)
The best way to install `VisualFlightOps` is from GitHub Releases. You can find the latest version here: [https://github.com/Bloomy52/VisualFlightOps/releases/latest](https://github.com/Bloomy52/VisualFlightOps/releases/latest)

Once you have downloaded the file, double click on the EXE and you will see the app open.

You can attest the file using the GitHub CLI by using the following command:
```bash
gh attest verify VisualFlightOps.exe --repo Bloomy52/VisualFlightOps
```

### Building From Source
If you really want to build this from source, I am not going to stop you. But you will need the following things:

You will need `Git`. You can download it via `winget` using the following command:
```powershell
winget install Git.Git --silent
```

You will also need the `.NET desktop build tools` for Visual Studio 2026. You can download the `Build Tools for Visual Studio 2026` here: https://visualstudio.microsoft.com/downloads/#build-tools-for-visual-studio-2026. `VisualFlightOps` targets v4.7.2 of the .NET Framework.

1. Clone the repo
```bash
git clone https://github.com/Bloomy52/VisualFlightOps.git
```
2. Search for "Developer Command Prompt for VS" and press Enter.
3. `cd` to the directory where you cloned the repo.
4. Then run the following command:
```bat
msbuild VisualFlightOps/VisualFlightOps.csproj /restore /m /p:Configuration=Release /p:Platform=AnyCPU
```
5. Then you can navigate to the `\bin\Release` directory and double click on the app there via File Explorer or you can invoke it in the Command Prompt like so:
```bat
VisualFlightOps\bin\Release\VisualFlightOps.exe 
```

## Contributing
Contributions are welcome! If you find a bug, notice something inaccurate, or have a small improvement to suggest, feel free to open an issue or submit a pull request.

Please keep changes focused on the purpose of the project. For larger changes, opening an issue first is appreciated.

## License
This project is licensed under the MIT License. See the LICENSE file for more details: [LICENSE.txt](LICENSE.txt)
