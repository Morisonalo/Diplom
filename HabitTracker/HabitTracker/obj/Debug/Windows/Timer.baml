   M S B A M L   `   `   `  ����G  CHabitTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HabitTrackerHabitTracker  5           HabitTracker.Windows.Timer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ,localclr-namespace:HabitTracker     5        � Title$  
MainWindow��5      $	��700��5	      $
��1000��5
       � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      
������ .��5      � .+�5   
   �� ���#ffffff �� CornerRadius$ 30��5      ._�5      �  � ColumnDefinitions 5      �� 5      $
��0.1* �6'   �� 5      .+�5      �� ���	#ffdadada$ 	30,0,0,30��62   $��0��6K   ._�5      �� .+�5      �� -   5         ��Name$
 User��5   !   $��28��6/   $��28��6;   $��0,32,0,0q�6]    � ToolTip$! Личный кабинет��6o   ��6F   Z� ��6�   Z� ��5      �� 5    "    �� ImageSource$3 -/Windows/free-icon-male-user-shadow-16480.png��6-   .��5"      �� $%��/Image/male-user-shadow (1).png��6$   5#      �� 5%      -   5        $ Timer1��5%   !   $��28��61   $��28��6=   $��0,35,0,0q�6H   $ Таймер��6�   ��6Z   Z� ��6p   Z� ��5&      �� 5'   "   $* $/Windows/free-icon-timer-1827484.png��6-   .��5)      �� $��/Image/dots.png��6$   6@   5*      �� 5,      -   5        $ Habit��5,   !   $��28��60   $��28��6<   $��0,36,0,0q�6G   $ Привычки��6p   ��6Y   Z� ��5-      �� 5.   "   $, &/Windows/free-icon-changes-9038160.png��6-   .��50      �� $��/Image/goals (1).png��6$   6D   51      �� 53      -   5        $ Matrix��53   !   $��28��61   $��28��6=   $��0,40,0,0q�6H   $- 'Матрица Эйзенхаузера��6q   ��6Z   Z� ��54      �� 55   "   $, &/Windows/free-icon-locator-1150947.png��6-   .��57      �� $��/Image/locator.png��6$   6D   58      �� 5:      	 �� Orientation$	 
Horizontal=�6%   $��	0,360,0,0q�6>   $��Center=�6Q   5;      5<      5=      5>      �� 5@   
   -   5        $ Close��5@      $��20��6    $��20��6,   $) #Закрыть приложение��6N   
 J� RenderTransformOrigin$
 0.5,0.5&�6   $��34,580,946,100q�6�   ��67   Z� ��5A      �� 5B      $* $/free-icon-close-cross-64498 (1).png��6   .��5D      �� $��/Image/close-cross.png��6   5E      �� 5G   
   -   5        $�� ��5G      $
��Left=�6   $��
34,623,0,0q�67   $	��Top=�6K   $��28��6c   $��28��6�   $
 0.5,0.5&�6�   ��6n   Z� ��6�   Z� ��5H      �� 5I      $  /free-icon-exit-603069.png��6   5K      A� 5M   
   -   5         A�Name$ timerCircle��5M      $	��400��5N   
   $	��400��5O   
   
�������$��10��5Q   
   $��Center=�5R   
   $��Center=�5S   
   A� 5T   
   -   5        $ progressCircle��5T      $	��400��5U   
   $	��400��5V   
   ���	#FF673AB7$��10��5X   
    �� StrokeDashArray$	 628R�5Y   
    �� StrokeDashOffset$	 628Q�5Z   
   $
 0.5,0.5&�5[   
   $��Center=�5\   
   $��Center=�5]   
    � Cursor$  ��6'   z�5^      �� 5_       �� Angle$	 -90Q�6"   5a      �� 5b   
   -	   5         ��Name$ timeText��5b      $��Center=�5c      $��Center=�5d      $��24(�5e      �� 5h   
   -
   5        $ startStopButton��5h      $��Начать��6*   $��300,602,575,63q�6;   6S   �� 5i   
   -   5        $ resetButton��5i      $��Сбросить��6&   $��581,604,321,64q�69   6Q   �� 5j   
   $
��Left=�6   $��
142,36,0,0q�6/   $
��Wrap=�6C   $��Помодро��6W   $	��Top=�6f   $	��220��6~   $��42(�6�   $
��Bold"�6�   5n      5r      