   M S B A M L   `   `   `  ����D  @LiarsDice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LiarsDice	LiarsDice  5   	       LiarsDice.Shop   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LiarsDice     5   	   -   5          � Title$
  Shop��5   	   $	��450��6   $	��800��6#    � WindowState$ 	Maximized=�6/    � 
ResizeMode$ 	CanResize=�6G   $	��450��6^   $	��800��6n   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      �� 5      $��0 �6   .+�5   
   �� -   5        $��ShopBG��5      $
��Fill=�6%   $��Stuff/ShopBackground.jpg��64   $��2��6V   �� 5   
   $	��110��6%   $	��680��63    J� Opacity$	 0.7Q�6?   
�������$��Stretch=�6Y   $��59,58,55,252q�6w   $��Stretch=�6�   $��1��6�   �� 5   
   -   5        $��	WhiteDice��5      $��90��6%   $��90��61   $��Stretch=�6<   $��66,70,638,261q�6Z   $��Stretch=�6q   $��Stuff/Dice/White6.png��6�   $��1��6�   �� 5   
   -   5        $��LeatherDice��5      $��90��6%   $��90��61   $��Stretch=�6<   $��352,70,352,261q�6Z   $��Stretch=�6r   $��Stuff/Dice/Leather6.png��6�   $��1��6�   �� 5   
   -   5        $��JackDice��5      $��90��6%   $��90��61   $��Stretch=�6<   $��642,70,62,261q�6Z   $��Stretch=�6q   $��Stuff/Dice/Jacks6.png��6�   $��1��6�   �� 5   
   -   5        $��RainbowrDice��5      $��90��6%   $��90��61   $��Stretch=�6<   $��500,70,204,261q�6Z   $��Stretch=�6r   $��Stuff/Dice/Rainbow6.png��6�   $��1��6�   �� 5   
   -   5        $��WoodDice��5      $��90��6%   $��90��61   $��Stretch=�6<   $��211,70,493,261q�6Z   $��Stretch=�6r   $��Stuff/Dice/Wood6.png��6�   $��1��6�   �� 5   
   $��50��6%   $��50��61   $	��100��6@   $	��190��6P   $	��190��6\   $	��240��6k   $��Stretch=�6z   $��Stretch=�6�   $��Stuff/YearPlank.png��6�   $��603,0,0,371q�6�   $��1��6�   �� 5   
   $	��130��6%   $	��680��62   $	 0.7Q�6>   
�������$��Stretch=�6X   $��59,223,55,68q�6v   $��Stretch=�6�   $��1��6�   �� 5   
   -   5        $��	DefaultBG��5      $	��115��6%   $	��155��62   $��Stretch=�6>   $��66,230,572,75q�6\   $��Stretch=�6s   $��Stuff/PlaygroundBG.jpg��6�   $��1��6�   �� 5   
   -	   5        $��BarBG��5      $	��116��6%   $	��169��62   $��Stretch=�6>   $��284,230,341,75q�6\   $��Stretch=�6t   $��Stuff/BarPlayground.jpg��6�   $��1��6�   �� 5   
   -
   5        $��	KajuterBG��5      $	��165��6%   $	��224��62   $��Stretch=�6>   $��504,207,66,50q�6\   $��Stretch=�6s   $ ��Stuff/KajutePlayground.jpg��6�   $��1��6�   �� 5   
   -   5        $��CloseGameBG��5      $��50��6%   $��50��61   $	��250��6@   $	��150��6P   $	��150��6\   $	��350��6k   $��Stretch=�6z   $��Stretch=�6�   $��Stuff/MenuPlank.png��6�   $��0,3,644,368q�6�   $��1��6�   �� 5    
   -   5        $��
BGUseWhite��5       $��Stretch=�6%   $��60��6C   $��60��6R   $��Stretch=�6^   $	��100��6z   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��61,165,633,196q�6�   $��1��6�   �� 5!   
   -   5        $��	BGBuyWood��5!      $��Stretch=�6$   $��60��6B   $��60��6Q   $��Stretch=�6]   $	��100��6y   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��206,152,488,209q�6�   $��1��6�   �� 5"   
   -   5        $��	BGUseWood��5"      $��Stretch=�6$   $��60��6B   $��60��6Q   $��Stretch=�6]   $	��100��6y   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��206,178,488,183q�6�   $��1��6�   �� 5#   
   -   5        $��BGBuyLeather��5#      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��100��6|   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��347,152,347,209q�6�   $��1��6�   �� 5$   
   -   5        $��BGUseLeather��5$      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��100��6|   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��347,178,347,183q�6�   $��1��6�   �� 5%   
   -   5        $��BGBuyRainbow��5%      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��100��6|   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��495,152,199,209q�6�   $��1��6�   �� 5&   
   -   5        $��BGUseRainbow��5&      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��100��6|   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��495,178,199,183q�6�   $��1��6�   �� 5'   
   -   5        $��	BGBuyJack��5'      $��Stretch=�6$   $��60��6B   $��60��6Q   $��Stretch=�6]   $	��100��6y   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��637,152,57,209q�6�   $��1��6�   �� 5(   
   -   5        $��	BGUseJack��5(      $��Stretch=�6$   $��60��6B   $��60��6Q   $��Stretch=�6]   $	��100��6y   $	��100��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��637,178,57,183q�6�   $��1��6�   �� 5*   
   -   5        $��BGUseDefault��5*      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��172��6|   $	��172��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��58,355,564,6q�6�   $��1��6�   �� 5+   
   -   5        $��BGBuyBar��5+      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��188��6|   $	��188��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��275,340,331,21q�6�   $��1��6�   �� 5,   
   -   5        $��BGUseBar��5,      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��188��6|   $	��188��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��275,371,331,-10q�6�   $��1��6�   �� 5-   
   -   5        $��BGBuyKajute��5-      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��245��6|   $	��245��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��494,340,55,21q�6�   $��1��6�   �� 5.   
   -   5        $��BGUseKajute��5.      $��Stretch=�6'   $��60��6E   $��60��6T   $��Stretch=�6`   $	��245��6|   $	��245��6�   $
��Fill=�6�   $��Stuff/ChatButton.png��6�   $��494,371,55,-10q�6�   $��1��6�   �� 51   
   -   5        $��MyYears��51   $    �� 
IsReadOnly . $��20(�63   $��Cambria)�6A   
�������
������ 
������ $��1��6�   $��Stretch=�6�   $��614,13,129,368q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $��Stretch=�6�   $��40��6  $��50��6'   J� RenderTransformOrigin$ 0.5,0.5&�62  �� 52   
   -   5        $��	YearLable��52      $��Years��6!   $��20(�61   $��Cambria)�6?   
�������
������ 
������ $��1��6�   $��Stretch=�6�   $��669,8,62,381q�6�   $��Stretch=�6�   $��32��6�   $��62��6  �� 57   
   -   5        $
��Back��57      $��20(�6   $��Cambria)�6,   
�������
������ 
������ $
��Back��6�   $��1��6�   $��Stretch=�6�   $��11,10,653,376q�6�   $��Stretch=�6�   $	��130��6�   $��35��6  6  �� 58   
   -   5        $��UseWhite��58      $��22��6!   $��90��6-   $	��Use��68   $��15(�6F   $��Cambria)�6T   
�������
������ 
������ $��Stretch=�6�   $��66,183,638,216q�6�   $��Stretch=�6�   $��1��6  6  �� 59   
   -   5        $��BuyWood��59      $��22��6    $��90��6,   $	��Buy��67   $��15(�6E   $��Cambria)�6S   
�������
������ 
������ $��Stretch=�6�   $��211,170,493,229q�6�   $��Stretch=�6�   $��1��6  6  �� 5:   
   -   5        $��UseWood��5:      $��22��6%   $��90��61   $	��Use��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��211,196,493,203q�6�   $��Stretch=�6�   $��1��6
  6  �� 5;   
   -    5        $��
BuyLeather��5;      $��22��6%   $��90��61   $	��Buy��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��352,170,352,229q�6�   $��Stretch=�6�   $��1��6
  6  �� 5<   
   -!   5        $��
UseLeather��5<      $��22��6%   $��90��61   $	��Use��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��352,196,352,203q�6�   $��Stretch=�6�   $��1��6
  6  �� 5=   
   -"   5        $��
BuyRainbow��5=      $��22��6%   $��90��61   $	��Buy��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��500,170,204,229q�6�   $��Stretch=�6�   $��1��6
  6  �� 5>   
   -#   5        $��
UseRainbow��5>      $��22��6%   $��90��61   $	��Use��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��500,196,204,203q�6�   $��Stretch=�6�   $��1��6
  6  �� 5?   
   -$   5        $��BuyJack��5?      $��22��6%   $��90��61   $	��Buy��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��642,170,62,229q�6�   $��Stretch=�6�   $��1��6	  6  �� 5@   
   -%   5        $��UseJack��5@      $��22��6%   $��90��61   $	��Use��6<   $��15(�6J   $��Cambria)�6X   
�������
������ 
������ $��Stretch=�6�   $��642,196,62,203q�6�   $��Stretch=�6�   $��1��6	  6  �� 5B   
   -&   5        $��
UseDeafult��5B      $��22��6%   $	��156��61   $	��Use��6=   $��15(�6K   $��Cambria)�6Y   
�������
������ 
������ $��Stretch=�6�   $��66,373,572,26q�6�   $��Stretch=�6�   $��1��6	  6  �� 5C   
   -'   5        $��BuyBar��5C      $��22��6%   $	��169��61   $	��Buy��6=   $��15(�6K   $��Cambria)�6Y   
�������
������ 
������ $��Stretch=�6�   $��284,358,341,41q�6�   $��Stretch=�6�   $��1��6
  6  �� 5D   
   -(   5        $��UseBar��5D      $��22��6%   $	��169��61   $	��Use��6=   $��15(�6K   $��Cambria)�6Y   
�������
������ 
������ $��Stretch=�6�   $��284,389,341,10q�6�   $��Stretch=�6�   $��1��6
  6  �� 5E   
   -)   5        $��	BuyKajute��5E      $��22��6%   $	��224��61   $	��Buy��6=   $��15(�6K   $��Cambria)�6Y   
�������
������ 
������ $��Stretch=�6�   $��504,358,66,41q�6�   $��Stretch=�6�   $��1��6	  6  �� 5F   
   -*   5        $��	UseKajute��5F      $��22��6%   $	��224��61   $	��Use��6=   $��15(�6K   $��Cambria)�6Y   
�������
������ 
������ $��Stretch=�6�   $��504,389,66,10q�6�   $��Stretch=�6�   $��1��6	  6  5J      5K      