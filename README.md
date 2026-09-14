## LabManager: Computer Laboratory Equipment and Maintenance Management System
A dedicated desktop application built with C# WinForms to manage computer laboratory assets, track hardware lifecycles, and handle maintenance ticketing. Tailored for academic IT environments like UM - Visayan Campus, the system provides a complete solution for fleet tracking, issue logging, and role-based inventory management.

## 1. Project Overview
LabManager is designed for efficiency and ease of use in computer laboratory administration. Key capabilities include:

Role-Based Access Control: Secure environments customized for Admins (full CRUD capabilities), Lab Technicians (maintenance and inventory updates), and Students (read-only lab availability).

Asset Lifecycle Management: Comprehensive tracking of physical hardware, categorization (System Units, Monitors, Peripherals), and logical desk mapping (Station Numbers).

Omni-Search Engine: Instantaneous, wildcard database searching across multiple attributes (Asset Tag, Station Number, Model) to identify hardware without physical barcode scanners.

Reactive Maintenance Ticketing: Streamlined workflows for reporting broken equipment, tracking repair statuses (Pending, In Progress, Resolved), and automatically updating hardware availability.

Preventive Maintenance Scheduler: Automated tracking of recurring hardware upkeep (e.g., thermal paste re-application, dust cleaning) with dashboard alerts for overdue tasks based on designated frequencies.

Spare Parts & Cost Tracking: Automated deduction of spare parts from inventory when used in repairs, coupled with financial cost tracking to monitor total IT maintenance expenditures.

Analytics Dashboard: High-level metrics for lab custodians to monitor total active workstations, units currently under repair, and upcoming preventive maintenance duties.

The project utilizes a strict N-Tier architecture (Core, Infrastructure, UI), separating business logic and database execution from presentation to ensure maximum scalability.

## 2. Technologies Used
Desktop: C# .NET (WinForms)

Database: MySQL

Data Access (ORM): Dapper (Micro-ORM for high-performance SQL execution)

Security: BCrypt.Net-Next (Cryptographic Password Hashing)

Architecture: N-Tier Layered Architecture (Dependency Injection)

Version Control: Git

## 3. Project Structure

comlab_tools_and_equipment_management_system/ 

├── ComlabManager.Core/           # Layer 1: Core entity models and repository interfaces

├── ComlabManager.Infrastructure/ # Layer 2: Dapper SQL queries and DbConnectionFactory

├── ComlabManager.UI/             # Layer 3: WinForms UI components, DI Bootstrapper

├── Database/                     # SQL scripts for schema generation and initial data seeding

├── LabManager.sln                # Visual Studio solution

└── ProjectDocumentation.md       # Comprehensive system documentation

## 4. Getting Started
Prerequisites

Visual Studio 2022 (Community or Enterprise)

.NET 6.0 or .NET 8.0 SDK

MySQL Server 8.0+

Setup Steps

git clone https://github.com/ReajDabi/comlab_tools_and_equipment_management_system.git

cd comlab_tools_and_equipment_management_system

Database Setup & Seeding:

Open MySQL Workbench and connect to your local instance as root.

Navigate to the Database/ folder in the repository and open the initialization/seed script (e.g., 01_LabManager_Init_And_Seed.sql).

Execute the script to generate the database schema and populate the system with initial test data.

Configure the MySQL connection string inside ComlabManager.UI/Program.cs (or appsettings.json if configured).

Run Desktop App:

Open LabManager.sln in Visual Studio.

Set ComlabManager.UI as the Startup Project.

Build the solution to restore all NuGet packages (Dapper, MySql.Data, BCrypt).

Run the project.

## 5. Development Team


Reajzedrik F. Dabi: Lead Developer
Chrishian E. Degaom: Lead Developer
