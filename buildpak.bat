@echo off  
@set unity="C:\Program Files\Unity\Editor\Unity.exe"  
echo start...  
%unity%  -batchmode -quit -nographics -executeMethod Exporter.ExportCom  -logFile E:\unity_test_projects\commondlinetest\commondlinetest\Editor.log -projectPath "E:\unity_test_projects\commondlinetest\commondlinetest"   
echo finish!  
pause 