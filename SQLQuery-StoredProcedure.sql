CREATE PROCEDURE AddBuyer
    @login NVARCHAR(50),
    @password NVARCHAR(50),
    @firstName NVARCHAR(100),
    @lastName NVARCHAR(100),
    @email NVARCHAR(100),
    @phoneNumber NVARCHAR(20),
    @registration_date DATETIME
AS
BEGIN
    INSERT INTO Buyers (login, password, firstName, lastName, email, phoneNumber, registration_date)
    VALUES (@login, @password, @firstName, @lastName, @email, @phoneNumber, @registration_date);
END

--*************************

CREATE PROCEDURE BuyerUpdate
    @user_id INT,
    @login NVARCHAR(50),
    @password NVARCHAR(50),
    @firstName NVARCHAR(50),
    @lastName NVARCHAR(50),
    @email NVARCHAR(100),
    @phoneNumber NVARCHAR(20),
    @registration_date DATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Buyers WHERE user_id = @user_id)
    BEGIN
        UPDATE Buyers
        SET 
            login = @login,
            password = @password,
            firstName = @firstName,
            lastName = @lastName,
            email = @email,
            phoneNumber = @phoneNumber,
            registration_date = @registration_date
        WHERE user_id = @user_id
    END
    ELSE
    BEGIN
    -- 16 — стандартный уровень для пользовательских ошибок. Состояние 2 (для отладки)
        RAISERROR('Покупатель с таким ID не найден.', 16, 2)
    END
END

--*************************

CREATE PROCEDURE BuyerDelete
    @user_id INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Buyers WHERE user_id = @user_id)
    BEGIN
        DELETE FROM Buyers WHERE user_id = @user_id
    END
    ELSE
    BEGIN
    -- 16 — стандартный уровень для пользовательских ошибок. Состояние 1 (для отладки)
        RAISERROR('Пользователь с указанным ID не найден.', 16, 1)
    END
END;

--*************************

CREATE PROCEDURE DeleteProductImage
    @product_id INT
AS
BEGIN
    UPDATE Products
    SET Picture = NULL
    WHERE product_id = @product_id
END