-- 1. Tabel voor de Leden
CREATE TABLE Leden (
    LidID INT PRIMARY KEY IDENTITY(1,1), 
    Naam NVARCHAR(50) NOT NULL,        
    Email NVARCHAR(50) NOT NULL,        
    Adres NVARCHAR(50) NOT NULL,        
    Status NVARCHAR(50) NOT NULL,
    NamePlate Bit NOT NULL,
    Diner Bit NOT NULL,
    Taxi Bit NOT NULL          
);

-- 2. Tabel voor de Events

CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    Naam NVARCHAR(50) NOT NULL,
    LocatieAdres NVARCHAR(50) NOT NULL,  
    EventDatum DATETIME NOT NULL,        
    Ticketprijs DECIMAL(10,2) NOT NULL             
);

-- 3. Tabel voor de Orders
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    LidID INT NOT NULL,
    EventID INT NOT NULL,
    InschrijfDatum DATETIME2 DEFAULT GETDATE(),
    Totaalprijs DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Lid FOREIGN KEY (LidID) REFERENCES Leden(LidID),
    CONSTRAINT FK_Event FOREIGN KEY (EventID) REFERENCES Events(EventID)
);