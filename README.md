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

## Kết quả đạt được
Sau khi triển khai `WorldSOAPService` và `WorldSOAPUI`, các chức năng chính của hệ thống đã hoạt động đầy đủ và hiệu quả. Dưới đây là những kết quả cụ thể:

### 1. Giao diện người dùng trực quan (UI)
- Giao diện ứng dụng WorldSOAPUI được thiết kế thân thiện, dễ sử dụng, với các chức năng chính được phân bố rõ ràng:
   - Country Code: Nhập mã quốc gia để tìm kiếm thông tin chi tiết.
   - City Name: Nhập tên thành phố để tra cứu thông tin.
   - Các nút chức năng được sắp xếp logic:
      ```csharp 
      Get Country Info, Get Population, Get Cities by Country, Get City by Name, và Get All Countries.
      ```

### 2. Chức năng hoạt động chính xác
- Lấy danh sách tất cả quốc gia:
   - Khi nhấn nút Get All Countries, ứng dụng hiển thị đầy đủ danh sách tất cả các quốc gia trong DataGridView với các cột:
      ```csharp
      Code, Name, Continent, Region, Surface Area, Independence Year, Population, Life Expectancy, GNP, Local Name, Government Form, Head of State, Capital, và Code2.
      ```
   - Dữ liệu hiển thị theo định dạng bảng giúp dễ dàng theo dõi và sắp xếp thông tin.
- Tìm kiếm thông tin quốc gia theo mã (Country Code):
   - Khi nhập mã quốc gia vào ô Country Code và nhấn Get Country Info, ứng dụng hiển thị thông tin chi tiết của quốc gia tương ứng trong DataGridView với các cột:
      ```csharp 
      Code, Name, Continent, Region, và Population.
      ```
- Tra cứu thông tin thành phố theo tên:
   - Khi nhập tên thành phố vào ô City Name và nhấn Get City by Name, ứng dụng hiển thị thông tin chi tiết của thành phố trong DataGridView, bao gồm các cột:
      ```csharp
      ID, Name, Country Code, District, và Population.
      ```
- Lấy danh sách các thành phố của một quốc gia:
   - Khi nhập mã quốc gia vào ô Country Code và nhấn Get Cities by Country, ứng dụng hiển thị danh sách tất cả các thành phố thuộc quốc gia đó trong DataGridView, với các cột:
      ```csharp
      ID, Name, Country Code, District, và Population.
      ```
- Lấy dân số của quốc gia:
   - Khi nhập mã quốc gia vào ô Country Code và nhấn Get Population, ứng dụng hiển thị dân số của quốc gia trong DataGridView với các cột:
      ```csharp
      Country Code, Population.
      ```
### 3. Hiển thị dữ liệu rõ ràng, có xử lý lỗi
- DataGridView hiển thị dữ liệu rõ ràng, có cột và hàng được định dạng hợp lý.
- Ứng dụng có xử lý ngoại lệ (exception handling) để đảm bảo không bị lỗi khi nhập dữ liệu sai hoặc không tìm thấy thông tin.
## Yêu cầu hệ thống
- Hệ điều hành Windows với .NET Framework 4.7 hoặc mới hơn.
- Dịch vụ **WorldSOAPService** đang hoạt động và có thể truy cập.
