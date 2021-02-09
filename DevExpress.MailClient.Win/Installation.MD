Steps to install the DevExpress.MailClient.Win application:

1. **Ensure you have access to MS SQL installation, preferably local**
   1. Start SQL Server Management Studio (SSMS) and navigate to your local RDBMS installation.
   1. Create a new database, named DEVEXPRESS.
   1. Add the current Windows user to security principals to the DEVEXPRESS database and grant it "dbo" permissions on the DEVEXPRESS database.
   1. Run the following SQL script in the DEVEXPRESS database to create tables for To-Do Tasks:
   ```sql
   CREATE TABLE [dbo].[Appointments] (
        [UniqueID] [int] IDENTITY (1, 1) NOT NULL,
        [Type] [int] NULL,
        [StartDate] [smalldatetime] NULL,
        [EndDate] [smalldatetime] NULL,
        [AllDay] [bit] NULL,
        [Subject] [nvarchar] (50) NULL,
        [Location] [nvarchar] (50) NULL,
        [Description] [nvarchar](max) NULL,
        [Status] [int] NULL,
        [Label] [int] NULL,
        [ResourceID] [int] NULL,
        [ResourceIDs] [nvarchar](max) NULL,
        [ReminderInfo] [nvarchar](max) NULL,
        [RecurrenceInfo] [nvarchar](max) NULL,
        [CustomField1] [nvarchar](max) NULL 
        CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED
        (
            [UniqueID] ASC
        )
        ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
        GO

```sql
    CREATE TABLE [dbo].[Resources] (
            [UniqueID] [int] IDENTITY (1, 1) NOT NULL,
            [ResourceID] [int] NOT NULL,
            [ResourceName] [nvarchar] (50)  NOT NULL,
            [Color] [int] NULL,
            [Image] [image] NULL,
            [CustomField1] [nvarchar](max) NULL 
    CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED
    (
                [UniqueID] ASC
    )
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    
    GO

2. **Install