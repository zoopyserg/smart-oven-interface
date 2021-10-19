attrib -a "C:\ProgramData\Oven Interface\OvenDatabase.mdf"
attrib -i "C:\ProgramData\Oven Interface\OvenDatabase.mdf"
attrib -i "C:\ProgramData\Oven Interface\OvenDatabase_log.ldf"
attrib -a "C:\ProgramData\Oven Interface\OvenDatabase_log.ldf"
icacls "C:\ProgramData\Oven Interface\OvenDatabase.mdf" /grant Users:F
icacls "C:\ProgramData\Oven Interface\OvenDatabase_log.ldf" /grant Users:F