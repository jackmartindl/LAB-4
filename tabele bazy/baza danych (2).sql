create table users
(
    id               int auto_increment
        primary key,
    imie             varchar(20) null,
    nazwisko         varchar(20) null,
    login            varchar(20) null,
    haslo            varchar(20) null,
    email            varchar(20) null,
    uprawnienia      varchar(20) null,
    data_rejestracji varchar(20) null
);

INSERT INTO app.users (id, imie, nazwisko, login, haslo, email, uprawnienia, data_rejestracji) VALUES (1, 'Jacek', 'Test', 'jacekadmin', '123', 'test@test.pl', 'admin', '13-05-2022');
INSERT INTO app.users (id, imie, nazwisko, login, haslo, email, uprawnienia, data_rejestracji) VALUES (2, 'Jacek', 'Testowy', 'jacekuser', '123', 'test@test.pl', 'user', '13-05-2022');
INSERT INTO app.users (id, imie, nazwisko, login, haslo, email, uprawnienia, data_rejestracji) VALUES (3, 'Jan', 'Kowalski', 'jk123', 'test', 'jk@dd.pl', 'user', '13.05.2022 00:00:00');
INSERT INTO app.users (id, imie, nazwisko, login, haslo, email, uprawnienia, data_rejestracji) VALUES (5, 'dddd', 'dddd', 'dddd', 'dddd', 'dddd@wp.pl', 'user', '13-5-2022');
INSERT INTO app.users (id, imie, nazwisko, login, haslo, email, uprawnienia, data_rejestracji) VALUES (6, 'Admin', 'Admin', 'admin', 'admin123', 'admin@admin.com', 'user', '14-5-2022');
