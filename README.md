# Computer Laboratory Equipment and Maintenance Management System

A robust desktop application built with C# WinForms to manage laboratory hardware, track maintenance schedules, and monitor equipment lifecycles. Built with a strict adherence to SOLID principles and Clean Architecture.

## Features
* **Asset Tracking:** Manage computers, peripherals, and network devices.
* **Maintenance Logs:** Track repair history and schedule preventative maintenance.
* **Status Monitoring:** Real-time dashboards showing active, under-repair, and decommissioned units.

## Architecture & Tech Stack
* **Framework:** .NET (C# WinForms)
* **Architecture:** N-Tier Layered Architecture with Dependency Injection
* **Database:** MySQL
* **ORM:** Dapper

## Getting Started

### Prerequisites
* Visual Studio 2022
* .NET SDK (Version X.X)
* MySQL

### Installation
1. Clone the repository: `git clone https://github.com/ReajDabi/comlab_tools_and_equipment_management_system.git`
2. Update the connection string in `appsettings.json` (or `App.config`).
3. Run database migrations: `Update-Database`
4. Build and run the solution.
