   M S B A M L   `   `   `  ����L  HRestaurantAdvisor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RestaurantAdvisorRestaurantAdvisor  5      $    RestaurantAdvisor.OrderHistory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:RestaurantAdvisor     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  OrderHistory��5      $	��800��5	      $	��450��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��15* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $	��20* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ 
textBlock1��5      $��0��5      $��1��5      $��119,2q�5      $��Center=�5       $��Center=�5!      $��20(�5"      $
��Bold"�5#      $ ��Summary of all past orders��5$      �� 5&   
   -   5         ��Name$ listBox1��5'      $��2��5(      $��1��5)      $��Baskerville Old face)�5*      $��20(�5+      �� 5-   
   -   5         ��Name$ line1��5.      $��0��5/      $��0��50      $��4��51      
��� � �$��2��53      	 �� X1$ 0��54      	 �� X2$	 900��55      	 �� Y1$ 28��56      		 �� Y2$	 28��57      �� 59   
   -   5        $ line2��5:      $��3��5;      $��1��5<      $��1��5=      
���   �$��2��5?      $ 0��5@      $	 900��5A      $ 3��5B      $	 3��5C      �� 5E   
   -   5        $ line3��5F      $��3��5G      $��1��5H      $��1��5I      
���   �$��2��5K      $ 0��5L      $	 900��5M      $ 45��5N      $	 45��5O      �� 5Q   
   -   5        
 ��Name$
 stackPanel1��5R      $��3��5S      $��1��5T       �� Orientation$ 
Horizontal=�5U      .+�5V      �� -   5         ��Name$ button1��5W      $	��350��5X      $��10,0,0,8q�5Y      $��Center=�5Z      $��Bottom=�5[      
������
���E��$��Display all past orders��5_      $��20(�5`      �� 5b      -   5        $ button2��5c      $	��245��5d      $��50,0,0,8q�5e      $��Center=�5f      $��Bottom=�5g      
�������
���E��$��Delete specific order��5k      $��20(�5l      5m      5p      5q      