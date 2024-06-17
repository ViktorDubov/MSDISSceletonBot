## # MSDISSceletonBot Тесты

## Содержание

1. [Введение](#введение)
2. [Структура тестов](#структура-тестов)
3. [Зависимости](#зависимости)
4. [Запуск тестов](#запуск-тестов)
5. [Описание тестов](#описание-тестов)
    - [CommandSystemTests](#commandsystemtests)
    - [DataSystemTests](#datasystemtests)
    - [SearchSystemTests](#searchsystemtests)
    - [TaskQueueSystemTests](#taskqueuesystemtests)
    - [UITests](#uitests)

## Введение

Этот документ описывает тестовый проект для MSDISSceletonBot. Тесты написаны с использованием xUnit и предназначены для проверки функциональности различных компонентов системы.

## Структура тестов

Тесты организованы по директориям, каждая из которых соответствует определенной части системы:

- **CommandSystemTests**: Тесты для системы команд.
- **DataSystemTests**: Тесты для системы данных.
- **SearchSystemTests**: Тесты для системы поиска.
- **TaskQueueSystemTests**: Тесты для системы очереди задач.
- **UITests**: Тесты для пользовательского интерфейса.

## Зависимости

Тестовый проект зависит от следующих пакетов:

- `coverlet.collector` (версия 6.0.0)
- `Microsoft.NET.Test.Sdk` (версия 17.8.0)
- `Moq` (версия 4.20.70)
- `System.Reactive` (версия 6.0.1)
- `xunit` (версия 2.5.3)
- `xunit.runner.visualstudio` (версия 2.5.3)

Эти пакеты устанавливаются автоматически при сборке проекта.

## Запуск тестов

1. Перейдите в директорию проекта:
   ```sh
   cd MSDISSceletonBot.Tests
   ```

2. Запустите тесты с помощью команды .NET CLI:
   ```sh
   dotnet test
   ```

## Описание тестов

### CommandSystemTests

**CommandHandlerTests.cs**:
- **Given_valid_message_When_parsed_Then_returns_true**: Проверяет, что команда корректно парсится и возвращает `true` для валидных сообщений.
- **Given_invalid_message_When_parsed_Then_returns_false**: Проверяет, что команда некорректно парсится и возвращает `false` для невалидных сообщений.

### DataSystemTests

#### ModelTests

**CustomerTaskQueueTests.cs**:
- **Given_new_queue_When_initialized_Then_queue_is_empty**: Проверяет, что новая очередь задач пустая при инициализации.
- **Given_customer_task_When_added_to_queue_Then_queue_contains_task**: Проверяет, что задача добавлена в очередь.

**CustomerTaskTests.cs**:
- **Given_few_new_customer_task_When_initialized_Then_each_has_unique_ID**: Проверяет, что каждая новая задача имеет уникальный идентификатор.
- **Given_new_customer_task_When_initialized_Then_has_correct_annotation**: Проверяет, что аннотация задачи соответствует заданной.

**CustomerTests.cs**:
- **Given_few_new_customer_When_initialized_Then_each_has_unique_ID**: Проверяет, что каждый новый заказчик имеет уникальный идентификатор.
- **Given_new_customer_When_initialized_Then_CurrentTasks_is_empty**: Проверяет, что список текущих задач у нового заказчика пустой.

**IDSetterTests.cs**:
- **Given_new_customer_When_get_id_Then_unique_id_is_returned**: Проверяет уникальность идентификаторов заказчиков.
- **Given_new_customer_task_When_get_id_Then_unique_id_is_returned**: Проверяет уникальность идентификаторов задач.
- **Given_new_worker_When_get_id_Then_unique_id_is_returned**: Проверяет уникальность идентификаторов исполнителей.
- **Given_id_setter_When_restore_Then_counters_are_reset**: Проверяет, что счетчики идентификаторов сбрасываются.

**WorkerTests.cs**:
- **Given_few_new_workers_When_initialized_Then_each_has_unique_ID**: Проверяет уникальность идентификаторов исполнителей.
- **Given_customer_task_When_set_task_in_work_Then_IsBussy_is_true**: Проверяет, что исполнитель становится занятым при получении задачи.
- **Given_worker_with_task_When_task_finished_Then_IsBussy_is_false**: Проверяет, что исполнитель становится свободным после завершения задачи.
- **Given_worker_with_task_When_task_finished_Then_TaskInWork_is_null**: Проверяет, что текущая задача исполнителя становится `null` после завершения.

### SearchSystemTests

**BussyWorkerControllerTests.cs**:
- **Given_customer_task_and_worker_When_add_customer_task_to_worker_Then_worker_is_bussy**: Проверяет, что исполнитель становится занятым при добавлении задачи.
- **Given_worker_with_task_When_finish_customer_task_from_worker_Then_worker_is_not_bussy**: Проверяет, что исполнитель становится свободным после завершения задачи.

**RecieveWorkerTaskHolderTests.cs**:
- **Given_customer_task_When_recieve_do_work_then_status_is_agree**: Проверяет, что статус выполнения задачи — "Agree".
- **Given_customer_task_When_recieve_do_work_then_status_is_refuse**: Проверяет, что статус выполнения задачи — "Refuse".
- **Given_customer_task_When_recieve_do_work_then_status_is_wait**: Проверяет, что статус выполнения задачи — "Wait".

**WorkerSearcherTests.cs**:
- **Given_worker_searcher_When_get_all_workers_Then_returns_all_workers**: Проверяет, что метод возвращает всех исполнителей.
- **Given_worker_searcher_When_get_free_workers_Then_returns_free_workers**: Проверяет, что метод возвращает свободных исполнителей.
- **Given_worker_searcher_When_get_current_reciever_Then_returns_correct_reciever**: Проверяет, что метод возвращает текущего получателя задач.
- **Given_customer_task_When_search_worker_Then_search_worker_is_called**: Проверяет, что метод поиска исполнителя вызывается при поиске исполнителя для задачи.

### TaskQueueSystemTests

**CustomerTaskQueueControllerTests.cs**:
- **Given_customer_task_When_add_customer_task_to_queue_Then_queue_contains_task**: Проверяет, что задача добавляется в очередь.

### UITests

**InputTests.cs**:
- **Given_new_message_When_get_message_Then_input_equal_message**: Проверяет, что ввод сообщения соответствует заданному сообщению.