Select *
From Clients

Select *
From Technicians

Delete 
From Clients

Delete 
From Technicians

--Testing purposes
INSERT INTO Technicians (Name, Specialization, Phone, Email, Username, PasswordHash) VALUES 
('Jane Smith', 'Plumbing', '098-765-4321', 'jane.smith@example.com', 'janesmith', '12345');

-- Insert a technician with a hashed password
INSERT INTO Technicians (Name, Specialization, Phone, Email, Username, PasswordHash)
VALUES ('John Doe', 'Electrical', '123-456-7890', 'john.doe@example.com', 'johndoe', '$2a$12$e2Xl4GkucgyLCt9qK/xZC.OpHK5k0uWOGoY6iOgkN3RPsFTZogLVa');

--Updating Technician with specific generated hash code 
UPDATE Technicians
SET PasswordHash = '$2a$11$6br.xVR9rYpMVfhAltFR2O8UnqMVQwHrbj51lSyhWzgcbfSTDI4We'
WHERE Username = 'johndoe';

SELECT Username, PasswordHash FROM Technicians WHERE Username = 'johndoe';

--https://localhost:<port>/Home/GenerateHashedPassword This link will help you generate hashpassword with the plain password being password123 by default
