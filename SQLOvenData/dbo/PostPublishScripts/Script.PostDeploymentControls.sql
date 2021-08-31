/*
Шаблон скрипта после развертывания							
--------------------------------------------------------------------------------------
 В данном файле содержатся инструкции SQL, которые будут добавлены в скрипт построения.		
 Используйте синтаксис SQLCMD для включения файла в скрипт после развертывания.			
 Пример:      :r .\myfile.sql								
 Используйте синтаксис SQLCMD для создания ссылки на переменную в скрипте после развертывания.		
 Пример:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*
IF NOT EXISTS (SELECT * FROM dbo.Controls where Name = 'Температура') 
BEGIN
  INSERT INTO dbo.Controls (Name) VALUES ('Температура');
END

IF NOT EXISTS (SELECT * FROM dbo.Controls where Name = 'Тиск Води') 
BEGIN
  INSERT INTO dbo.Controls (Name) VALUES ('Тиск Води');
END

IF NOT EXISTS (SELECT * FROM dbo.Controls where Name = 'Тиск Пару') 
BEGIN
  INSERT INTO dbo.Controls (Name) VALUES ('Тиск Пару');
END
*/