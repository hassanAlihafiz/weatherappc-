   M S B A M L   `   `   `  ����I  EWeatherApp_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WeatherApp_wpfWeatherApp_wpf  5   	       WeatherApp_wpf.WindSpeed   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WeatherApp_wpf     5   	     � Title$  	WindSpeed��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   ]� $
��Left=�6   $��43��6/   ��.  $��	10,10,0,0q�6Q   $	��Top=�6d   $	��772��6|   .+�5      �� -   5         ��Name$
 back��5   <   $��Right=�6   $
��Back��6-   $��43��6]   $	��Top=�6i   $��74��6�   �� 5      $
��Left=�6   $
��Open��6+   $��43��6:   $	��Top=�6F   $��75��6^   5      �� 5   
   $��Enter Wind Speed:��6   $
��Left=�6,   $��
22,137,0,0q�6G   $	��Top=�6[   $	��118��6s   �� 5   
   $��Calculate Wind Speed ��6   $
��Left=�62   $��
134,87,0,0q�6M   $	��Top=�6a   $	��194��6y   �� 5   
   -   5         ��Name$ txtinput��5      $
��Left=�6$   $��23��6?   $��145,140,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $	 Cal��5   %   $��	Calculate��6   $
��Left=�6D   $��292,137,0,0q�6_   $	��Top=�6t   $��74��6�   $��26��6�   �� 5   
   -   5         ��Name$ convertLabel��5      $�� ��6&   $
��Left=�61   $��
64,186,0,0q�6L   $	��Top=�6`   $	��288��6x   �� 5   
   -   5        $ feetperhour��5      $�� ��6   $
��Left=�60   $��
64,231,0,0q�6K   $	��Top=�6_   $	��288��6w   �� 5   
   -   5        $ Knots��5      $�� ��6   $
��Left=�6*   $��
64,277,0,0q�6E   $	��Top=�6Y   $	��288��6q   �� 5   
   $9��3First Open File Then We Will Provide Beaufort Value��6   $
��Left=�6N   $��
450,87,0,0q�6i   $	��Top=�6}   $	��295��6�   �� 5   
   $��OpenFile��6   $
��Left=�6$   $��555,122,0,0q�6?   $	��Top=�6T   $��76��6l   5      5      