-- tạo cơ sở dữ liệu
create database quanlykho;
go

-- sử dụng cơ sở dữ liệu
use quanlykho;
go

-- thiết lập cài đặt giao dịch
set xact_abort on;
begin transaction;

-- tạo bảng `taikhoan`
create table taikhoan (
    hoten nvarchar(50) null,
    tendangnhap nvarchar(50) not null,
    matkhau nvarchar(60) null,
    vaitro nvarchar(50) null,
    trangthai int null,
    email nvarchar(50) null,
    constraint pk_taikhoan primary key (tendangnhap)
);

-- chèn dữ liệu vào bảng `taikhoan`
insert into taikhoan (hoten, tendangnhap, matkhau, vaitro, trangthai, email) values
('Admin', 'admin', '$2a$06$Xy33o2NBQ2X3l.S.dRxGnOnenFxTNuGk3BDnSPpe4cVKF4/ZJXNl6', 'Admin', 1, 'sinhbaoreact2003@gmail.com'),
(N'Hoàng Gia Bảo', 'bobo', '$2a$12$PhiTGBbHjHoB3dbS6BmCC.rzdMCBqDrdK9Y8Ae8GPcKe1RpHiWARO', N'Nhân viên xuất', 1, 'hgiabao2k3@gmail.com'),
(N'Trần Nhật Sinh', 'sinhsinh1122', '$2a$12$89As1J0AB0yrqGjnQUHtpevc6voGyvzAd8OvzkS1vGDo3YPO2P.Ia', N'Nhân viên nhập', 1, 'transinh342@gmail.com'),
(N'Nguyễn Thiên Ân', 'thienan', '$2a$12$myOaq0kATMzNkbxgzQEkPu8ht2K0pXOGzZMZo6nSBowq6EyoLo7tS', N'Quản lý kho', 1, 'a11611112003@gmail.com');

-- tạo bảng `chitietphieunhap`
create table chitietphieunhap (
    maphieu nvarchar(50) not null,
    masanpham nvarchar(50) not null,
    soluong int null,
    dongia float null,
    constraint pk_chitietphieunhap primary key (maphieu, masanpham)
);

-- chèn dữ liệu vào bảng `chitietphieunhap`
insert into chitietphieunhap (maphieu, masanpham, soluong, dongia) values
('PN1', 'SP10', 1, 23490000),
('PN1', 'SP9', 1, 19490000),
('PN10', 'SP2', 1, 23490000),
('PN10', 'SP6', 1, 22990000);

-- tạo bảng `chitietphieuxuat`
create table chitietphieuxuat (
    maphieu nvarchar(50) not null,
    masanpham nvarchar(50) not null,
    soluong int null,
    dongia float null,
    constraint pk_chitietphieuxuat primary key (maphieu, masanpham)
);

-- chèn dữ liệu vào bảng `chitietphieuxuat`
insert into chitietphieuxuat (maphieu, masanpham, soluong, dongia) values
('PX1', 'SP1', 1, 23490000),
('PX1', 'SP10', 13, 19490000),
('PX1', 'SP3', 1, 15000000),
('PX10', 'SP2', 1, 20790000),
('PX6', 'SP9', 1, 2500000),
('PX7', 'SP6', 1, 12450000),
('PX7', 'SP8', 1, 534000),
('PX8', 'SP9', 1, 2500000),
('PX9', 'SP4', 1, 203000),
('PX9', 'SP9', 1, 2500000);

-- tạo bảng `khachhang`
create table khachhang (
    id nvarchar(11) not null,
    hoten nvarchar(255) not null,
    email nvarchar(255) not null,
    sdt nvarchar(11) not null,
    diachi nvarchar(255) not null,
    constraint pk_khachhang primary key (id)
);

-- chèn dữ liệu vào bảng `khachhang`
insert into khachhang (id, hoten, email, sdt, diachi) values
('1', N'Khách 1', 'khach@gmail.com', '833453345', N'Hồ Chí Minh'),
('2', N'Khách 123123', 'khach@gmail.com', '833453345', N'Hồ Chí Minh'),
('6', 'duy1233', 'duy@gmail.com', '1233123123', N'Hà Nội');

-- tạo bảng `nhacungcap`
create table nhacungcap (
    manhacungcap nvarchar(50) not null,
    tennhacungcap nvarchar(50) null,
    sdt nvarchar(11) null,
    diachi nvarchar(150) null,
    constraint pk_nhacungcap primary key (manhacungcap)
);

-- chèn dữ liệu vào bảng `nhacungcap`
insert into nhacungcap (manhacungcap, tennhacungcap, sdt, diachi) values
('BINHMINH', N'Công ty CP Nhựa Bình Minh', '02839690973', N'240 Hậu Giang, Phường 9, Quận 6, TP. Hồ Chí Minh'),
('BYZAN', N'Công ty Nội thất Byzan', '0932262123', N'Lô 12 BT3, KĐT VINACONEX 3, Nam Từ Liêm, Hà Nội'),
('CTCP', N'Tổng công ty Viglacera - CTCP', '02435536660', N'Tòa nhà Viglacera, Số 1 Đại lộ Thăng Long, Hà Nội'),
('DHB', N'Công ty TNHH Nhà Đẹp DHB Việt Nam', '0918800480', N'Số 70 Ng. 34 P. Hoàng Cầu, Chợ Dừa, Đống Đa, Hà Nội'),
('HALO', 'Halo Group', '02839257666', N'01 Sương Nguyệt Ánh, P. Bến Thành, Quận 1, TP. Hồ Chí Minh'),
('HOAPHAT', N'Công ty cổ phần thép Hòa Phát', '02462848666', N'66 Nguyễn Du, P. Nguyễn Du, Q. Hai Bà Trưng, Hà Nội'),
('HOASEN', N'Công ty CP Tập đoàn Hoa Sen', '18001515', N'183 Nguyễn Văn Trỗi, Phường 10, Quận Phú Nhuận, TP. Hồ Chí Minh'),
('TINVIET', N'Công ty Nội thất Tín Việt', '02862625060', N'31 Trần Văn Khánh, P. Tân Thuận Đông, Quận 7, TP. Hồ Chí Minh');

-- tạo bảng `phieunhap`
create table phieunhap (
    maphieu nvarchar(50) not null,
    thoigiantao datetime null,
    nguoitao nvarchar(50) null,
    manhacungcap nvarchar(50) null,
    tongtien float not null,
    constraint pk_phieunhap primary key (maphieu),
    constraint fk_phieunhap_nhacungcap foreign key (manhacungcap) references nhacungcap (manhacungcap),
    constraint fk_phieunhap_taikhoan foreign key (nguoitao) references taikhoan (tendangnhap)
);

-- chèn dữ liệu vào bảng `phieunhap`
insert into phieunhap (maphieu, thoigiantao, nguoitao, manhacungcap, tongtien) values
('PN1', '2022-12-01 13:59:09', 'admin', 'CTCP', 42980000),
('PN10', '2022-12-07 18:04:19', 'admin', 'HOAPHAT', 112440000),
('PN11', '2022-12-07 18:48:21', 'admin', 'CTCP', 98300000),
('PN12', '2022-12-16 02:19:48', 'admin', 'DHB', 39880000),
('PN13', '2022-12-16 02:19:36', 'admin', 'BYZAN', 38980000);

-- tạo bảng `phieuxuat`
create table phieuxuat (
    maphieu nvarchar(50) not null,
    thoigiantao datetime not null default getdate(),
    nguoitao nvarchar(50) not null,
    tongtien float not null,
    makhachhang nvarchar(11) not null,
    constraint pk_phieuxuat primary key (maphieu),
    constraint fk_phieuxuat_taikhoan foreign key (nguoitao) references taikhoan (tendangnhap),
    constraint fk_phieuxuat_khachhang foreign key (makhachhang) references khachhang (id)
);

-- chèn dữ liệu vào bảng `phieuxuat`
insert into phieuxuat (maphieu, thoigiantao, nguoitao, tongtien, makhachhang) values
('PX1', '2022-12-01 14:10:44', 'admin', 291860000, '1'),
('PX10', '2022-12-07 18:41:08', 'admin', 57160000, '1'),
('PX12', '2022-12-07 19:06:56', 'admin', 45370000, '1'),
('PX13', '2022-12-08 12:31:48', 'admin', 109420000, '1'),
('PX14', '2022-12-08 16:30:10', 'admin', 78650000, '1'),
('PX6', '2024-10-18 18:13:55', 'Admin', 2500000, '1'),
('PX7', '2024-10-18 18:39:18', 'Admin', 12984000, '1'),
('PX8', '2024-10-18 22:35:49', 'Admin', 2500000, '1'),
('PX9', '2024-10-18 22:48:44', 'admin', 2703000, '6');

-- tạo bảng `sanpham`
create table sanpham (
    masanpham nvarchar(50) not null,
    tensanpham nvarchar(100) null,
    soluong int not null default 0,
    dongia float not null default 0,
    xuatxu nvarchar(50) null,
    trangthai int null,
    constraint pk_sanpham primary key (masanpham)
);

-- chèn dữ liệu vào bảng `sanpham`
insert into sanpham (masanpham, tensanpham, soluong, dongia, xuatxu, trangthai) values
('SP1', N'GẠCH ỐP', 36, 250000, N'Việt Nam', 1),
('SP10', N'GẠCH LÓT', 106, 350000, N'Việt Nam', 1),
('SP2', N'GẠCH LÁT ĐƯỜNG', 78, 226000, N'Việt Nam', 1),
('SP3', N'XỐP CÁCH ÂM', 53, 340000, N'Nhật', 1),
('SP4', N'VÒI HOA SEN', 42, 203000, N'Trung Quốc', 1),
('SP5', N'TỦ BẾP', 55, 5230000, N'Trung Quốc', 1),
('SP6', N'TỦ QUẦN ÁO', 72, 12450000, N'Hàn', 1),
('SP7', N'ĐIỀU HÒA', 43, 15499000, N'Hàn', 1),
('SP8', N'ĐÈN', 63, 534000, N'Hàn', 1),
('SP9', N'GHẾ', 10, 2500000, N'Nhật', 1);

-- thêm ràng buộc khóa ngoại
alter table chitietphieunhap
    add constraint fk_chitietphieunhap_phieunhap foreign key (maphieu) references phieunhap (maphieu),
        constraint fk_chitietphieunhap_sanpham foreign key (masanpham) references sanpham (masanpham);

alter table chitietphieuxuat
    add constraint fk_chitietphieuxuat_phieuxuat foreign key (maphieu) references phieuxuat (maphieu),
        constraint fk_chitietphieuxuat_sanpham foreign key (masanpham) references sanpham (masanpham);

commit transaction;
go

select * from sanpham
SELECT masanpham, tensanpham,soluong,xuatxu,dongia FROM sanpham WHERE trangThai = 1

