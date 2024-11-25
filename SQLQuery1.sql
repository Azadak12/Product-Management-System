CREATE TABLE clients (
    id INT NOT NULL PRIMARY KEY IDENTITY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    phone VARCHAR(20) NULL,
    address VARCHAR(100) NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);
INSERT INTO clients (name, email, phone, address)
VALUES 
('Abdul Kalam', 'abkalam@softlogi.com', '+923097502122', 'lAHORE, Pakistan'),
    ('Ayesha Khan', 'ayesha.khan@example.com', '+923001234567', 'Karachi, Pakistan'),
    ('Ali Raza', 'ali.raza@example.com', '+923456789012', 'Islamabad, Pakistan'),
    ('Fatima Noor', 'fatima.noor@example.com', '+923111223344', 'Multan, Pakistan'),
    ('Mohammad Usman', 'usman.mohammad@example.com', '+923224455667', 'Peshawar, Pakistan'),
    ('Sara Ahmed', 'sara.ahmed@example.com', '+923334445566', 'Quetta, Pakistan');
