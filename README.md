# Angular 8 + dotnet core CRUD test task

## Предисловие
### (Для человека, который будет это проверять)

Поскольку это мой первый опыт работы с Angular, за установленный срок разобраться с модальными окнами не получилось.
К слову, в вакансии не было ни слова об использовании этого фреймворка. Не скажу, что мне не понравилось изучать новые технологии в условиях ограниченного времени, но это было неожиданностью. В связи с этим и сообщаю таким вот странным методом.

## Инструкции по запуску

В файле  **`appsettings.json`**, который находится в папке **EmployeeApi**, указать **путь к MongoDB** базе данных и имя этой базы. Указывать название коллекций необязательно (но можно, если коллекции с такими именами уже существуют), они создадутся при первой попытке записи данных в коллекции. 

![Appsettings](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/mongodbconn.PNG?raw=true)

Проверить порт, на котором будет хоститься серверное приложение. Должен быть стандартный **порт 5001/5000**, как показано на скриншоте. При использовании другого порта необходимо внести изменения в файлы **employees.service.ts и positions.service.ts**, которые находятся по пути **EmployeeFront/src/app/**. Необходимо изменить параметр uri.

![HostingPort](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/launchsettings.PNG?raw=true)

После выполнения этих операций можно запустить обе части проекта, открыв консоль в папке **EmployeeApi** и написав **`dotnet run`**, и в папке **EmployeeFront** -　**`ng serve`**.

## Пример работы

Как было упомянуто выше, модальных (всплывающих) окон здесь нет, поэтому для навигации необходимо воспользоваться переходами между страницами.

Страница добавления новой позиции выглядит так: 

![NewPositionPage](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/Job2.PNG?raw=true)

Добавим новую должность Newly Added Job и перейдем на страницу создания нового сотрудника. 

![NewEmployeePage](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/newEmployee1.PNG?raw=true)

Можно увидеть, что только что добавленная позиция появилась в выпадающем списке "Должность".

![NewJobAdded](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/JobAdded.PNG?raw=true)

Создадим сотрудника с новой должностью.

![NewEmployeeCreation](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/newEmployee2.PNG?raw=true)

Можно перейти на третью вкладку и увидеть тестовые данные, которые использовались в процессе разработки, а также информацию о только что внесенном в базу сотруднике.

![NewEmployeeCreation](https://github.com/DefinitelyNotJR/Angular-8-dotnet-core-CRUD-test-task/blob/master/Examples/Employees2.PNG?raw=true)





