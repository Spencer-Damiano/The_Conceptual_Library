## Database Schema Overview

### Users Table

| Column Name   | Type     | Key Type    | Relationship Type | Relationship |
|---------------|----------|-------------|-------------------|--------------|
| UserID        | INTEGER  | Primary Key |                   |              |
| Username      | TEXT     | Unique Key  |                   |              |
| PasswordHash  | TEXT     |             |                   |              |
| UserType      | TEXT     |             |                   |              |
| CreatedAt     | DATETIME |             |                   |              |
| UpdatedAt     | DATETIME |             |                   |              |

### Sessions Table

| Column Name      | Type     | Key Type    | Relationship Type | Relationship                |
|------------------|----------|-------------|-------------------|-----------------------------|
| SessionID        | INTEGER  | Primary Key |                   |                             |
| UserID           | INTEGER  | Foreign Key | Many-to-One       | From Users.UserID           |
| StartTime        | DATETIME |             |                   |                             |
| EndTime          | DATETIME |             |                   |                             |
| ConfigurationID  | INTEGER  | Foreign Key | Many-to-One       | From TimerConfigurations.ConfigurationID |
| StudyDay         | DATETIME |             |                   |                             |
| CreatedAt        | DATETIME |             |                   |                             |
| UpdatedAt        | DATETIME |             |                   |                             |

### TimerConfigurations Table

| Column Name   | Type     | Key Type    | Relationship Type | Relationship |
|---------------|----------|-------------|-------------------|--------------|
| ConfigurationID | INTEGER | Primary Key |                   |              |
| WorkDuration  | INTEGER  |             |                   |              |
| BreakDuration | INTEGER  |             |                   |              |
| Description   | TEXT     |             |                   |              |

### Tasks Table

| Column Name   | Type     | Key Type    | Relationship Type | Relationship |
|---------------|----------|-------------|-------------------|--------------|
| TaskID        | INTEGER  | Primary Key |                   |              |
| UserID        | INTEGER  | Foreign Key | Many-to-One       | From Users.UserID           |
| Description   | TEXT     |             |                   |              |
| IsCompleted   | BOOLEAN  |             |                   |              |
| Priority      | INTEGER  |             |                   |              |
| CreatedAt     | DATETIME |             |                   |              |
| UpdatedAt     | DATETIME |             |                   |              |

### SessionTasks (Join Table for Many-to-Many Relationship)

| Column Name   | Type     | Key Type    | Relationship Type  | Relationship          |
|---------------|----------|-------------|--------------------|-----------------------|
| SessionID     | INTEGER  | Foreign Key | Many-to-Many       | From Sessions.SessionID |
| TaskID        | INTEGER  | Foreign Key | Many-to-Many       | From Tasks.TaskID     |