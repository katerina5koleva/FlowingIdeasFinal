CREATE DATABASE FlowingIdeas_Real
USE FlowingIdeas_Real;
CREATE TABLE Users
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Username VARCHAR(15) NOT NULL
);

CREATE TABLE IdeaTypes
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
IdeaTypeName VARCHAR(20) NOT NULL
);

CREATE TABLE Ideas
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
IdeaTypeId INT NOT NULL FOREIGN KEY REFERENCES IdeaType(Id),
IdeaText VARCHAR(400) NOT NULL
);

INSERT INTO IdeaTypes(IdeaTypeName) 
VALUES 
('Artistic'),
('Philosophical'),
('Work Related');
