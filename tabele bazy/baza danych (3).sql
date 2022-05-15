create table users_entries
(
    user_id            int          null,
    event_id           int          null,
    status             varchar(200) null,
    participation_type varchar(200) null,
    food_type          varchar(200) null
);

INSERT INTO app.users_entries (user_id, event_id, status, participation_type, food_type) VALUES (6, 1, 'zatwierdzony', 'Słuchacz', 'Wegetariańskie');
INSERT INTO app.users_entries (user_id, event_id, status, participation_type, food_type) VALUES (3, 2, 'odrzucony', 'Autor', 'Bez glutenu');
