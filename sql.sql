CREATE DATABASE "PostgresDB";

CREATE TABLE "Site" (
    "Id" SERIAL PRIMARY KEY,
    "City" VARCHAR(20),
    "Name" VARCHAR(20),
    "Address" VARCHAR(255),
    "Leader" VARCHAR(20)
);

CREATE TABLE "Order" (
    "Id" SERIAL PRIMARY KEY,
    "CreatedAt" TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    "Customer" VARCHAR(20),
    "Revenue" NUMERIC(10, 2)
);

INSERT INTO "Site" ("City", "Name", "Address", "Leader")
VALUES
  ('Taipei', '內湖站', '123 Main St', 'John Doe'),
  ('Taipei', '內湖站', '456 Elm St', 'Jane Smith'),
  ('Taipei', '內湖站', '789 Oak St', 'Bob Johnson');