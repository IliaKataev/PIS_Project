# PIS Project

Это учебный опросник на Windows Forms. На первом экране вы выбираете медицинский или страховой сценарий, а дальше отвечаете на вопросы. Например, ответ о цели пребывания или гражданстве может изменить следующий шаг.

## Как работает опросник

Приложение написано на C# для .NET Framework 4.7.2.

- [MainController](WindowsFormsApp1/WindowsFormsApp1/MainController.cs) переключает шаги опросника.
- [Rules](WindowsFormsApp1/WindowsFormsApp1/Rules.cs) решает, какой шаг показать по ответам пользователя.
- [UserData](WindowsFormsApp1/WindowsFormsApp1/Users.cs) хранит выбранные ответы.
- [ViewControls](WindowsFormsApp1/WindowsFormsApp1/ViewControls) содержит экраны отдельных шагов.

## Локальный запуск

Откройте [решение](WindowsFormsApp1/WindowsFormsApp1.sln) в Visual Studio на Windows. Для сборки понадобятся компоненты разработки классических приложений .NET и .NET Framework 4.7.2 Developer Pack. Запустите проект и выберите сценарий на первом экране.
