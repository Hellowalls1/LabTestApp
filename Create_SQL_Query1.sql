GO


DROP TABLE IF EXISTS [Comment];
DROP TABLE IF EXISTS [Item];
DROP TABLE IF EXISTS [Category];
DROP TABLE IF EXISTS [User];


GO



CREATE TABLE [UserProfile] (
  [Id] integer PRIMARY KEY IDENTITY NOT NULL,
  [FirebaseUserId] nvarchar(50) NOT NULL,
  [FirstName] nvarchar(50) NOT NULL,
  [LastName] nvarchar(50) NOT NULL,
  [Email] nvarchar(555) NOT NULL

   CONSTRAINT UQ_FirebaseUserId UNIQUE(FirebaseUserId)
)
GO



CREATE TABLE [Patient] (
  [Id] integer PRIMARY KEY IDENTITY NOT NULL,
  [UserProfileId] integer NULL,
  [FirstName] nvarchar(50) NOT NULL,
  [LastName] nvarchar(50) NOT NULL,
  [Gender] nvarchar(50) NOT NULL,
  [PatientEmail] nvarchar(75) Not Null,
  [Phone] nvarchar(50) NOT NULL,
  [Birthdate] datetime NOT NULL,


  CONSTRAINT [FK_Patient_UserProfile] FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])

)
GO

CREATE TABLE [LabTest] (
  [Id] integer PRIMARY KEY IDENTITY NOT NULL,
  [PatientId] integer NOT NULL,
  [TestType] nvarchar(75)NOT NULL,
  [Results] nvarchar(500) NOT NULL,
  [TestTime] datetime NOT NULL,
  [EnteredTime] datetime NOT NULL,

  CONSTRAINT [FK_LabTest_Patient] FOREIGN KEY ([PatientId]) REFERENCES [Patient] ([Id])

)
GO