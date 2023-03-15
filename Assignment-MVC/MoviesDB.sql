CREATE TABLE Movie(
Mid INT PRIMARY KEY,
Moviename VARCHAR(20),
DateofRelease varchar(20));

INSERT INTO Movie(Mid, Moviename,DateofRelease)
VALUES(001, 'Bahubali2', '2017-04-28'),
      (002, 'Vivegam', '2017-08-24'),
	  (003, 'Sarkar', '2018-11-06'),
	  (004, 'Bigil', '2019-10-25'),
	  (005, 'Viswasam', '2019-01-10'),
	  (006, 'soorarai Pottru', '2020-11-12'),
	  (007, 'Doctor', '2021-10-09'),
	  (008, 'Don', '2022-05-13'),
	  (009, 'Love Today', '2022-11-04'),
	  (010, 'Vathi', '2023-02-17')

SELECT * FROM Movie;
