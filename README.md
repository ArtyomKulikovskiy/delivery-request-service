# delivery-request-service
Тестовое задание для Major Express

Необходимо для работы сервиса:
1. .NET 7 SDK https://dotnet.microsoft.com/en-us/download/dotnet/7.0
2. Docker https://www.docker.com/

Как развернуть приложение:
1. Запускаем докер, скачиваем образ postgres (имеет метку "DOCKER OFFICIAL IMAGE")
2. На основе образа создаём контейнер, указываем пароль и логин в переменных POSTGRES_PASSWORD и POSTGRES_USER, а также выбираем порт Port
3. Открываем репозиторий сервиса, в appsetting.json приводим значение value в "ConnectionStrings":{"Postgres":value} к виду value = "Host=localhost;Port={Port};Database=postgres;Username={POSTGRES_USER};Password={POSTGRES_PASSWORD}"
4. Запускаем контейнер
5. Запускаем сервис

Краткое описание ручек контроллера:
1. Search - получаем список всех заявок, по query можно фильтровать записи
2. Delete - софт делит заявки (в Search не отобразится)
3. Create - создание новой заявки
4. Update - обновление новой заявки
5. SubmitForExecution - установление статуса "Передано на выполнение" и Id курьера для новой заявки
6. Execute - установление статуса "Исполнена" для переданой на выполнение заявки
7. Cancel - установление статуса "Отменена" и причины отмены для переданой на выполнение заявки

Спецификация OpenApi содержится в файле delivery-request-service.yaml