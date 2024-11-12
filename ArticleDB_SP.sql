
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
        SUM(CASE WHEN TrangThai = N'Đã xuất bản' THEN 1 ELSE 0 END) AS PublishedReports,
        SUM(CASE WHEN TrangThai = N'Đang xử lý' THEN 1 ELSE 0 END) AS ProcessingReports,
        SUM(CASE WHEN TrangThai = N'Chờ duyệt' THEN 1 ELSE 0 END) AS PendingReports
    FROM 
        BaiBao
    WHERE 
        NgayNop BETWEEN @startDate AND @endDate;
END
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
    @SoPH = N'Số 1',
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
        SUM(CASE WHEN bb.TrangThai = N'Đã xử lý' THEN 1 ELSE 0 END) AS TotalProcessedReports,
        SUM(CASE WHEN bb.TrangThai = N'Đang xử lý' THEN 1 ELSE 0 END) AS TotalProcessingReports
    FROM 
        BaiBao bb
    INNER JOIN 
        Khoa k ON bb.MaKhoa = k.id
    GROUP BY 
        k.TenKhoa;
END