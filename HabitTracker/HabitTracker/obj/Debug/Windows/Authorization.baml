   M S B A M L   `   `   `  ����G  CHabitTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:HabitTracker.WindowsHabitTracker.Windows  5   	   (    "HabitTracker.Windows.Authorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:HabitTracker.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Authorization��5	   	   $	��700��5
   	   $
��1000��5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������ .��5      � .+�5   
   � .+�5      �� ���#ffffff �� CornerRadius$ 40��6*   $��141,48,220,178q�6<   �� 5      -   5         ��Name$ Login��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин��6    %  !MaterialDesignFloatingHintTextBox#��[  6E   $��294,245,374,405q�6�   �� 5      -   5        $ 	Password1��5   �   $! Введите пароль��6   #��[  6F   $��294,310,374,343q�6�   �� 5      -   5         ��Name$ ButtonAutho��5      $��
Войти��6*   $��49��6:   $	��160��6F   $��380,382,460,268q�6R   6k   �� 5      -   5         ��Name$ TextBlockReg��5      $
��Left=�6.   
���   �$��	Underline{�6\   $��407,453,0,224q�6�   �� 6�   $(�"Нет учетной записи��6�   6�   5      �� 5   
   $	��400��6   $��255,128,343,0q�6    ���	#FF673AB7$	��Top=�6N   	 �� Padding$	 20q�6f   $	��550��6s   $ 30��6�   $��59��6�   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5"      �� $��Center=�6   $
��Wrap=�65   $#��Приветствую вас��6I   $
��Bold"�6b   
�������$��22(�6�   $��0,0,0,-5q�6�   $��Arial Black)�6�   5#      5$      5%      