# README - WorldSOAPService và WorldSOAPUI

## Giới thiệu
Dự án bao gồm hai phần chính:
- **WorldSOAPService**: Một dịch vụ web SOAP cho phép truy vấn thông tin quốc gia và thành phố từ cơ sở dữ liệu.
- **WorldSOAPUI**: Một ứng dụng Windows Forms cung cấp giao diện trực quan để tương tác với **WorldSOAPService**.

---

## Cấu trúc dự án

### 1. WorldSOAPService
Dịch vụ này được thiết kế với cấu trúc nhiều lớp, phân tách rõ ràng giữa tầng dữ liệu và tầng logic xử lý.

#### **Thư mục DataLayer** (Tầng dữ liệu)
- **Models**: Các lớp biểu diễn dữ liệu:
  - `City.cs`: Đại diện cho thành phố với các thuộc tính như `ID`, `Name`, `CountryCode`, `District`, và `Population`.
  - `Country.cs`: Đại diện cho quốc gia với các thuộc tính như `Code`, `Name`, `Population`, v.v.
- **DatabaseAccess.cs**: Cung cấp các phương thức làm việc với cơ sở dữ liệu:
  - `GetAllCountries()`: Lấy danh sách tất cả các quốc gia.
  - `GetCountryByCode(string countryCode)`: Tìm quốc gia dựa trên mã.
  - `GetAllCitiesOfCountry(string countryCode)`: Lấy danh sách các thành phố của một quốc gia.
  - `GetCityByName(string cityName)`: Tìm thành phố theo tên.
  - `GetCountryPopulation(string countryCode)`: Lấy dân số của một quốc gia.

#### **Thư mục Logic** (Tầng xử lý nghiệp vụ)
- **WebService1.asmx**: Cung cấp các phương thức SOAP cho ứng dụng:
  - `GetAllCountries()`
  - `GetCountryByCode(string countryCode)`
  - `GetAllCitiesOfCountry(string countryCode)`
  - `GetCityByName(string cityName)`
  - `GetCountryPopulation(string countryCode)`

---

### 2. WorldSOAPUI
Một ứng dụng Windows Forms để truy vấn thông tin thông qua giao diện người dùng trực quan.

#### **Form1.cs**
Các chức năng chính:
- `buttonGetAllCountries_Click`: Hiển thị danh sách tất cả quốc gia.
- `buttonGetCountryByCode_Click`: Tìm kiếm quốc gia dựa trên mã.
- `buttonGetCityByName_Click`: Tìm thông tin thành phố dựa trên tên.
- `buttonGetCitiesByCountry_Click`: Hiển thị danh sách thành phố của một quốc gia.
- `buttonGetPopulationByCountryCode_Click`: Hiển thị dân số của quốc gia dựa trên mã.

#### **DataGridView**
Hiển thị kết quả truy vấn dưới dạng bảng.

---

## Hướng dẫn kết nối WorldSOAPUI với WorldSOAPService 

### Bước 1: Thêm tham chiếu dịch vụ
#### 1. Nhấp chuột phải vào dự án **WorldSOAPUI** trong **Solution Explorer**.
#### 2. Chọn **Add** > **Service Reference**.
#### 3. Trong cửa sổ mới, chọn **Advanced** ở góc dưới cùng.
#### 4. Chọn **Add Web Reference**.
#### 5. Nhập URL của dịch vụ **WorldSOAPService**.
#### 6. Nhấn **Go** để tải thông tin dịch vụ.
#### 7. Chọn dịch vụ và nhấn **Add Reference** để hoàn tất.

---

## Hướng dẫn sử dụng
#### 1. Khởi chạy ứng dụng **WorldSOAPUI.exe**.
#### 2. Sử dụng các trường nhập liệu và nút chức năng để thực hiện truy vấn:
   - **Get All Countries**: Lấy danh sách tất cả quốc gia.
   - **Get Country By Code**: Tìm kiếm quốc gia bằng mã.
   - **Get City By Name**: Tìm kiếm thành phố bằng tên.
   - **Get Cities By Country**: Liệt kê tất cả thành phố thuộc quốc gia.
   - **Get Population By Country Code**: Hiển thị dân số của quốc gia.

---

## Yêu cầu hệ thống
- Hệ điều hành Windows với .NET Framework 4.7 hoặc mới hơn.
- Dịch vụ **WorldSOAPService** đang hoạt động và có thể truy cập.
