-- Creamos la base de datos si no existe y usamos codificación para textos en español.
CREATE DATABASE IF NOT EXISTS Escuela
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE Escuela;

-- Tabla principal del proyecto: cada carrera tiene un identificador automático.
CREATE TABLE IF NOT EXISTS Carreras (
    -- La llave primaria se genera automáticamente.
    IdCarrera INT AUTO_INCREMENT PRIMARY KEY,
    -- El nombre es obligatorio y no se puede repetir.
    Nombre VARCHAR(100) NOT NULL UNIQUE,
    -- Guardamos la cantidad de alumnos; inicia en cero.
    NumeroAlumnos INT NOT NULL DEFAULT 0
-- InnoDB permite trabajar con una tabla transaccional.
) ENGINE=InnoDB;
