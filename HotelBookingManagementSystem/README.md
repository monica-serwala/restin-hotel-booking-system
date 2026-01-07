# Hotel Booking Management System (ASP.NET MVC)

## Status: Under Active Development

This project is currently **under construction** and is being developed incrementally as part of my learning and professional growth in **ASP.NET Core MVC** and backend development.

---

## Project Overview

The **Hotel Booking Management System** is a web-based application built using **ASP.NET Core MVC**.  
The system models a realistic hotel booking domain, with a strong focus on **clean architecture**, **correct business logic**, and **scalable design**, rather than rushed feature completion.

The project is structured and developed in phases to reflect real-world software engineering practices.

---

## Core Objectives

- Model a realistic hotel booking system
- Prevent double bookings using date-range availability logic
- Implement a state-driven booking lifecycle
- Apply separation of concerns using the MVC pattern
- Use Entity Framework Core with a relational database
- Build a portfolio-ready project suitable for junior software roles

---

## Current Features

### Phase 1 – Domain Modeling (Completed)

- `Bedroom` entity
- `Booking` entity
- `RoomType` enum  
  - Twin  
  - Deluxe  
  - Suite  
  - Family
- `BookingStatus` enum  
  - Draft  
  - PendingPayment  
  - Confirmed  
  - Cancelled
- Data validation using Data Annotations

### Phase 2 – Database Infrastructure (In Progress)

- Entity Framework Core configured
- `ApplicationDbContext` implemented
- SQL Server LocalDB connection configured
- EF Core registered using Dependency Injection

---

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server LocalDB
- Visual Studio 2022
- Git and GitHub

---

## Planned Features

- Admin CRUD operations for bedrooms
- Room availability search using date overlap logic
- Booking workflow:
  - Draft
  - PendingPayment
  - Confirmed
- Booking cancellation with history preservation
- Razor Views with Bootstrap-based UI
- Database migrations and seed data
- UI polish and usability improvements
- Expanded documentation and screenshots

---

## Design Decisions

- A **relational database** was chosen to enforce data integrity and relationships.
- Bookings are **state-driven** rather than freely editable.
- Soft deletion is used instead of hard deletes to preserve history.
- Authentication and payment systems are intentionally excluded from the MVP.
- Core business logic is prioritised before UI enhancements.

---

## Development Approach

This project follows a **phased development approach**:

1. Domain modeling  
2. Database and persistence  
3. Admin management (CRUD)  
4. Availability logic  
5. Booking workflow  
6. UI refinement  
7. Documentation and showcase  

Each phase is committed separately to clearly demonstrate progress and learning over time.

---

## Disclaimer

This repository reflects an **active development and learning process**.  
Some features are incomplete by design and will be implemented in subsequent phases.

The focus of this project is on **clarity, correctness, and professional growth**.

---

## Author

**Monica Mmakokong Serwala**  
Aspiring Software Developer | Backend and Cloud Enthusiast
