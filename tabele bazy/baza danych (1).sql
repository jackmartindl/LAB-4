create table events
(
    id         int auto_increment
        primary key,
    event_name varchar(200) null,
    agenda     varchar(200) null,
    event_date varchar(200) null
);

INSERT INTO app.events (id, event_name, agenda, event_date) VALUES (1, 'Przykładowe spotkanie', 'Spotkanie', '01-01-2022');
INSERT INTO app.events (id, event_name, agenda, event_date) VALUES (2, 'Inne spotkanie', 'Spotkanie', '12-10-2022');
