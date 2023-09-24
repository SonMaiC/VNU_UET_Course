VNU_UET_Course
Author: Mai Son
Date: 21-09-2023
Version: 1.0.0

Dự án tốt nghiệp khóa học MFC-WPF-IOT của trường đại học công nghệ đại học quốc gia Hà Nội (UET) liên kết với SDV

Yêu cầu bài toán
- Gồm 2 máy tính 1(MT1) và 2(MT2)
- MT1 chạy chương trình python sử dụng model YOLOv8 detect object (Người, điện thoại)
- MT1 gủi thông tin gồm type object, tọa độ object về MT2 qua Serial Communication
- MT2 chạy chương trình C# nhận data từ MT1 xử lý và điều khiển PLC qua mạng TCP/IP
- Nếu vật thể là người hoặc điện thoại sẽ điều khiển PLC on Đèn cảnh báo.
