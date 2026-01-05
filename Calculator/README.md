# WPF Taschenrechner

Ein einfacher Taschenrechner erstellt mit WPF, .NET 10 und der neuesten C# Version.

## Funktionen

Der Taschenrechner unterstützt die folgenden Standard-Operationen:
- **Addition (+)**: Addiert zwei Zahlen
- **Subtraktion (-)**: Subtrahiert zwei Zahlen
- **Multiplikation (×)**: Multipliziert zwei Zahlen
- **Division (÷)**: Dividiert zwei Zahlen

## Bedienung

### Zahlen eingeben
- Klicken Sie auf die Zahlentasten (0-9), um Zahlen einzugeben
- Verwenden Sie die Dezimaltaste (.), um Dezimalzahlen einzugeben

### Operationen ausführen
1. Geben Sie die erste Zahl ein
2. Klicken Sie auf eine Operationstaste (+, -, ×, ÷)
3. Geben Sie die zweite Zahl ein
4. Klicken Sie auf die Gleichheitstaste (=), um das Ergebnis zu erhalten

### Löschen
- Klicken Sie auf die "C"-Taste, um die Anzeige zu löschen und einen neuen Berechnungsvorgang zu starten

## Technische Details

- **Framework**: .NET 10.0
- **UI-Framework**: WPF (Windows Presentation Foundation)
- **Sprache**: C# (neueste Version)
- **Ziel-Plattform**: Windows

## Projekt ausführen

### Voraussetzungen
- .NET 10 SDK oder höher
- Windows Betriebssystem

### Projekt bauen
```bash
dotnet build Calculator.sln
```

### Projekt ausführen
```bash
dotnet run --project Calculator/Calculator.csproj
```

Oder öffnen Sie die Lösung in Visual Studio und drücken Sie F5.

## Projektstruktur

```
Calculator/
├── App.xaml                 # Anwendungsdefinition
├── App.xaml.cs              # Anwendungslogik
├── MainWindow.xaml          # Hauptfenster UI-Definition
├── MainWindow.xaml.cs       # Hauptfenster Logik
├── Calculator.csproj        # Projektdatei
└── AssemblyInfo.cs          # Assembly-Informationen
```

## Fehlerbehandlung

- Bei Division durch Null zeigt der Taschenrechner "Fehler" an
- Ungültige Eingaben werden ignoriert
