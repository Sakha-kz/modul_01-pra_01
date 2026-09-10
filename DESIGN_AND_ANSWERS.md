# Практическая работа 01

## Задание 1. Предметная область и модель

В качестве предметной области выбрана библиотека книг. Основной ресурс системы - `Book`. Такой ресурс подходит для REST API, потому что книга имеет устойчивый идентификатор и набор описательных полей.

```csharp
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
```

| Поле | Тип | Назначение |
| --- | --- | --- |
| `Id` | `int` | Уникальный идентификатор книги |
| `Title` | `string` | Название книги |
| `Author` | `string` | Автор книги |
| `Year` | `int` | Год публикации |
| `Genre` | `string` | Жанр или категория |
| `Price` | `decimal` | Цена книги |

## Задание 2. Спецификация endpoints

| HTTP Method | URL | Назначение | HTTP Status Codes |
| --- | --- | --- | --- |
| `GET` | `/api/books` | Получить список всех книг | `200 OK` |
| `GET` | `/api/books/{id}` | Получить одну книгу по идентификатору | `200 OK`, `404 Not Found` |
| `POST` | `/api/books` | Создать новую книгу | `201 Created`, `400 Bad Request` |

## Задание 3. Примеры JSON

Пример объекта книги, который возвращает API:

```json
{
  "id": 1,
  "title": "Clean Code",
  "author": "Robert C. Martin",
  "year": 2008,
  "genre": "Software Engineering",
  "price": 39.99
}
```

Пример тела запроса для создания новой книги:

```json
{
  "title": "The Pragmatic Programmer",
  "author": "Andrew Hunt, David Thomas",
  "year": 1999,
  "genre": "Software Engineering",
  "price": 44.50
}
```

## Задание 4. Короткие вопросы

### Что такое Web API?

Web API - это интерфейс, через который приложения обмениваются данными по сети. Веб-сервис принимает HTTP-запросы и возвращает структурированные ответы, чаще всего в формате JSON.

### В чем разница между HTTP Request и HTTP Response?

HTTP Request отправляется клиентом на сервер и содержит метод, URL, заголовки и иногда тело запроса. HTTP Response возвращается сервером клиенту и содержит статус выполнения, заголовки и тело ответа.

### Для чего используется GET?

`GET` используется для чтения данных. Например, `GET /api/books` получает список книг, не изменяя состояние сервера.

### Для чего используется POST?

`POST` используется для отправки данных на сервер и создания нового ресурса. Например, `POST /api/books` создает новую книгу.

### Что означают 200 OK и 404 Not Found?

`200 OK` означает, что запрос успешно выполнен. `404 Not Found` означает, что запрошенный ресурс не найден, например книги с указанным `Id` не существует.
