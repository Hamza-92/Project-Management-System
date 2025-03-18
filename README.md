# Project Management System

## Overview

The Project Management System is a Windows Forms application designed to help teams and individuals manage their projects efficiently. It adheres to a 3-layer architecture, ensuring separation of concerns and maintainability. The application integrates seamlessly with SQL Server for reliable data storage and retrieval.

## Project Structure
```
Library Management System/
│-- Project Management System/  # Windows Forms application
│-- Data Access Layer/          # Handles all database operations
│-- Business Logic Layer/       # Business logic for book management
│-- Presentation Layer/         # UI implementation with Windows Forms
│-- .github/                    # GitHub-related files
│-- README.md                   # Project documentation
│-- CONTRIBUTING.md             # Contribution guidelines
```

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/project-management-system.git
    ```
2. Open the solution file in Visual Studio.
3. **Configure the Database:**
   - Create a new SQL Server database.
   - Update the connection string in `app.config` file.
4. Build the project to restore dependencies.
5. Run the application.

## Technologies Used

- **C#**: Core programming language.
- **Windows Forms**: For building the user interface.
- **SQL Server**: Database for storing project and task data.

## Contributing

Contributions are welcome. Before submitting a pull request, please read the [CONTRIBUTING.md](.github/CONTRIBUTING.md) file for guidelines.

## License

This project is licensed under the [MIT License](LICENSE.txt).

## Contact

For questions or feedback, please contact [ameerhamza92099@gmail.com](mailto:ameerhamza92099@gmail.com).
