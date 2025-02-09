# Системи за контрол за версиите
---
## Съдържание

- Какво е система за контрол на версиите?
- Различни функционалности на VCS.
- Git и GitHub
---
## Какво е VCS?

- Система за управление на версиите (**Version Control System**) - софтуер, който помага на екипи да проследяват различните промени, които се прилагат върху кодова база с течение на времето.
---
- Често много програмисти работят върху един проект по едно и също време.
- Трябва лесно да се разбере коя промяна от кой програмист е въведена.
---
- Всяка промяна има допълнителна информация:
    - **Кой?**
    - **Кога?**
    - **Защо**
---
![](/Attachments/IT_Career_VCS_Pic_1.png)

---
- Проектът се пази в **хранилище**. Има два вида хранилища:
    - **централно** - споделя се от всички членове на екипа.
    - **локално** - използва е от един член.
---
- Членовете правят локални копия на централното хранилище, правят промени в локалното копие и записват тези промени в централното хранилище.
---
![](/Attachments/IT_Career_VCS_Pic_2.png)

---
- Понеже пазим различните версии на проекта, винаги можем да се върнем към по-стара версия, ако се окаже, че в новата има някаква грешка.
---
![](/Attachments/IT_Career_VCS_Pic_3.png)

---
- Ако искаме да направим промяна върху кода можем да я направим в отделен **клон** (**branch**). След като сме готови с промяна, може да **слеем** (**merge**) нашият клон  с основният.
---
![](/Attachments/IT_Career_VCS_Pic_4.png)

---
## Git

- Най-популярната VCS
- Предимства включват бързина и скалируемост
- Може да бъде трудна за начинаещи
---
### Конфигурация на потребител

```bash
git config user.email <вашият GitHub имейл>
git config user.name <вашето потребителско име в GitHub>
```
---
### Създаване на хранилище

- Ако искаме да пазим различните версии на нашият проект трябва да инициализираме **Git** хранилище в него.
```bash
git init # инициализира празно git хранилище
```

---
### Добавяне на промени

- След като сме направили промени в кода, ние трябва да ги добавим.
```bash
git add . # добавя всички направени промени
```

---
### Записване на промени

- След като сме добавили промените, ние трябва да ги запишем в нова версия на проекта.
```bash
git commit -m "<съобщение>" # записва нова версия на проекта
```

---
## GitHub

![](/Attachments/IT_Career_VCS_Pic_5.png)

---
- Популярна онлайн платформа, която ни позволява да управляваме различни наши проекти.
- Удобно място да пазим централни хранилища.
---

![](/Attachments/IT_Career_VCS_Pic_6.png)

---
### Клониране на хранилище

- Правим локално копие на централното хранилище
```bash
git clone <central-repo-url> # създава локално копие
```

---

### Синхронизиране на промени

- Записваме промени, направени в централното хранилище, в локалното.

```bash
git pull
```

---
### Добавяне на промени към централното хранилище

- Записваме промени, направени в локалното хранилище, в централното.

```bash
git push
```
