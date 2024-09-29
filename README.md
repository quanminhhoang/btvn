# Bài tập về nhà Kiểm thử phần mềm

## Bài toán

Ngân hàng cho phép người dùng chuyển tiền giữa các tài khoản trực tuyến theo các quy tắc sau:

Số tiền tối thiểu được phép chuyển là $100.
Số tiền tối đa được phép chuyển là $10.000.
Nếu số tiền nằm trong khoảng từ $100 đến $5.000, thì không cần phê duyệt.
Nếu số tiền vượt $5.000 nhưng nhỏ hơn hoặc bằng $10.000, thì giao dịch cần được phê duyệt.


## Phân tích Bài toán
### Phân tích giá trị biên

Số tiền tối thiểu phải chuyển X: $100

Số tiền tối đa phải chuyển Y: $10.000

Số tiền tối đa được phê duyệt Z: $5.000

#### Các Test Case

* X- = $99 
* X = $100 
* X+ = $101 
* Z- = $4,999 
* Z = $5,000 
* Z+ = $5,001 
* Y- = $9,999 
* Y = $10,000 
* Y+ = $10,001


### Bảng quyết định

| Điều kiện                                    | 1 | 2 | 3 | 4 |
|----------------------------------------------|:-:|:-:|:-:|:-:|
| Số tiền nhỏ hơn $100                         | T | F | F | F |
| Số tiền từ $100 đến $5,000                   | - | T | F | F |
| Số tiền $5,001 đến $10,000                   | - | - | T | F |
| Số tiền lớn hơn $10,000                      | - | - | - | T |
| Số tiền được chuyển lập tức                  |   | X |   |   |
| Số tiền cần phê duyệt                        |   |   | X |   |
| Số tiền không hợp lệ                         | X |   |   | X |﻿# Bài tập về nhà Kiểm thử phần mềm

## Bài toán

Ngân hàng cho phép người dùng chuyển tiền giữa các tài khoản trực tuyến theo các quy tắc sau:

Số tiền tối thiểu được phép chuyển là $100.
Số tiền tối đa được phép chuyển là $10.000.
Nếu số tiền nằm trong khoảng từ $100 đến $5.000, thì không cần phê duyệt.
Nếu số tiền vượt $5.000 nhưng nhỏ hơn hoặc bằng $10.000, thì giao dịch cần được phê duyệt.


## Phân tích Bài toán
### Phân tích giá trị biên

Số tiền tối thiểu phải chuyển X: $100

Số tiền tối đa phải chuyển Y: $10.000

Số tiền tối đa được phê duyệt Z: $5.000

#### Các Test Case

* X- = $99 
* X = $100 
* X+ = $101 
* Z- = $4,999 
* Z = $5,000 
* Z+ = $5,001 
* Y- = $9,999 
* Y = $10,000 
* Y+ = $10,001


### Bảng quyết định

| Điều kiện                                    | 1 | 2 | 3 | 4 |
|----------------------------------------------|:-:|:-:|:-:|:-:|
| Số tiền nhỏ hơn $100                         | T | F | F | F |
| Số tiền từ $100 đến $5,000                   | - | T | F | F |
| Số tiền $5,001 đến $10,000                   | - | - | T | F |
| Số tiền lớn hơn $10,000                      | - | - | - | T |
| Số tiền được chuyển lập tức                  |   | X |   |   |
| Số tiền cần phê duyệt                        |   |   | X |   |
| Số tiền không hợp lệ                         | X |   |   | X |