# VisualFlightOps

The migration lives in `VisualFlightOps.Framework`, targeting .NET Framework 4.7.2.
The original `VisualFlightOps` project targets .NET 10 and remains in the solution
for reference while the port is ongoing.

Build the Framework project directly to avoid building the .NET 10 version:

```powershell
dotnet build VisualFlightOps.Framework/VisualFlightOps.Framework.csproj -c Release
```

Development requires the .NET Framework 4.7.2 targeting pack and MSBuild (or the
.NET SDK used by the command above). You can also open the Framework `.csproj`
in Visual Studio and set it as the startup project.

Distribute `VisualFlightOps.Framework.exe` and its `.exe.config` from
`VisualFlightOps.Framework/bin/Release`. Users need .NET Framework 4.7.2 or later;
the application does not require the .NET 10 runtime or SDK. Verify that prerequisite
on the Windows versions you intend to support.

Flights are currently kept in memory and are lost when the application exits.
