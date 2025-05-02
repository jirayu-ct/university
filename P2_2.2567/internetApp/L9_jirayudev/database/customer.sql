CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,      -- รหัสลูกค้า
    FirstName VARCHAR(50) NOT NULL,                 -- ชื่อ
    LastName VARCHAR(50) NOT NULL,                  -- นามสกุล
    Email VARCHAR(100),                             -- อีเมล
    PhoneNumber VARCHAR(15),                        -- เบอร์โทรศัพท์
    Address TEXT,                                   -- ที่อยู่
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP   -- วันที่สร้าง
);

INSERT INTO Customers (FirstName, LastName, Email, PhoneNumber, Address)
VALUES
    ('jirayu', 'chonthong', 'jirayu.ct05@gmail.com', '660112230038', 'com-sci m.2'),
    ('Jane', 'Smith', 'jane.smith@example.com', '0823456789', '456 Oak Avenue'),
    ('Michael', 'Johnson', 'michael.j@example.com', '0834567890', '789 Pine Lane'),
    ('Emily', 'Davis', 'emily.davis@example.com', '0845678901', '321 Cedar Drive'),
    ('William', 'Brown', 'william.brown@example.com', '0856789012', '654 Birch Way'),
    ('Elizabeth', 'Jones', 'elizabeth.j@example.com', '0867890123', '987 Maple Street'),
    ('David', 'Garcia', 'david.garcia@example.com', '0878901234', '147 Elm Court'),
    ('Sophia', 'Martinez', 'sophia.m@example.com', '0889012345', '258 Spruce Blvd'),
    ('James', 'Wilson', 'james.wilson@example.com', '0890123456', '369 Palm Road'),
    ('Olivia', 'Anderson', 'olivia.a@example.com', '0801234567', '741 Willow Lane');