; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{DE48E676-49A5-4B3C-8778-7AD2E135ED33}
AppName=Modulo Verificador
AppVersion=1.3
;AppVerName=Modulo Verificador 1.3
AppPublisher=Alsa-Soft, Inc.
AppPublisherURL=http://www.example.com/
AppSupportURL=http://www.example.com/
AppUpdatesURL=http://www.example.com/
DefaultDirName=C:\Program Files\Soporte\Modulo Verificador
DefaultGroupName=Modulo Verificador
DisableProgramGroupPage=yes
LicenseFile=C:\Users\AUXSOPORTE\Desktop\terms.txt
InfoBeforeFile=C:\Users\AUXSOPORTE\Desktop\PREREQUISITOS.txt
OutputBaseFilename=ModuloV17
SetupIconFile=C:\Users\AUXSOPORTE\Documents\Visual Studio 2013\Projects\busqueda_RFC\busqueda_RFC\soportetecno.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\AUXSOPORTE\Desktop\Soporte\Modulo Verificador.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\AUXSOPORTE\Desktop\Soporte\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Modulo Verificador"; Filename: "{app}\Modulo Verificador.exe"
Name: "{group}\{cm:UninstallProgram,Modulo Verificador}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Modulo Verificador"; Filename: "{app}\Modulo Verificador.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Modulo Verificador"; Filename: "{app}\Modulo Verificador.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\Modulo Verificador.exe"; Description: "{cm:LaunchProgram,Modulo Verificador}"; Flags: nowait postinstall skipifsilent

