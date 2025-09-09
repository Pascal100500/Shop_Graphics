CREATE TABLE Buyers (
  user_id INT PRIMARY KEY IDENTITY(1, 1),
  Login NVARCHAR(50) NOT NULL UNIQUE,
  Password NVARCHAR(100) NOT NULL CHECK (LEN(password) >= 8),
  FirstName NVARCHAR(100) NOT NULL,
  LastName NVARCHAR(100) NOT NULL,
  Email NVARCHAR(255) NOT NULL UNIQUE,
  PhoneNumber NVARCHAR(20) UNIQUE,
  registration_date DATETIME NOT NULL
);

--*************************

CREATE TABLE products (
  product_id INT PRIMARY KEY IDENTITY(1, 1),
  name NVARCHAR(200) NOT NULL,
  price DECIMAL(10, 2) NOT NULL CHECK (price > 0),
  quantity INT NOT NULL CHECK (quantity >= 0),
  add_date DATETIME NOT NULL,                   
  picture VARBINARY(MAX) NULL
);

--*************************

CREATE TABLE warehouses (
    warehouse_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    address NVARCHAR(255) NOT NULL
);

--*************************

CREATE TABLE categories
(
  category_id INT PRIMARY KEY IDENTITY(1, 1),
  Name NVARCHAR(100) NOT NULL UNIQUE,
  Description NVARCHAR(500)
 );

--*************************

CREATE TABLE orders (
  order_id INT PRIMARY KEY IDENTITY(1, 1),
  user_id INT NOT NULL,
  order_date DATETIME NOT NULL,
  TotalAmount DECIMAL(7, 2) NOT NULL CHECK(total_amount > 0),
  status_id INT NOT NULL,
  delivery_address NVARCHAR(500) NOT NULL,
  FOREIGN KEY (user_id) REFERENCES Buyers(user_id),
  FOREIGN KEY (status_id) REFERENCES order_statuses(status_id)
);

--*************************

CREATE TABLE warehouse_stock (
    warehouse_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL CHECK (quantity >= 0),
    PRIMARY KEY (warehouse_id, product_id),
    FOREIGN KEY (warehouse_id) REFERENCES warehouses(warehouse_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

--*************************

CREATE TABLE order_history (
  history_id INT PRIMARY KEY IDENTITY(1, 1),
  order_id INT NOT NULL,
  previous_status_id INT,
  new_status_id INT NOT NULL,
  change_date DATETIME NOT NULL,
  comment NVARCHAR(300),
  FOREIGN KEY (order_id) REFERENCES orders(order_id),
  FOREIGN KEY (previous_status_id) REFERENCES order_statuses(status_id),
  FOREIGN KEY (new_status_id) REFERENCES order_statuses(status_id)
);

--*************************

CREATE TABLE Orders_products (
    order_product_id INT PRIMARY KEY IDENTITY(1, 1),
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    warehouse_id INT NOT NULL,
    quantity INT NOT NULL CHECK (quantity > 0),
    price DECIMAL(7, 2) NOT NULL CHECK (price > 0),
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id),
    FOREIGN KEY (warehouse_id) REFERENCES warehouses(warehouse_id)
);

--*************************

CREATE TABLE order_statuses (
  status_id INT PRIMARY KEY IDENTITY(1, 1),
  status_name NVARCHAR(30) NOT NULL UNIQUE,
  description NVARCHAR(200)
);

--*************************

CREATE TABLE products_categories (
  product_id INT NOT NULL,
  category_id INT NOT NULL,
  PRIMARY KEY (product_id, category_id),
  FOREIGN KEY (product_id) REFERENCES products(product_id),
  FOREIGN KEY (category_id) REFERENCES categories(category_id)
);