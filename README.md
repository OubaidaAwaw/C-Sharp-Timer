# Timer — Clock, Timer, and Alarm (C# WinForms)

A simple desktop application for displaying the time, featuring count-up/count-down timers and alarm functionality. Its primary goal is to provide a practical clock with a simple timer and local alarms—requiring no databases or cloud services.

Core Functionality
- Count-up and count-down timers that can be started and stopped manually.
- Saving/managing quick timer results (if the save interface is present).
- Adding alarms with a title and an associated sound file.
- Runs in the system tray; can be hidden while continuing to operate in the background.

Technology and Key Files
- Language: C# (WinForms)
- Framework: .NET Framework 4.7.2
- Project files:
- `Timer.sln` — Visual Studio solution. 
- `Timer/Timer.csproj` — Project file. 
- `Timer/Program.cs` — Entry point. 
- `Timer/Form1.cs`, `Timer/Form1.Designer.cs` — User interface and application logic. 
- `Timer/Resources/` — Resources (images, icons).
- Local data: Uses local text files (e.g., `Alarms.txt`, `Pluss.txt`, `Miness.txt`) to save certain settings/results.

Requirements
- OS: Windows
- .NET Framework 4.7.2 installed
- Visual Studio (recommended) to run/build the project from source

Running from Source
1. Clone the repository:
git clone https://github.com/OubaidaAwaw/C-Sharp-Timer.git
2. Open `Timer.sln` in Visual Studio.
3. Ensure the Target Framework is set to .NET Framework 4.7.2. 4. Select **Build** then **Run** (or execute `Timer\bin\Release\Timer.exe` after building).

Quick Usage
- Use the **Start** / **Stop** buttons for the count-up or countdown timer.
- To save or manage quick timer results, use the controls located in the **Timer** tab.
- To add an alarm, enter the time and title, select a sound file, and click **Add**.

Future Suggestions (Improvements)
- Option to export/import alarms and results for backup purposes.
- Improve the mode selection interface (dark/light) if it lacks clarity.
- Replace local text-based storage with a structured settings file (JSON) or a lightweight database if necessary.

Notes
- This version does not include work-hour tracking features or statistical charts; as previously stated, the project is dedicated solely to the clock, timer, and alarm functions.
- No license is currently included; I can add a LICENSE file (e.g., MIT) if desired.
