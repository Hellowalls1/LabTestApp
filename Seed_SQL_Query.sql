set identity_insert [UserProfile] on

insert into [UserProfile] (Id, FirebaseUserId, FirstName, LastName, Email) values (1, '7ymMUZsaeBVro11QFyiGlTorO842', 'Eva', 'Sanford', 'eva@eva.com');
insert into [UserProfile] (Id, FirebaseUserId, FirstName, LastName, Email) values (2, 'CZVlp3Y17PPVnsAy8lfkRtGG21M2', 'Tim', 'Jones', 'tim@tim.com');

set identity_insert [UserProfile] off

set identity_insert [Patient] on
insert into [Patient] ([Id], [UserProfileId], [FirstName], [LastName],  [Gender], [PatientEmail], [Phone], [Birthdate]) values (1, 1, 'Sally', 'Hanson',  'female', 'shanson@email.com', '888-867-5309', 2000-10-01);
insert into [Patient] ([Id], [UserProfileId], [FirstName], [LastName], [Gender], [PatientEmail], [Phone], [Birthdate]) values (2, 2, 'Samuel', 'Jansen',  'male', 'sjansen@email.com', '866-867-5309',  2000-10-02);

set identity_insert [Patient] off

set identity_insert [LabTest] on
insert into [LabTest] ([Id], [PatientId], [TestType], [Results], [TestTime], [EnteredTime]) values (1, 1, 'Stomache Test', 'Bad Results', 2020-28-03, 2020-29-03);
insert into [LabTest] ([Id], [PatientId], [TestType], [Results], [TestTime], [EnteredTime]) values (2, 2, 'Bloat Test', 'Good Results', 2021-28-03, 2020-28-03);

set identity_insert [LabTest] off
