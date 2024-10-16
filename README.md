# Diary Web Application

This is a Diary Web Application developed using **ASP.NET Core**. The application allows users to create, read, update, and delete diary entries.
It features a simple and user-friendly interface for managing personal notes, thoughts, and daily activities.

## Features

- **Add New Entries**: Write and save new diary entries.
- **View Entries**: Browse through past entries.
- **Edit Entries**: Modify previously written diary entries.
- **Delete Entries**: Remove any entry you no longer need.
- **Responsive Design**: Works well on both desktop and mobile devices.

## Technologies Used

- **Backend**: ASP.NET Core
- **Frontend**: HTML, CSS, JavaScript
- **Database**: Entity Framework Core
- **Authentication**: ASP.NET Identity (optional, if applicable)
- **Version Control**: Git

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine
- A database engine like SQLite or SQL Server (depending on your configuration)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Krapic/Diary.git
   ```
2. Navigate to the project folder:
   ```bash
   cd Diary
   ```
3. Install the necessary dependencies and restore the project:
   ```bash
   dotnet restore
   ```

### Database Setup

![Database](https://github.com/user-attachments/assets/70ef9595-a18b-400d-8b2c-9fedf3cb67a5)

1. Update the `appsettings.json` file with your database connection string. If you are using SQLite, it should look something like this:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=diary.db"
   }
   ```
2. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

### Running the Application

To run the application locally, execute the following command:
```bash
dotnet run
```

The application will be accessible at `https://localhost:7165` or `http://localhost:5249`.

![Launch Terminal](https://github.com/user-attachments/assets/5d15d1e6-fde8-4fa0-af5e-6737b0370b24)

## Usage

1. Start writing your diary entries using the provided text editor.
2. View your entries in a list or edit them as needed.

![Diary Index Page](https://github.com/user-attachments/assets/def75778-0f58-4d77-babe-7a436a3f59a2)
![Create Diary Entry](https://github.com/user-attachments/assets/cd2f2686-d724-4974-b2a6-980f0c03e51a)
![Edit Diary Entry](https://github.com/user-attachments/assets/af2a3ac0-b44b-4bfa-9453-595152875ca3)
![Delete Diary Entry](https://github.com/user-attachments/assets/8153f30d-aa3b-47a1-bbe7-eee0028bb4e8)


## Contributing

Contributions are welcome! If you have ideas for new features or improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more details.

## Acknowledgements

- **ASP.NET Core** for the backend framework
- **Entity Framework Core** for the ORM
- **Bootstrap** for the frontend framework
