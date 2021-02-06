INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
VALUES
	('1','2','2012','100','Manuel Benzin'),
	('1','3','2015','150','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','3','2014','125','Manuel Dizel');
INSERT INTO Color(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Mavi');


INSERT INTO Brand(BrandName)
VALUES
	('Mercedes'),
	('BMW'),
	('Renault');

select * from Brand