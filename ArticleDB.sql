CREATE DATABASE ArticleDB
use ArticleDB
select * from baibao INNER JOIN GV_BB ON GV_BB.MaBB = BaiBao.id INNER JOIN GiangVien ON GiangVien.id = GV_BB.MaGV where GiangVien.id = 1;

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

CREATE PROCEDURE sp_CheckLogin 
	@email VARCHAR(30), @password VARCHAR(50)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE email = @email AND password = @password
END;
GO;

CREATE PROCEDURE sp_GetGiangVienInfoByEmail
    @Email VARCHAR(50)
AS
BEGIN
    SELECT
		gv.id AS Id,
        gv.name AS Name,
		gv.faculty AS Faculty,
        gv.hocvi AS HocVi,
        k.TenKhoa AS Khoa,
        tk.email AS Email,
        tk.phone AS PhoneNumber
    FROM 
        GiangVien gv
    INNER JOIN 
        TaiKhoan tk ON gv.id = tk.id
    INNER JOIN 
        Khoa k ON gv.faculty = k.id
    WHERE 
        tk.email = @Email;
END
GO;
	
CREATE PROCEDURE sp_GetKiemDuyetInfoByEmail
    @Email VARCHAR(50)
AS
BEGIN
    SELECT
		kd.id AS Id,
        kd.name AS Name,
        tk.email AS Email,
        tk.phone AS PhoneNumber
    FROM 
        NKD kd
    INNER JOIN 
        TaiKhoan tk ON kd.id = tk.id
    WHERE 
        tk.email = @Email AND tk.loai = 2;
END

exec sp_GetKiemDuyetInfoByEmail 'tran.thi.b@gmail.com'
GO;

CREATE PROCEDURE sp_GetReports
AS
BEGIN
	SELECT * FROM BaiBao
END;
GO;

CREATE PROCEDURE sp_GetReportById
	@Id INT
AS
BEGIN
	SELECT * FROM BaiBao WHERE id = @Id
END;
GO;

exec sp_GetReportById 3

CREATE PROCEDURE sp_GetGiangVienReportsByEmail 
    @email VARCHAR(30)
AS
BEGIN
    -- Declare a variable to store the user ID
    DECLARE @userId INT;

    -- Get the user ID based on the provided email
    SELECT @userId = id
    FROM TaiKhoan
    WHERE email = @email;

    -- Check if the user exists
    IF @userId IS NOT NULL
    BEGIN
        -- Select reports associated with the user
        SELECT 
            bb.id AS ReportID,
            bb.TieuDeTC AS JournalTitle,
            bb.TieuDeBB AS ReportTitle,
            bb.MaKhoa AS DepartmentCode,
            bb.SoPH AS IssueNumber,
            bb.STBD AS StartPage,
            bb.STKT AS EndPage,
            bb.NamXB AS PublicationYear,
			bb.NgayNop AS SubmittedDay,
			bb.NgayXuLy AS ProcessedDay,
            bb.LinkBB AS ReportLink,
            bb.MaMH AS SubjectCode,
            bb.DOI AS DOI,
            bb.TrangThai AS Status,
            bb.GhiChu AS Notes
        FROM 
            BaiBao bb
        INNER JOIN 
            GV_BB gvb ON bb.id = gvb.MaBB
        INNER JOIN 
            GiangVien gv ON gvb.MaGV = gv.id
        WHERE 
            gv.id = @userId;
    END
    ELSE
    BEGIN
        -- If the user does not exist, return an error message
        PRINT 'User not found';
    END
END
GO;

CREATE PROCEDURE sp_GetReportStatisticByMonth 
    @date DATE
AS
BEGIN
    -- Declare variables to store the start and end dates of the month
    DECLARE @startDate DATE;
    DECLARE @endDate DATE;

    -- Calculate the start and end dates of the month
    SET @startDate = DATEFROMPARTS(YEAR(@date), MONTH(@date), 1);
    SET @endDate = EOMONTH(@date);

    -- Select report statistics within the specified month
    SELECT 
        COUNT(*) AS TotalReports,
        SUM(CASE WHEN TrangThai = 'Đã xuất bản' THEN 1 ELSE 0 END) AS PublishedReports,
        SUM(CASE WHEN TrangThai = 'Đang xử lý' THEN 1 ELSE 0 END) AS ProcessingReports,
        SUM(CASE WHEN TrangThai = 'Chờ duyệt' THEN 1 ELSE 0 END) AS PendingReports
    FROM 
        BaiBao
    WHERE 
        NgayNop BETWEEN @startDate AND @endDate;
END
GO;

exec sp_GetReportStatisticByMonth '2024-9-9'
GO;

CREATE PROCEDURE sp_GetReportStatisticByYear 
    @year INT,
	@GV_ID INT
AS
BEGIN
    SELECT 
        MONTH(NgayNop) AS Month,
        COUNT(*) AS TotalReports
    FROM 
        BaiBao bb
	INNER JOIN 
        GV_BB gvb ON bb.id = gvb.MaBB
    WHERE 
        YEAR(NgayNop) = @year AND gvb.MaGV = @GV_ID 
    GROUP BY 
        MONTH(NgayNop)
    ORDER BY 
        Month;
END
GO;

exec sp_GetReportStatisticByYear 2024, 1

CREATE PROCEDURE sp_GetDashboardStatisticsForGiangVien
    @giangVienId INT
AS
BEGIN
    SELECT 
        (SELECT COUNT(*) 
         FROM BaiBao bb
         INNER JOIN GV_BB gvb ON bb.id = gvb.MaBB
         WHERE gvb.MaGV = @giangVienId AND bb.TrangThai = N'Đã xuất bản') AS PublishedReports,
        
        (SELECT SUM(gv.sogio) 
         FROM GiangVien gv
         WHERE gv.id = @giangVienId) AS TotalTime,
        
        (SELECT COUNT(*) 
         FROM BaiBao bb
         INNER JOIN GV_BB gvb ON bb.id = gvb.MaBB
         WHERE gvb.MaGV = @giangVienId AND bb.TrangThai = N'Đang xử lý') AS ProcessingReports,
        
        (SELECT COUNT(*) 
         FROM BaiBao bb
         INNER JOIN GV_BB gvb ON bb.id = gvb.MaBB
         WHERE gvb.MaGV = @giangVienId AND bb.TrangThai = N'Đã xử lý') AS ProcessedReports;
END

select * from BaiBao
select * from GV_BB
exec sp_GetDashboardStatisticsForGiangVien 1

CREATE PROCEDURE sp_SubmitReportByGiangVien
    @giangVienId INT,
    @TieuDeTC NVARCHAR(100),
    @TieuDeBB NVARCHAR(100),
    @MaKhoa VARCHAR(10),
    @SoPH VARCHAR(20),
    @STBD VARCHAR(20),
    @STKT VARCHAR(20),
    @NamXB DATE,
    @NgayNop DATE,
    @NgayXuLy DATE,
    @LinkBB VARCHAR(255),
    @MaMH VARCHAR(10),
    @DOI VARCHAR(100),
    @TrangThai NVARCHAR(15),
    @GhiChu NVARCHAR(255)
AS
BEGIN
    -- Start a transaction
    BEGIN TRANSACTION;

    -- Insert the new report into the BaiBao table
    INSERT INTO BaiBao (TieuDeTC, TieuDeBB, MaKhoa, SoPH, STBD, STKT, NamXB, NgayNop, NgayXuLy, LinkBB, MaMH, DOI, TrangThai, GhiChu)
    VALUES (@TieuDeTC, @TieuDeBB, @MaKhoa, @SoPH, @STBD, @STKT, @NamXB, @NgayNop, @NgayXuLy, @LinkBB, @MaMH, @DOI, @TrangThai, @GhiChu);

    -- Get the ID of the newly inserted report
    DECLARE @newReportId INT;
    SET @newReportId = SCOPE_IDENTITY();

    -- Insert the link between the GiangVien and the new report into the GV_BB table
    INSERT INTO GV_BB (MaGV, MaBB)
    VALUES (@giangVienId, @newReportId);

    -- Commit the transaction
    COMMIT TRANSACTION;
END

EXEC sp_SubmitReportByGiangVien 
    @giangVienId = 1,
    @TieuDeTC = N'Tạp chí Khoa học và Công nghệ',
    @TieuDeBB = N'Nghiên cứu về AI',
    @MaKhoa = 'K01',
    @SoPH = 'Số 1',
    @STBD = 'Trang 1',
    @STKT = 'Trang 10',
    @NamXB = '2023-01-01',
    @NgayNop = '2023-01-01',
    @NgayXuLy = '2023-01-02',
    @LinkBB = 'http://example.com/baibao1',
    @MaMH = 'MH01',
    @DOI = '10.1234/abcde1',
    @TrangThai = N'Đã xuất bản',
    @GhiChu = N'Nghiên cứu về trí tuệ nhân tạo';
GO;

CREATE PROCEDURE sp_GetGiangVienReportsByIdAndMonth
    @giangVienId INT,
    @month INT,
    @year INT
AS
BEGIN
    SELECT 
        bb.id AS ReportID,
        bb.TieuDeTC AS JournalTitle,
        bb.TieuDeBB AS ReportTitle,
        bb.MaKhoa AS DepartmentCode,
        bb.SoPH AS IssueNumber,
        bb.STBD AS StartPage,
        bb.STKT AS EndPage,
        bb.NamXB AS PublicationYear,
        bb.NgayNop AS SubmissionDate,
        bb.NgayXuLy AS ProcessingDate,
        bb.LinkBB AS ReportLink,
        bb.MaMH AS SubjectCode,
        bb.DOI AS DOI,
        bb.TrangThai AS Status,
        bb.GhiChu AS Notes
    FROM 
        BaiBao bb
    INNER JOIN 
        GV_BB gvb ON bb.id = gvb.MaBB
    WHERE 
        gvb.MaGV = @giangVienId 
        AND MONTH(bb.NgayNop) = @month 
        AND YEAR(bb.NgayNop) = @year;
END
GO;

CREATE PROCEDURE sp_SearchGiangVienReports
    @SearchTerm NVARCHAR(255),
	@GiangVienId INT
AS
BEGIN
    -- Select the Giang Vien reports based on the provided search term
    SELECT 
        bb.id AS ReportID,
            bb.TieuDeTC AS JournalTitle,
            bb.TieuDeBB AS ReportTitle,
            bb.MaKhoa AS DepartmentCode
    FROM 
        BaiBao bb
	INNER JOIN GV_BB gvbb ON gvbb.MaBB = bb.id
	WHERE 
        TieuDeBB LIKE '%' + @SearchTerm + '%' OR
        TieuDeTC LIKE '%' + @SearchTerm + '%'
	ORDER BY id
END;


exec sp_SearchGiangVienReports N'nghệ', 1
GO;

CREATE PROCEDURE sp_GetDashboardStatisticsForKiemDuyet
AS
BEGIN
    SELECT 
        (SELECT COUNT(*) 
         FROM BaiBao bb
         WHERE bb.TrangThai = N'Đã xuất bản') AS PublishedReports,
        
        (SELECT COUNT(*) 
         FROM BaiBao bb
         WHERE bb.TrangThai = N'Đang xử lý') AS ProcessingReports,
        
        (SELECT COUNT(*) 
         FROM BaiBao bb
         WHERE bb.TrangThai = N'Đã xử lý') AS ProcessedReports;
END
GO;

CREATE PROCEDURE sp_GetReportDashboardByFaculty
AS
BEGIN
    SELECT 
        k.TenKhoa AS FacultyName,
        COUNT(bb.id) AS TotalReports,
        SUM(CASE WHEN bb.TrangThai = 'Đã xử lý' THEN 1 ELSE 0 END) AS TotalProcessedReports,
        SUM(CASE WHEN bb.TrangThai = 'Đang xử lý' THEN 1 ELSE 0 END) AS TotalProcessingReports
    FROM 
        BaiBao bb
    INNER JOIN 
        Khoa k ON bb.MaKhoa = k.id
    GROUP BY 
        k.TenKhoa;
END

exec sp_GetReportDashboardByFaculty