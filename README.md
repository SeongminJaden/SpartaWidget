# 🛠 SpartaWidget

**SpartaWidget**은 Windows용 **투명한 위젯**으로, 스파르타코딩클럽 내일배움캠프 대원들을 위해 </br>출석체크부터 안드로이드스튜디오 실행까지 어플리케이션을 빠르게 실행할 수 있도록 만들어졌습니다`.  
또한 **트레이 아이콘을 통해 설정 변경이 가능**하며, 백그라운드에서 실행됩니다.

![_2025_03_12_00_55_36_671-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/3f1ff4e5-06a1-41ba-a728-b20a9ffbc1b8)
---

## 📌 기능
- ✅ **투명한 UI** (윈도우 창 없음)
- ✅ **출석 체크 / Slack / ZEP / Android Studio  실행 버튼**
- ✅ **사용자 이름 및 메시지 변경**
- ✅ **트레이 아이콘으로 설정 창 접근 가능**
- ✅ **백그라운드 실행**

---

## 📂 프로젝트 구조
```plaintext
SpartaWidget/
│── SpartaWidget.sln          # 솔루션 파일
│
├── SpartaWidget/             # 메인 프로젝트 폴더
│   ├── App.xaml              # 애플리케이션 정의 파일
│   ├── App.xaml.cs           # 애플리케이션 진입점 코드
│   ├── MainWindow.xaml       # 메인 위젯 UI
│   ├── MainWindow.xaml.cs    # 메인 위젯 기능 구현
│   ├── SettingsWindow.xaml   # 설정 창 UI
│   ├── SettingsWindow.xaml.cs# 설정 창 기능 구현
│   ├── Resources/            # 이미지 및 리소스 폴더
│   │   ├── attendance.png    # 출석 체크 아이콘
│   │   ├── slack.png         # Slack 아이콘
│   │   ├── zep.png           # ZEP 아이콘
│   │   ├── android.png       # Android Studio 아이콘
│   │   ├── settings.png      # 설정 아이콘
│   ├── settings.txt          # 사용자 설정 저장 파일
│   └── SpartaWidget.csproj   # 프로젝트 파일
```

---

## 🚀 실행 방법

### Visual Stuido에서 실행할 경우
1. 프로젝트를 클론합니다.
   ```sh
   git clone https://github.com/SeongminJaden/SpartaWidget.git
   ```
2. `SpartaWidget.sln` 파일을 Visual Studio에서 엽니다.
3. `빌드 > 솔루션 빌드`를 실행합니다.
4. `SpartaWidget.exe` 실행 파일을 실행합니다.
### SetupFile로 설치하여 실행할 경우
1. 프로젝트를 클론합니다.
   ```sh
   git clone https://github.com/SeongminJaden/SpartaWidget.git
   ```
2.SpartaWidget/install spartaWidget/Debug 폴더에 들어갑니다.
---
3. setup.exe를 실행하여 설치합니다.
4. 바탕화면에 표시된 "spartaWidget"을 클릭하여 실행합니다.
5. 시작프로그램 등 설정은 자유!

## ⚙ 설정 방법
1. 트레이 아이콘에서 **설정**을 클릭합니다.
2. 사용자 이름과 메시지를 입력하고 저장합니다.
3. 메시지 색상을 변경할 수 있습니다.

---

## 📜 라이선스
이 프로젝트는 MIT 라이선스를 따릅니다

## 📌 개발자
roboticsmaster@naver.com
내일배움캠프 Flutter 창업6기 이성민.
