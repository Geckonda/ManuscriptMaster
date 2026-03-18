-- Create ENUM types for PostgreSQL
CREATE TYPE book_rating AS ENUM ('PLUS18', 'PLUS16', 'PLUS12', 'PLUS6', 'PLUS0');
CREATE TYPE book_status AS ENUM ('IN_PROCESS', 'Finished', 'Freezed', 'Abandoned');
CREATE TYPE book_modificator AS ENUM ('PUBLIC', 'PRIVATE');

-- Users table
CREATE TABLE users (
    id BIGSERIAL PRIMARY KEY,
    nickname VARCHAR(255) NOT NULL,
    login VARCHAR(255) NOT NULL UNIQUE,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    avatar VARCHAR(500),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Genres table
CREATE TABLE genres (
    id BIGSERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Default genres
INSERT INTO genres (name, description) VALUES
    ('Fantasy', 'Мир магии, приключений и эпичных сюжетов'),
    ('Science Fiction', 'Технологии, космос и альтернативные вселенные'),
    ('Romance', 'Истории любви и отношений'),
    ('Mystery', 'Тайны, расследования и неожиданные повороты'),
    ('Thriller', 'Напряжение, экшен и острые ощущения');

-- Books table
CREATE TABLE books (
    id BIGSERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    user_id BIGINT NOT NULL,
    rating book_rating DEFAULT 'PLUS0',
    status book_status DEFAULT 'IN_PROCESS',
    modificator book_modificator DEFAULT 'PRIVATE',
    genre_id BIGINT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_books_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
    CONSTRAINT fk_books_genre FOREIGN KEY (genre_id) REFERENCES genres(id) ON DELETE SET NULL
);

-- Episodes table
CREATE TABLE episodes (
    id BIGSERIAL PRIMARY KEY,
    heading VARCHAR(255) NOT NULL,
    position INT DEFAULT 0,
    content TEXT,
    book_id BIGINT NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_episodes_book FOREIGN KEY (book_id) REFERENCES books(id) ON DELETE CASCADE
);

-- Characters table
CREATE TABLE characters (
    id BIGSERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    height INT,
    weight INT,
    personality TEXT,
    appearance TEXT,
    conflict TEXT,
    goals TEXT,
    motivation TEXT,
    history TEXT,
    picture VARCHAR(500),
    user_id BIGINT NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_characters_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
);

-- Create indexes for better query performance
CREATE INDEX idx_books_user_id ON books(user_id);
CREATE INDEX idx_books_genre_id ON books(genre_id);
CREATE INDEX idx_books_status ON books(status);
CREATE INDEX idx_episodes_book_id ON episodes(book_id);
CREATE INDEX idx_characters_user_id ON characters(user_id);
CREATE INDEX idx_users_login ON users(login);
CREATE INDEX idx_users_email ON users(email);
