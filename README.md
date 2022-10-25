# Лабораторная работа № 3 Реализация интерфейса пользователя
Отчет по лабораторной работе №3 выполнил:
- Строшков Артем Валерьевич
- РИ-300004

Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * |  |
| Задание 2 | * |  |
| Задание 3 | # |  |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы
Создание интерактивного приложения и изучение принципов интеграции в него игровых сервисов.

## Задание 1
### Используя видео-материалы практических работ 1-5 повторить реализацию игровых механик:
### – 1 Практическая работа «Реализация механизма ловли объектов».
### – 2 Практическая работа «Реализация графического интерфейса с добавлением счетчика очков».

#### Ход работы (задание 1).
1) Реализовать управление энергетическими щитами с помощью движения мыши

```cs

   void Update() {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

```

2) Реализовать "ловлю" объекта

```cs

    private void OnCollisionEnter(Collision coll) {
        GameObject Collided  = coll.gameObject;
        if(Collided.tag == "Dragon Egg"){
            Destroy(Collided);
        }
    }

```



3) Добавить счетчик очков и настроить его
 
![image](Screenshots/ScoreText.png)

4) Изменить скрипт ловли объектов

```cs

   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnergyShield : MonoBehaviour
{
    public TextMeshProUGUI scoreGT;
    void Start() {
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreGT.text = "0";
    }
    void Update() {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll) {
        GameObject Collided  = coll.gameObject;
        if(Collided.tag == "Dragon Egg"){
            Destroy(Collided);
        }
        int score = int.Parse(scoreGT.text);
        score += 1;
        scoreGT.text = score.ToString();
    }
}

```

## Задание 2
### Используя видео-материалы практических работ 1-5 повторить реализацию игровых механик:
### – 3 Практическая работа «Уменьшение жизни. Добавление текстур».
### – 4 Практическая работа «Структурирование исходных файлов в папке».

#### Ход работы (задание 2).
1) Импотрировать плагин PluginYG
2) Написать скрипт:

![image](Screenshots/SDK_Script.png)

3) Добавить на сцену пустой объект, в который добавить написанный скрипт

![image](Screenshots/GameObject.png)

4) Добавить на сцену готовый префаб YandexGame, настроить его

![image](Screenshots/YandexGame.png)

5) При запуске игры через сервис Яндекс игры на месте "unauthorized" будет написано имя пользователя

![image](Screenshots/AuthCheck.png)


## Задание 3
### Используя видео-материалы практических работ 1-5 повторить реализацию игровых механик:
### 5 Практическая работа «Интеграция игровых сервисов в готовое приложение».

#### Ход работы (задание 3).




## Выводы
- Начал работу над Dragon Picker, научился работать с сервисом "Яндекс игры" и sdk для них

