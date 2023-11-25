CREATE TABLE Authors(
    id INTEGER PRIMARY KEY,
    name TEXT,
    lastName Text
);

INSERT INTO Authors(id, name, lastName)
VALUES (1, "Juris", "Pūce"),
       (2, "Jānis", "Balodis");



CREATE TABLE Books(
    id INTEGER PRIMARY KEY,
    Nosaukums TEXT NOT NULL,
    Gads INTEGER NOT NULL,
    authorId INTEGER,
    FOREIGN KEY(authorId) REFERENCES Authors(id)
);


INSERT INTO Books(id, Vards, Uzvards, Nosaukums, Gads)
VALUES(1, "Juris", "Puce", "Gramata", 1967);

INSERT INTO Books(id, Nosaukums, Gads, authorId)
VALUES (1, "aaaaaaa", 2000, 1);

INSERT INTO Books(id, Nosaukums, Gads, authorId)
VALUES (2, "asfdgsddsaaaa", 2000, 1);

INSERT INTO Books(id, Nosaukums, Gads, authorId)
VALUES (3, "testaaaa", 2003, 2);

SELECT * FROM Authors;
SELECT * FROM Books;

SELECT Authors.name, Authors.lastName, Books.Nosaukums
FROM Authors, Books
WHERE Authors.id = Books.authorId;

