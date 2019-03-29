if EXIST "C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SnareTrap" (
    echo Removing existing mod installation
    RMDIR /S /Q "C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SnareTrap" )
) 

echo Copying to mod directory
xcopy /S SnareTrap "C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SnareTrap\"