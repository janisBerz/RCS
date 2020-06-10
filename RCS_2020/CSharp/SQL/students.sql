DROP TABLE students;

CREATE TABLE students(
studentId int NOT NULL,
studentName varchar(255) NOT NULL,
studentSurname varchar(255) NOT NULL,
studentCourse int NOT NULL,
CHECK(studentCourse >=0 AND studentCourse <= 3)
);

ALTER TABLE students
MODIFY COLUMN studentId INT PRIMARY KEY AUTO_INCREMENT;

INSERT INTO students (studentName, studentSurname, studentCourse)
Values("Juris","Burka", 0),
("Liene", "Berzins", 0),
("Arturs", "Berzins", 1),
("Janis", "Berzins", 1),
("Janis", "Lielais", 3),
("Janis", "Mazais", 2),
("Janis", "KKK", 3);

SELECT * FROM students;
SELECT * FROM students where studentName = "Janis";
SELECT * FROM students where studentCourse = 1 or studentCourse = 2;
