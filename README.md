# HotelSol - PMS with Odoo

## Project Summary

### Purpose

HotelSol is a Basic Property Management System (PMS) Project designed to streamline hotel operations with an integration to Odoo ERP. The system provides tools for managing reservations, check-ins/check-outs, room management, and product inventory while maintaining synchronization with Odoo for enhanced business operations.

### Technology Stack

- **Language**: C# (.NET)
- **Platform**: Windows Desktop Application
- **Architecture**: MVC (Model-View-Controller)
- **Key Technologies**:
  - Entity Framework Core for database operations
  - SQL Server for data storage
  - Python scripts for Odoo integration
  - Windows Forms for the user interface

### Features

- **Authentication**:

  - Secure user authentication system
  - Role-based access control
  - Session management

- **Hotel Management Features**:

  - Room management and allocation
  - Check-in/Check-out processing
  - Reservation management
  - Guest information management
  - Room status tracking
  - Pricing and rate management

- **User Interface**:

  - Windows Forms interface
  - Room status display
  - Reservation management dashboard
  - Guest information forms
  - Product inventory management
  - Odoo integration interface

- **Technical Features**:
  - Real-time synchronization with Odoo
  - XML data import/export
  - Product inventory management
  - Automated stock updates
  - Customer data management
  - Reservation tracking
  - Billing and invoicing

### Security

- **Authentication Security**:

  - Basic user authentication system
  - Password encryption using AES
  - Role-based access control (Administrator, Receptionist, Maintenance)
  - Session management

- **Data Security**:

  - SQL Server database with encrypted connections
  - Secure API communications with Odoo
  - Basic data validation
  - Error logging

- **Best Practices**:
  - Input validation
  - Basic error handling
  - Secure password storage
  - User session management

### Co-Developers

- **Lead Developers**:
  - Iker López Iribas
  - Damià Belles Sampera
  - César Flores Carrera

## Environment Setup

### Prerequisites

- Windows 10 or later
- .NET Core SDK
- Python 3.x
- SQL Server
- Odoo instance
- Visual Studio 2022 (recommended)

### Required API Keys

1. **Odoo API Credentials**
   - URL
   - Database name
   - Username
   - Password

### Setup Instructions

1. **Clone the Repository**

   ```bash
   git clone https://github.com/ikerloir35/HotelSol.git
   ```

2. **Environment Configuration**

   - Configure database connection string in `App.config`
   - Set up Odoo API credentials
   - Configure XML file paths

3. **Build Configuration**

   - Open solution in Visual Studio
   - Restore NuGet packages
   - Build the solution

4. **Run the Application**
   - Run the application from Visual Studio
   - Or use the installer package

### Security Best Practices

1. **API Key Management**

   - Store credentials in secure configuration
   - Use environment variables for sensitive data
   - Regular credential rotation

2. **Code Security**

   - Regular security audits
   - Input validation
   - Error handling
   - Secure communication protocols

3. **Development Workflow**

   - Version control
   - Code review process
   - Testing procedures
   - Documentation updates

### Troubleshooting

1. **Build Issues**

   - Check .NET SDK version
   - Verify NuGet package versions
   - Check Python installation

2. **Runtime Issues**

   - Database connection problems
   - Odoo API connectivity
   - File permission issues

3. **Authentication Issues**

   - Verify API credentials
   - Check network connectivity
   - Validate user permissions

### Production Deployment

1. **Pre-deployment Checklist**

   - Database backup
   - Configuration review
   - Security audit
   - Performance testing

2. **Release Process**

   - Version tagging
   - Release notes
   - Installation guide
   - Backup procedures

3. **Post-deployment**

   - Monitoring setup
   - Performance tracking
   - User feedback collection
   - Regular maintenance schedule

## License

This project is licensed under the Creative Commons CC0 1.0 Universal License. This means that:

- The work is dedicated to the public domain
- You can freely use, modify, and distribute the work for any purpose
- No attribution is required
- The work is provided "as-is" without any warranties
- The license is irrevocable and cannot be terminated

For more details, see the [LICENSE](LICENSE) file in the root directory of this project.
