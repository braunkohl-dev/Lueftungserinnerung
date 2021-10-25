# Lüftungserinnerung
Hier ein simples Windows Programm, welches als Lüftungserinnerung fungiert. Das Programm kann in den Autostart gelegt werden, damit beim Start von Windows mit ausgeführt wird. Das Programm bedient sich lediglich zwei kleinen Timern die über die Oberfläche Konfiguriert werden können.



hinzufügen zum Autostart:

REG ADD "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v Lueftungserinnerung /t REG_EXPAND_SZ /d """""C:\PFAD_ZUR_EXE\Lueftungserinnerung.exe""""" /f

entfernen aus dem Autostart:

reg delete  "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v Lueftungserinnerung
