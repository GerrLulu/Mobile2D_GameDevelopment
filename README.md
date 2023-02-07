# Mobile2D_GameDevelopment
Home work for GeekBrains


Урок 1. Создание контроллера персонажа
Основные задания:
1. Добавьте новое состояние игры GameState - Settings. Для перехода в этот режим добавим соответствующую кнопку на экран MainMenuView, нажатие на которую будет менять состояние игры. На экране настроек создадим единственную кнопку Back, которая будет возвращаться нас обратно в MainMenuView.
2. Реализуйте новый тип управления - стрелками на клавиатуре. При нажатии клавиши ← должно происходить движение влево, а при нажатии → движение вправо.


Урок 2. Создание игровой сборки и внедрение мобильных плагинов
Основные задания:
1. Собрать apk-файл для Android (нужно прикрепить к дз).
2. Для аналитики добавить новое событие, отвечающее за начало уровня (т.е. при запуске GameController) и вызвать его в соответствующий момент.
3. Для рекламы реализовать проигрыватель Rewarded рекламы. Добавить новую кнопку на MainMenuView, по нажатию на которую будет запускаться показ Rewarded рекламы.
4. Для внутриигровых покупок реализовать покупку какого-нибудь предмета. Покупку совершать по нажатию на кнопку, которую так же необходимо добавить на MainMenuView.

Дополнительные задания:
1. Реализовать для всех интегрированных сервисов паттерн "Одиночка" и убрать прямые ссылки на них через инспектор в коде.
2. Для аналитики реализовать событие о покупке предмета, используя метод Analytics.Transaction
(https://docs.unity3d.com/ScriptReference/Analytics.Analytics.Transaction.html). Можно встроить в IAPService. Примечание: чтобы быть уверенными,
что созданные методы выполняются, можно добавить в них логгирование.


Урок 3. Создание способностей и предметов экипировки
Основные задания:
1. Добавьте новую характеристику для транспорта - высота прыжка (JumpHeight), как это было ранее сделано для скорости. Соответственно потребуется дополнить модель транспорта. Эту настройку мы сможем модифицировать нашими улучшениями.
2. Создайте свои элементы экипировки (2-3 штуки, например, тормозную систему или трансмиссию).
3. Создайте свои улучшения для новых элементов экипировки (2-3 штуки, в т.ч. реализуйте улучшение для высоты прыжка).
Дополнительное задание:
4. * Реализуйте способность "Прыжок", которая позволит машинке отрываться от земли на какое-то время. Можно использовать физику. Можно без анимаций и плавности. Главное не реализовать сам прыжок, а реализовать новую способность.
