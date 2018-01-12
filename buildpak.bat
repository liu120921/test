@echo off  
@set unity="C:\Program Files\Unity\Editor\Unity.exe"  
echo start...  
%unity%  -batchmode -quit -nographics -executeMethod Exporter.ExportCom  -logFile Editor.log 
echo finish!  
pause 