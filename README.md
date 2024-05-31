# tasklist-backend

This project provides a simple backend API for managing tasks using ASP.NET Core and Entity Framework Core.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running with Visual Studio](#running-with-visual-studio)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)
- [Integration Issue with React Native and .NET Core API Backend](#Integration-Issue-with-React-Native-and-.NET-Core-API-Backend)

## Features

- CRUD operations for managing tasks
- RESTful API design
- Logging of errors for debugging purposes

## Getting Started

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or any preferred code editor
- [Visual Studio](https://visualstudio.microsoft.com/) (optional, for running with Visual Studio)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/test-hyundai-backend.git
```

2. Navigate to the project directory:

```bash
cd test-hyundai-backend
```

3. Restore dependencies:

```bash
dotnet restore
```

4. Build the project:

```bash
dotnet build
```

### Running with Visual Studio

1. Open Visual Studio.
2. Click on "Open a project or solution" and navigate to the `test-hyundai-backend` directory.
3. Select the solution file (`test-hyundai-backend.sln`) and click "Open".
4. Set the startup project to `test-hyundai-backend`.
5. Press F5 or click on the "Start" button to run the project.

## Usage

To run the application manually, use the following command:

```bash
dotnet run
```

By default, the application runs on `https://localhost:5001`. You can navigate to this URL in your web browser or use tools like Postman to interact with the API.

## API Endpoints

The following endpoints are available:

- **GET** `/api/Tasks`: Get all tasks
- **GET** `/api/Tasks/{id}`: Get a task by ID
- **POST** `/api/Tasks`: Create a new task
- **PUT** `/api/Tasks/{id}`: Update a task
- **DELETE** `/api/Tasks/{id}`: Delete a task

For more details on the request and response formats, refer to the source code or the API documentation.


## Integration Issue with React Native and .NET Core API Backend

#### Problem Description:
Encountering difficulties during the integration process between a React Native front end and a .NET Core API backend. Despite attempts to establish connection by adjusting HTTP ports, modifying CORS policies, and even switching emulators, the React Native application running on the emulator fails to connect to the server.

#### Attempted Solutions:
1. **Port Adjustment**: Experimented with switching to different HTTP ports to facilitate connection between the React Native application and the backend API.
2. **CORS Policy Modification**: Edited the CORS (Cross-Origin Resource Sharing) policy to potentially allow the React Native front end to communicate with the .NET Core backend.
3. **Emulator Switching**: Tried utilizing different emulators in the hope of resolving the connectivity issue.

#### Current Approach:
In response to the persistent integration problem, a temporary workaround has been implemented by creating a `server.js` file to manage the backend operations. This interim solution aims to establish a functional backend system independently from the React Native frontend, thereby allowing for continued development and troubleshooting without hindrance.

#### Next Steps:
- Continue investigating and debugging the integration issue between the React Native frontend and the .NET Core API backend.
- Explore alternative methods or configurations to enable successful communication between the frontend and backend components.
- Document any findings, solutions, or workarounds to aid in future development and troubleshooting efforts.



## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```

Feel free to copy this entire content, including the instructions on running with Visual Studio, and paste it into your `README.md` file in your GitHub repository.
