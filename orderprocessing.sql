-- 1. Tabel voor de Leden
CREATE TABLE Leden (
    LidID INT PRIMARY KEY IDENTITY(1,1), 
    Naam NVARCHAR(50) NOT NULL,        
    Email NVARCHAR(50) NOT NULL,        
    Adres NVARCHAR(MAX) NOT NULL,        
    Status NVARCHAR(50) NOT NULL         -
);

-- 2. Tabel voor de Events

CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    Naam NVARCHAR(255) NOT NULL,
    LocatieAdres NVARCHAR(MAX) NOT NULL,  
    EventDatum DATETIME NOT NULL,        
    Ticketprijs DECIMAL(10,2) NOT NULL             
);

-- 3. Tabel voor de Orders
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    LidID INT NOT NULL,
    EventID INT NOT NULL,
    InschrijfDatum DATETIME2 DEFAULT GETDATE(),
    Ticketprijs DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Lid FOREIGN KEY (LidID) REFERENCES Leden(LidID),
    CONSTRAINT FK_Event FOREIGN KEY (EventID) REFERENCES Events(EventID)
);