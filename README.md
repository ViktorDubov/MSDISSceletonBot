# MSDISSceletonBot
> MSDISSceletonBot — это Discord бот, задача которого заключается в поиске исполнителей задач.

## Содержание
1. [Документация](#документация)
2. [Каркас из интерфейсов](#каркас-из-интерфейсов)
3. [Тесты xUnit](#тесты-xunit)

## Документация
- [Глоссарий](Docs/Glossary.md): Словарь используемых терминов.
- [Use Case (Диаграмма прецедентов)](Docs/UseCase/Readme.md): Описание взаимодействия пользователей с системой.
- [States (Диаграмма состояний)](Docs/States/Readme.md): Диаграмма состояний для описания поведения системы.
- [Требования](Docs/Requirements.md): Основные требования к системе.
- [Ограничения](Docs/Restrictions.md): Описания ограничений системы.

## Каркас из интерфейсов
- [Описание интерфейсов](Docs/Interfaces/Readme.md): Подробное описание интерфейсов, используемых в системе.

## Тесты xUnit
- [Описание тестов](Docs/Tests/Readme.md): Подробное описание тестов, используемых для проверки системы.

## Описание
MSDISSceletonBot — это бот для платформы Discord, предназначенный для помощи в поиске исполнителей задач. Бот позволяет:
- Отправлять задачи.
- Получать статус задач.
- Уведомлять о выполнении задач или о том, что исполнитель не найден.
- Управлять ботом и просматривать логи.

### Основные функции:
1. **Отправка задачи**: Заказчик отправляет боту задачу через команду в Discord.
2. **Получение статуса задачи**: Заказчик запрашивает статус задачи.
3. **Уведомление о выполнении**: Бот уведомляет заказчика о том, что задача выполнена.
4. **Получение уведомления о не найденном исполнителе**: Бот уведомляет заказчика о том, что исполнитель не найден.
5. **Получение задачи**: Исполнитель получает задачу от бота.
6. **Управление ботом**: Администратор управляет ботом и его настройками.
7. **Просмотр логов**: Администратор или оператор сопровождения просматривает логи для анализа.
8. **Принудительное завершение задачи**: Администратор или заказчик может принудительно завершить задачу.

### Установка и запуск

1. **Клонирование репозитория**:
   ```sh
   git clone https://github.com/ViktorDubov/MSDISSceletonBot
   ```

2. **Переход в директорию проекта**:
   ```sh
   cd MSDISSceletonBot
   ```

3. **Установка зависимостей**:
   Убедитесь, что у вас установлены .NET SDK и необходимые пакеты для работы проекта.
   ```sh
   dotnet restore
   ```

4. **Запуск проекта**:
   Выполните следующую команду для запуска бота:
   ```sh
   dotnet run
   ```
### Вклад
Мы приветствуем вклад сообщества! Если вы хотите внести свой вклад, пожалуйста, создайте pull
request или свяжитесь с нами через issues.

### Лицензия
Этот проект лицензирован под лицензией MIT. Подробности можно найти в файле LICENSE.