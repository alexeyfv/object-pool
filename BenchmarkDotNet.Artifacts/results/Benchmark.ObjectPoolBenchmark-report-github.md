```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
12th Gen Intel Core i7-12800H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-XRLNCT : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

IterationCount=25  

```
| Method        | Size    | Mean           | Error         | StdDev         | Median         | Ratio    | RatioSD | Gen0        | Gen1        | Gen2        | Allocated   | Alloc Ratio |
|-------------- |-------- |---------------:|--------------:|---------------:|---------------:|---------:|--------:|------------:|------------:|------------:|------------:|------------:|
| **UsePooledList** | **10**      |       **2.839 μs** |     **0.0425 μs** |      **0.0538 μs** |       **2.812 μs** |     **-21%** |    **1.9%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 10      |       3.616 μs |     0.0118 μs |      0.0154 μs |       3.621 μs | baseline |         |      1.7204 |           - |           - |     21600 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **20**      |       **4.301 μs** |     **0.0091 μs** |      **0.0115 μs** |       **4.300 μs** |     **-27%** |    **0.9%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 20      |       5.906 μs |     0.0370 μs |      0.0493 μs |       5.904 μs | baseline |         |      2.9297 |           - |           - |     36800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **30**      |       **5.942 μs** |     **0.0289 μs** |      **0.0365 μs** |       **5.953 μs** |     **-20%** |    **0.8%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 30      |       7.425 μs |     0.0298 μs |      0.0366 μs |       7.436 μs | baseline |         |      2.9297 |           - |           - |     36800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **40**      |       **6.153 μs** |     **0.1134 μs** |      **0.1513 μs** |       **6.203 μs** |     **-45%** |    **3.4%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 40      |      11.172 μs |     0.2280 μs |      0.2625 μs |      11.271 μs | baseline |         |      5.1575 |           - |           - |     64800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **50**      |       **9.115 μs** |     **0.0354 μs** |      **0.0472 μs** |       **9.133 μs** |     **-26%** |    **0.6%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 50      |      12.391 μs |     0.0280 μs |      0.0374 μs |      12.400 μs | baseline |         |      5.1575 |           - |           - |     64800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **60**      |       **5.515 μs** |     **0.2379 μs** |      **0.3175 μs** |       **5.469 μs** |     **-59%** |    **5.7%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 60      |      13.512 μs |     0.0434 μs |      0.0565 μs |      13.526 μs | baseline |         |      5.1575 |           - |           - |     64800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **70**      |       **5.549 μs** |     **0.1035 μs** |      **0.1382 μs** |       **5.545 μs** |     **-71%** |    **2.5%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 70      |      18.952 μs |     0.0444 μs |      0.0592 μs |      18.957 μs | baseline |         |      9.4299 |           - |           - |    118400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **80**      |       **5.927 μs** |     **0.0312 μs** |      **0.0416 μs** |       **5.930 μs** |     **-70%** |    **1.1%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 80      |      19.505 μs |     0.1229 μs |      0.1598 μs |      19.520 μs | baseline |         |      9.4299 |           - |           - |    118400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **90**      |       **6.371 μs** |     **0.0219 μs** |      **0.0277 μs** |       **6.371 μs** |     **-69%** |    **0.8%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 90      |      20.373 μs |     0.1097 μs |      0.1465 μs |      20.305 μs | baseline |         |      9.4299 |           - |           - |    118400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **100**     |      **16.753 μs** |     **0.0823 μs** |      **0.1070 μs** |      **16.775 μs** |     **-21%** |    **2.0%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 100     |      21.267 μs |     0.3132 μs |      0.4181 μs |      21.456 μs | baseline |         |      9.4299 |           - |           - |    118400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **200**     |      **13.411 μs** |     **0.1598 μs** |      **0.1962 μs** |      **13.367 μs** |     **-62%** |    **1.5%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 200     |      34.952 μs |     0.1282 μs |      0.1667 μs |      34.930 μs | baseline |         |     17.7612 |           - |           - |    223200 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **300**     |      **19.079 μs** |     **0.1818 μs** |      **0.2428 μs** |      **19.139 μs** |     **-63%** |    **1.4%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 300     |      51.744 μs |     0.2924 μs |      0.3698 μs |      51.861 μs | baseline |         |     34.3018 |           - |           - |    430400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **400**     |      **25.067 μs** |     **0.2209 μs** |      **0.2873 μs** |      **25.140 μs** |     **-56%** |    **1.6%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 400     |      57.521 μs |     0.4932 μs |      0.6584 μs |      57.425 μs | baseline |         |     34.3018 |           - |           - |    430400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **500**     |      **29.039 μs** |     **0.7623 μs** |      **1.0176 μs** |      **28.337 μs** |     **-48%** |    **3.6%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 500     |      55.874 μs |     0.5027 μs |      0.6711 μs |      56.327 μs | baseline |         |     34.3018 |           - |           - |    430400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **600**     |      **33.703 μs** |     **0.1077 μs** |      **0.1400 μs** |      **33.690 μs** |     **-63%** |    **0.8%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 600     |      90.484 μs |     0.4498 μs |      0.6004 μs |      90.519 μs | baseline |         |     67.1387 |           - |           - |    842400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **700**     |      **38.975 μs** |     **0.2528 μs** |      **0.3288 μs** |      **38.888 μs** |     **-58%** |    **1.2%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 700     |      92.018 μs |     0.6131 μs |      0.8185 μs |      92.141 μs | baseline |         |     67.1387 |           - |           - |    842400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **800**     |      **46.928 μs** |     **0.1600 μs** |      **0.2081 μs** |      **46.945 μs** |     **-49%** |    **1.0%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 800     |      92.196 μs |     0.6398 μs |      0.8541 μs |      91.758 μs | baseline |         |     67.1387 |           - |           - |    842400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **900**     |      **49.672 μs** |     **0.3328 μs** |      **0.3961 μs** |      **49.643 μs** |     **-50%** |    **1.2%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 900     |      98.417 μs |     0.7442 μs |      0.9412 μs |      98.545 μs | baseline |         |     67.1387 |           - |           - |    842400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **1000**    |      **55.180 μs** |     **0.2329 μs** |      **0.3028 μs** |      **55.085 μs** |     **-47%** |    **1.4%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 1000    |     103.634 μs |     1.0723 μs |      1.4315 μs |     103.394 μs | baseline |         |     67.1387 |           - |           - |    842400 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **2000**    |     **115.142 μs** |     **0.5451 μs** |      **0.7277 μs** |     **115.083 μs** |     **-41%** |    **1.2%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 2000    |     194.090 μs |     1.4450 μs |      1.9291 μs |     194.122 μs | baseline |         |    132.5684 |           - |           - |   1664000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **3000**    |     **161.323 μs** |     **0.5664 μs** |      **0.7163 μs** |     **161.312 μs** |     **-45%** |    **0.5%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 3000    |     292.483 μs |     0.7422 μs |      0.9386 μs |     292.222 μs | baseline |         |    262.6953 |     21.4844 |           - |   3304800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **4000**    |     **215.245 μs** |     **0.9546 μs** |      **1.2744 μs** |     **215.164 μs** |     **-38%** |    **1.1%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 4000    |     348.440 μs |     2.4616 μs |      3.2008 μs |     347.951 μs | baseline |         |    262.6953 |     21.4844 |           - |   3304800 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **5000**    |     **268.300 μs** |     **1.4226 μs** |      **1.8991 μs** |     **267.733 μs** |     **-48%** |    **0.8%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 5000    |     513.131 μs |     1.9910 μs |      2.5180 μs |     514.290 μs | baseline |         |    523.4375 |           - |           - |   6584000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **6000**    |     **344.190 μs** |     **5.8309 μs** |      **7.1608 μs** |     **347.659 μs** |     **-40%** |    **2.4%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 6000    |     575.932 μs |     5.2317 μs |      6.9842 μs |     573.402 μs | baseline |         |    523.4375 |           - |           - |   6584000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **7000**    |     **381.576 μs** |     **0.7849 μs** |      **1.0206 μs** |     **381.622 μs** |     **-38%** |    **0.6%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 7000    |     619.069 μs |     2.6051 μs |      3.2946 μs |     619.501 μs | baseline |         |    523.4375 |           - |           - |   6584000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **8000**    |     **434.079 μs** |     **0.7618 μs** |      **0.8773 μs** |     **434.006 μs** |     **-36%** |    **0.5%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 8000    |     673.356 μs |     2.6182 μs |      3.3112 μs |     672.615 μs | baseline |         |    523.4375 |           - |           - |   6584000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **9000**    |     **494.208 μs** |     **1.1620 μs** |      **1.4695 μs** |     **494.606 μs** |     **-48%** |    **0.4%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 9000    |     956.227 μs |     2.3268 μs |      2.9427 μs |     956.050 μs | baseline |         |   1041.0156 |           - |           - |  13140000 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **10000**   |     **609.690 μs** |    **18.7883 μs** |     **25.0819 μs** |     **599.164 μs** |     **-43%** |    **5.5%** |           **-** |           **-** |           **-** |           **-** |       **-100%** |
| CreatNewList  | 10000   |   1,066.596 μs |    33.1738 μs |     41.9542 μs |   1,056.572 μs | baseline |         |   1041.0156 |           - |           - |  13140001 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **20000**   |   **1,728.867 μs** |    **94.0537 μs** |    **125.5590 μs** |   **1,729.509 μs** |     **-65%** |    **7.1%** |           **-** |           **-** |           **-** |         **1 B** |     **-100.0%** |
| CreatNewList  | 20000   |   4,963.826 μs |    17.9521 μs |     21.3707 μs |   4,961.635 μs | baseline |         |   4164.0625 |   4164.0625 |   4164.0625 |  26251002 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **30000**   |   **2,415.284 μs** |   **166.4402 μs** |    **222.1930 μs** |   **2,471.769 μs** |     **-62%** |    **9.0%** |           **-** |           **-** |           **-** |         **2 B** |     **-100.0%** |
| CreatNewList  | 30000   |   6,404.390 μs |    11.2237 μs |     14.5939 μs |   6,404.204 μs | baseline |         |   4164.0625 |   4164.0625 |   4164.0625 |  26251002 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **40000**   |   **2,921.060 μs** |   **193.1088 μs** |    **257.7947 μs** |   **2,841.140 μs** |     **-80%** |    **8.7%** |           **-** |           **-** |           **-** |         **2 B** |     **-100.0%** |
| CreatNewList  | 40000   |  14,881.140 μs |    38.5942 μs |     50.1833 μs |  14,884.233 μs | baseline |         |  12484.3750 |  12484.3750 |  12484.3750 |  52470601 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **50000**   |   **3,589.852 μs** |   **207.3034 μs** |    **276.7442 μs** |   **3,520.990 μs** |     **-78%** |    **7.6%** |           **-** |           **-** |           **-** |         **2 B** |     **-100.0%** |
| CreatNewList  | 50000   |  16,274.730 μs |    48.3769 μs |     64.5818 μs |  16,286.406 μs | baseline |         |  12468.7500 |  12468.7500 |  12468.7500 |  52470602 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **60000**   |   **4,284.567 μs** |   **222.8146 μs** |    **297.4511 μs** |   **4,198.755 μs** |     **-78%** |    **6.9%** |           **-** |           **-** |           **-** |         **3 B** |     **-100.0%** |
| CreatNewList  | 60000   |  19,527.081 μs |   184.7176 μs |    246.5928 μs |  19,413.034 μs | baseline |         |  12468.7500 |  12468.7500 |  12468.7500 |  52470602 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **70000**   |   **4,943.631 μs** |   **319.9544 μs** |    **427.1300 μs** |   **4,871.114 μs** |     **-80%** |    **8.5%** |           **-** |           **-** |           **-** |         **3 B** |     **-100.0%** |
| CreatNewList  | 70000   |  24,664.111 μs |    75.7184 μs |     98.4553 μs |  24,683.767 μs | baseline |         |  28562.5000 |  28562.5000 |  28562.5000 | 104907210 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **80000**   |   **6,129.629 μs** |   **448.9472 μs** |    **599.3317 μs** |   **6,309.472 μs** |     **-78%** |    **9.9%** |           **-** |           **-** |           **-** |         **3 B** |     **-100.0%** |
| CreatNewList  | 80000   |  28,105.452 μs |   508.0536 μs |    678.2370 μs |  27,707.234 μs | baseline |         |  28562.5000 |  28562.5000 |  28562.5000 | 104907210 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **90000**   |   **6,344.314 μs** |   **289.1802 μs** |    **386.0472 μs** |   **6,216.409 μs** |     **-77%** |    **6.0%** |           **-** |           **-** |           **-** |         **3 B** |     **-100.0%** |
| CreatNewList  | 90000   |  28,113.302 μs |    72.0022 μs |     91.0598 μs |  28,134.256 μs | baseline |         |  28562.5000 |  28562.5000 |  28562.5000 | 104907210 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **100000**  |   **7,113.575 μs** |   **680.6219 μs** |    **908.6107 μs** |   **6,838.427 μs** |     **-73%** |   **12.5%** |           **-** |           **-** |           **-** |         **3 B** |     **-100.0%** |
| CreatNewList  | 100000  |  26,393.972 μs |    98.0204 μs |    116.6864 μs |  26,394.944 μs | baseline |         |  28562.5000 |  28562.5000 |  28562.5000 | 104907210 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **200000**  |  **14,286.307 μs** | **1,041.5720 μs** |  **1,390.4689 μs** |  **13,843.416 μs** |     **-81%** |    **9.6%** |           **-** |           **-** |           **-** |         **6 B** |     **-100.0%** |
| CreatNewList  | 200000  |  75,665.102 μs |   477.1609 μs |    620.4440 μs |  75,574.525 μs | baseline |         |  49875.0000 |  49875.0000 |  49875.0000 | 209774408 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **300000**  |  **17,804.970 μs** |   **191.0536 μs** |    **248.4236 μs** |  **17,684.428 μs** |     **-86%** |    **3.1%** |           **-** |           **-** |           **-** |        **12 B** |     **-100.0%** |
| CreatNewList  | 300000  | 131,635.333 μs | 2,774.9125 μs |  3,608.1703 μs | 133,236.487 μs | baseline |         |  99750.0000 |  99750.0000 |  99750.0000 | 419508816 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **400000**  |  **25,422.162 μs** |   **751.7251 μs** |    **977.4550 μs** |  **25,579.152 μs** |     **-83%** |    **4.8%** |           **-** |           **-** |           **-** |        **12 B** |     **-100.0%** |
| CreatNewList  | 400000  | 148,346.866 μs | 3,310.7234 μs |  4,419.7210 μs | 150,438.075 μs | baseline |         |  99750.0000 |  99750.0000 |  99750.0000 | 419508816 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **500000**  |  **31,261.421 μs** |   **165.3071 μs** |    **196.7863 μs** |  **31,215.556 μs** |     **-81%** |    **5.4%** |           **-** |           **-** |           **-** |        **25 B** |     **-100.0%** |
| CreatNewList  | 500000  | 166,659.747 μs | 6,581.7323 μs |  8,786.4244 μs | 168,501.425 μs | baseline |         |  99750.0000 |  99750.0000 |  99750.0000 | 419508816 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **600000**  |  **50,980.590 μs** |   **772.5889 μs** |    **977.0777 μs** |  **51,201.817 μs** |     **-79%** |    **4.2%** |           **-** |           **-** |           **-** |        **33 B** |     **-100.0%** |
| CreatNewList  | 600000  | 242,218.377 μs | 7,825.4027 μs |  9,610.2981 μs | 240,154.825 μs | baseline |         | 198000.0000 | 198000.0000 | 198000.0000 | 838968884 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **700000**  |  **48,034.409 μs** | **1,459.4891 μs** |  **1,948.3762 μs** |  **47,659.427 μs** |     **-82%** |    **5.7%** |           **-** |           **-** |           **-** |        **36 B** |     **-100.0%** |
| CreatNewList  | 700000  | 260,868.678 μs | 8,240.0418 μs | 11,000.2200 μs | 256,761.400 μs | baseline |         | 193500.0000 | 193500.0000 | 193500.0000 | 838966796 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **800000**  |  **50,469.331 μs** |   **880.3179 μs** |  **1,175.1991 μs** |  **50,269.291 μs** |     **-81%** |    **4.6%** |           **-** |           **-** |           **-** |        **36 B** |     **-100.0%** |
| CreatNewList  | 800000  | 267,407.074 μs | 9,544.6887 μs | 10,608.8962 μs | 271,313.750 μs | baseline |         | 198500.0000 | 198500.0000 | 198500.0000 | 838968968 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **900000**  |  **75,829.750 μs** |   **598.1237 μs** |    **798.4780 μs** |  **75,931.580 μs** |     **-73%** |    **3.4%** |           **-** |           **-** |           **-** |        **40 B** |     **-100.0%** |
| CreatNewList  | 900000  | 285,734.272 μs | 7,540.2571 μs |  9,536.0117 μs | 284,801.950 μs | baseline |         | 189500.0000 | 189500.0000 | 189500.0000 | 838965104 B |             |
|               |         |                |               |                |                |          |         |             |             |             |             |             |
| **UsePooledList** | **1000000** |  **64,513.506 μs** | **1,873.3376 μs** |  **2,435.8682 μs** |  **64,110.239 μs** |     **-78%** |    **5.1%** |           **-** |           **-** |           **-** |        **44 B** |     **-100.0%** |
| CreatNewList  | 1000000 | 296,918.974 μs | 7,648.7902 μs | 10,210.9161 μs | 299,393.600 μs | baseline |         | 183000.0000 | 183000.0000 | 183000.0000 | 838962476 B |             |
