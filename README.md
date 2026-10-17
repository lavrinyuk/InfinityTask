# InfinityTask API

Бэкенд-сервис для платформы решения задач и тестирования на базе ASP.NET Core Web API.

## Стек технологий

* **Платформа:** .NET 10 (C#)
* **Архитектура:** Controller-based REST API
* **База данных:** SQLite + Entity Framework Core
* **Безопасность:** BCrypt.Net

## Архитектура проекта

* `Controllers/` — обработчики HTTP-запросов (`AuthController`)
* `Data/` — контекст базы данных (`AppDbContext`) и конфигурации сущностей
* `DTOs/` — Data Transfer Objects для изоляции моделей базы данных
* `Models/` — сущности базы данных (`User`, `Question`, `Attempt`)
* `Migrations/` — файлы миграций схемы базы данных

## Установка
   ```bash
   git clone https://github.com/lavrinyuk/InfinityTask
   cd InfinityTask
