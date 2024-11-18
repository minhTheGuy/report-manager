CREATE DATABASE ArticleDB
use ArticleDB

CREATE TABLE TaiKhoan (
	id INT IDENTITY(1, 1) NOT NULL,
	email VARCHAR(30) NOT NULL UNIQUE,
	password VARCHAR(255) NOT NULL,
	loai INT NOT NULL,
	status VARCHAR(20) NOT NULL,
	phone VARCHAR(10) NOT NULL UNIQUE,
	createdAt DATE DEFAULT GETDATE(),
	PRIMARY KEY (id)
);

CREATE TABLE Khoa (
	id VARCHAR(10) NOT NULL,
	TenKhoa NVARCHAR(100) NOT NULL UNIQUE,
	PRIMARY KEY (id)
);

CREATE TABLE MonHoc (
	id VARCHAR(10) NOT NULL,
	TenMonHoc NVARCHAR(100) NOT NULL UNIQUE,
	PRIMARY KEY (id)
);

CREATE TABLE GiangVien (
	id INT NOT NULL FOREIGN KEY (id) REFERENCES TaiKhoan(id),
	name NVARCHAR(100) NOT NULL,
	slbb INT DEFAULT 0,
	sogio INT DEFAULT 0,
	hocvi NVARCHAR(30) NOT NULL,
	join_date DATE DEFAULT GETDATE(),
	faculty VARCHAR(10) NOT NULL FOREIGN KEY (faculty) REFERENCES Khoa(id),
	PRIMARY KEY (id)
);

CREATE TABLE NGS (
	id INT NOT NULL FOREIGN KEY (id) REFERENCES TaiKhoan(id),
	name NVARCHAR(100) NOT NULL,
	DDHA NVARCHAR(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE NKD (
	id INT NOT NULL FOREIGN KEY (id) REFERENCES TaiKhoan(id),
	name NVARCHAR(100) NOT NULL,
	DDHA NVARCHAR(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE BaiBao (
	id INT IDENTITY(1, 1),
	TieuDeTC NVARCHAR(100), -- Tieu De Tap Chi
	TieuDeBB NVARCHAR(100), -- Tieu De Bai Bao
	MaKhoa VARCHAR(10) FOREIGN KEY REFERENCES Khoa(id),
	SoPH VARCHAR(20),
	STBD VARCHAR(20),
	STKT VARCHAR(20),
	NamXB DATE DEFAULT GETDATE(),
	NgayNop DATE DEFAULT GETDATE(),
	NgayXuLy DATE DEFAULT GETDATE(),
	LinkBB VARCHAR(255),
	MaMH VARCHAR(10) FOREIGN KEY REFERENCES MonHoc(id),
	DOI VARCHAR(100),
	TrangThai NVARCHAR(15),
	GhiChu NVARCHAR(255),
	PRIMARY KEY (id)
);

CREATE TABLE GV_BB (
	MaGV INT NOT NULL,
	MaBB INT NOT NULL,
	FOREIGN KEY (MaGV) REFERENCES GiangVien(id),
	FOREIGN KEY (MaBB) REFERENCES BaiBao(id)
)

INSERT INTO TaiKhoan (email, password, loai, status, phone)
VALUES 
('nguyen.van.a@gmail.com', 'password123', 1, 'active', '0123456789'),
('tran.thi.b@gmail.com', 'securePass456', 2, 'inactive', '0987654321'),
('le.van.c@gmail.com', 'myPassword789', 3,'active', '0912345678'),
('pham.thi.d@gmail.com', 'passWord321', 2,'pending', '0908765432'),
('hoang.van.e@gmail.com', 'password654', 2,'active', '0934567890');

INSERT INTO GiangVien (id, name, slbb, sogio, hocvi, join_date, faculty)
VALUES 
(1, N'Nguyễn Văn A', 5, 120, N'Tiến sĩ', '2023-01-15', 'CNTT'),
(2, N'Trần Thị B', 3, 90, N'Thạc sĩ', '2022-09-01', 'KTe'),
(3, N'Lê Văn C', 4, 110, N'Tiến sĩ', '2021-06-20', 'YD'),
(4, N'Phạm Thị D', 2, 80, N'Thạc sĩ', '2020-11-10', 'LAW'),
(5, N'Hoàng Văn E', 6, 140, N'Giáo sư', '2019-03-25', 'KThuat');

INSERT INTO Khoa (id, TenKhoa)
VALUES 
('CNTT', N'Khoa Công nghệ thông tin'),
('KTe', N'Khoa Kinh tế'),
('YD', N'Khoa Y học'),
('LAW', N'Khoa Luật'),
('KThuat', N'Khoa Kỹ thuật');

INSERT INTO MonHoc (id, TenMonHoc)
VALUES 
('MH01', N'Lập trình C++'),
('MH02', N'Kinh tế vi mô'),
('MH03', N'Giải phẫu học'),
('MH04', N'Luật dân sự'),
('MH05', N'Cơ học ứng dụng');

INSERT INTO BaiBao (TieuDeTC, TieuDeBB, MaKhoa, SoPH, STBD, STKT, NamXB, LinkBB, MaMH, DOI, TrangThai, GhiChu)
VALUES 
(N'Tạp chí Khoa học và Công nghệ', N'Nghiên cứu về AI', 'CNTT', N'Số 1', 'Trang 1', 'Trang 10', '2023-01-01','http://example.com/baibao1', 'MH01', '10.1234/abcde1', N'published', N'Nghiên cứu về trí tuệ nhân tạo'),
(N'Tạp chí Kinh tế', N'Phân tích thị trường', 'KTe', N'Số 2', 'Trang 11', 'Trang 20', '2023-02-01','http://example.com/baibao2', 'MH02', '10.1234/abcde2', N'published', N'Phân tích thị trường kinh tế Việt Nam'),
(N'Tạp chí Y học', N'Công nghệ y tế mới', 'KThuat', N'Số 3', 'Trang 21', 'Trang 30', '2023-03-01','http://example.com/baibao3', 'MH03', '10.1234/abcde3', N'published', N'Công nghệ mới trong y tế'),
(N'Tạp chí Luật', N'Quy định pháp luật mới', 'LAW', N'Số 4', 'Trang 31', 'Trang 40', '2023-04-01','http://example.com/baibao4', 'MH04', '10.1234/abcde4', N'published', N'Quy định pháp luật mới nhất'),
(N'Tạp chí Kỹ thuật', N'Phát triển công nghệ', 'YD', N'Số 5', 'Trang 41', 'Trang 50', '2023-05-02','http://example.com/baibao5', 'MH05', '10.1234/abcde5', N'pending', N'Phát triển công nghệ kỹ thuật mới'),
(N'Tạp chí Khoa học và Công nghệ', N'Nghiên cứu về YD', 'CNTT', N'Số 1', 'Trang 1', 'Trang 10', '2023-01-01','http://example.com/baibao1', 'MH01', '10.1234/abcde1', N'published', N'Nghiên cứu về trí tuệ nhân tạo');

INSERT INTO GV_BB (MaGV, MaBB)
VALUES 
(1, 32),
(1, 33),
(1, 34),
(1, 35),
(1, 36),
(1, 37);
GO;
