Select *
From Clients

Select *
From Technicians

Delete 
From Technicians

INSERT INTO Technicians (Name, Specialization, Phone, Email, Username, PasswordHash) VALUES 
('John Doe', 'Electrical', '123-456-7890', 'john.doe@example.com', 'johndoe', '1234'),
('Jane Smith', 'Plumbing', '098-765-4321', 'jane.smith@example.com', 'janesmith', '12345'),
('Alice Johnson', 'HVAC', '555-555-5555', 'alice.johnson@example.com', 'alicej', '12345678');

-- Insert a technician with a hashed password
INSERT INTO Technicians (Name, Specialization, Phone, Email, Username, PasswordHash)
VALUES ('John Doe', 'Electrical', '123-456-7890', 'john.doe@example.com', 'johndoe', '$2a$12$e2Xl4GkucgyLCt9qK/xZC.OpHK5k0uWOGoY6iOgkN3RPsFTZogLVa');

UPDATE Technicians
SET PasswordHash = '$2a$11$6br.xVR9rYpMVfhAltFR2O8UnqMVQwHrbj51lSyhWzgcbfSTDI4We'
WHERE Username = 'johndoe';

SELECT Username, PasswordHash FROM Technicians WHERE Username = 'johndoe';

--https://localhost:<port>/Home/GenerateHashedPassword This link will help you generate hashpassword with the plain password being123 by default
