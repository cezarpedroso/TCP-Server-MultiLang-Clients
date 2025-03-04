# Multi-Client TCP Server

This project is a **C# TCP server** that supports multiple client implementations in **C#** and **Python**. The server listens for incoming connections and sends a message to any connected client.

## Features
- Built using **C# TcpListener**.
- Supports multiple client types:
  - **C# Console Client**
  - **Python Client**
- Sends a welcome message to connected clients.
- Simple and lightweight implementation.

## Server Setup
### Requirements
- .NET SDK (for C# server and client)
- Python (for the Python client)

### Running the Server
1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/MultiClient-TCP-Server.git
   cd MultiClient-TCP-Server
   ```
2. Compile and run the C# server:
   ```sh
   dotnet run --project Server
   ```
   The server will start listening on **port 8080**.

## C# Client
### Running the C# Client
1. Navigate to the client directory:
   ```sh
   cd CSharpClient
   ```
2. Run the client:
   ```sh
   dotnet run
   ```
   The client will connect to the server and receive a message.

## Python Client
### Running the Python Client
1. Navigate to the Python client directory:
   ```sh
   cd PythonClient
   ```
2. Run the client:
   ```sh
   python client.py
   ```
   The client will connect to the server and receive a message.

## Folder Structure
```
MultiClient-TCP-Server/
│── Server/        # C# TCP Server
│── CSharpClient/  # C# Client
│── PythonClient/  # Python Client
│── README.md      # Project Documentation
```

## Future Enhancements
- Support for additional client types (e.g., Java, mobile apps).
- Implement bi-directional communication.
- Add authentication for secure connections.

## License
This project is licensed under the MIT License.

