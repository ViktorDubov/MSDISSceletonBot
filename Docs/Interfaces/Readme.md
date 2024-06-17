# Описание интерфейсов проекта MainSceletonBot

### MainSceletonBot.Scripts.DataSystem.Model

#### Модели

- **Customer**: Модель заказчика, представляющая информацию о клиенте.
- **CustomerTask**: Модель задачи заказчика, содержащая детали задания.
- **Worker**: Модель исполнителя, представляющая информацию об исполнителе.

### SearchSystem

#### IBussyWorkerController - Контроллер занятых исполнителей

- **Workers**: Список исполнителей.
- **AddCustomerTaskToWorker**: Метод добавления задачи к исполнителю.
- **FinishCustomerTaskFromWorker**: Метод завершения задачи исполнителем.

#### ICustomerTaskBuffer - Буфер задач заказчиков

- **CanSearchNewWorker**: Наблюдаемый объект, показывающий возможность поиска нового исполнителя.
- **IsSearchSystemBussy**: Флаг занятости системы поиска.
- **NewCustomerTaskToSearch**: Наблюдаемый объект новых задач для поиска.
- **RecieveNewSearch**: Метод получения нового поиска.

#### RecieveDoWorkStatuses - Статусы выполнения работы

- **Agree**: Согласие на выполнение задачи.
- **Refuse**: Отказ от выполнения задачи.
- **Wait**: Ожидание выполнения задачи.

#### IRecieveWorkerTaskHolder - Держатель задач исполнителей

- **RecieveDoWorkAsync**: Асинхронный метод получения статуса выполнения задачи исполнителем.

#### IWorkerSearcher - Поиск исполнителей

- **AllWorkers**: Список всех исполнителей.
- **FreeWorkers**: Список свободных исполнителей.
- **CurrentReciever**: Текущий держатель задач.
- **SearchWorker**: Метод поиска исполнителя для задачи.

### CommandSystem

#### Commands - Команды

- **AddWorker**: Добавление исполнителя.
- **RemoveWorker**: Удаление исполнителя.
- **AddNewTask**: Добавление новой задачи.
- **GetTaskStatus**: Получение статуса задачи.
- **CancelTask**: Отмена задачи.

#### ICommandHandler - Обработчик команд

- **TryParseMessageToCommandAndContext**: Метод парсинга сообщения в команду и контекст.
- **DoCommand**: Метод выполнения команды с контекстом.

### DataBaseProxy

#### IDataBaseProxy - Прокси для работы с базой данных

- **GetCustomerByIDAsync**: Получение заказчика по ID.
- **GetCustomerByNameAsync**: Получение заказчика по имени.
- **WriteNewCostomerAsync**: Запись нового заказчика.
- **UpdateCustomerAsync**: Обновление заказчика.
- **DeleteCustomerAsync**: Удаление заказчика.
- **AddCustomerTaskAsync**: Добавление задачи заказчика.
- **GetCustomerTaskByIDAsync**: Получение задачи заказчика по ID.
- **UpdateCustomerTaskAsync**: Обновление задачи заказчика.
- **DeleteCustomerTaskAsync**: Удаление задачи заказчика.
- **AddWorkerAsync**: Добавление исполнителя.
- **GetWorkerByIdAsync**: Получение исполнителя по ID.
- **UpdateWorkerAsync**: Обновление исполнителя.
- **DeleteWorkerAsync**: Удаление исполнителя.

### InitiateSystem

#### IAppEarlyDataChecker - Проверка данных на старте приложения

- **CheckDataInSystem**: Метод проверки данных в системе.

#### IAppInitiator - Инициализация приложения

- **InitiateApp**: Метод инициализации приложения.

#### IAppRestorer - Восстановление приложения

- **RestoreApp**: Метод восстановления приложения.

#### IAppStarter - Запуск приложения

- **StartApp**: Метод запуска приложения с аргументами.

#### IAppStarterHolder - Держатель компонентов для запуска приложения

- **AppStarter**: Интерфейс IAppStarter.
- **AppEarlyDataChecker**: Интерфейс IAppEarlyDataChecker.
- **AppInitiator**: Интерфейс IAppInitiator.
- **AppRestorer**: Интерфейс IAppRestorer.

### ShutdownSystem

#### IAppDataSaver - Сохранение данных приложения

- **SaveAppDataAsync**: Асинхронный метод сохранения данных приложения.

#### IShutdowner - Завершение работы приложения

- **ShutdownAsync**: Асинхронный метод завершения работы приложения.

### TaskQueueSystem

#### ICustomerTaskQueueController - Контроллер очереди задач заказчиков

- **QueueHolder**: Держатель очереди задач заказчиков.
- **AddCustomerTaskToQueue**: Метод добавления задачи в очередь.

### UI

#### IInput - Ввод данных

- **Input**: Наблюдаемый объект ввода строк.
- **GetMessage**: Метод получения сообщения.