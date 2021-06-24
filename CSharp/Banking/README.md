# Banking Aufgabe

Ausführbare Exe liegt in `publish/Banking.exe`.

## Build Project

Für das Erstellen des Projektes ist das .NET 5 SDK vorraussetzung. Man führe diesen Befehl in dem Verzeichnis aus, in dem auch die `Banking.csproj` liegt. Ansonsten muss das Projekt als Wert mit in dem Befehl übergeben werden.

> $ dotnet publish -p:PublishSingleFile=true --output bin/Release --runtime win10-x64 --self-contained

Die Flag `-p:PublishSingleFile=true` ist optional und sorgt nur dafür, dass die DLLs alle in der exe enthalten sind.
