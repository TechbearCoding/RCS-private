CREATE TABLE Person(
    PersonId integer,
    Name text(20),
    LastName text(20)
);

INSERT INTO Person(PersonId, Name, LastName)
VALUES(1, 'Jānis', 'Bērziņš');

INSERT INTO Person(PersonId, Name, LastName)
VALUES(2, 'Juris', 'Bērziņš');

SELECT * FROM Person;

SELECT Name, LastName FROM Person;

SELECT Name, LastName
FROM Person
WHERE LastName = 'Bērziņš';