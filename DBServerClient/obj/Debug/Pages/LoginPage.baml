   M S B A M L   `   `   `  ����I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  5      $    DBServerClient.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DBServerClient.Pages     5        N� Title$  	LoginPage��5	       N� 
Background �	#FF49BCD9 N� 
Foreground
 �P��.��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��5      $
��Name��5       $��40(�5!       �� Padding$ 20,20,20,20q�5"      �� 5$   
   -   5         ��Name$ NameTextBox��5$      $��1��5%      $��2��5&      $	��330��5'      $��40(�5(      $��10,10,10,10q�5)      ��5*      �� *Name+�� 5,   
   $��2��6   $��1��5-      $��Password��5.      $��40(�5/      $ 20,20,20,20q�50      �� 52   
   -   5        $ PasswordTextBox��52      $��2��53      $��2��54      $	��330��55      $��40(�56      $��10,10,10,10q�57      ��58      �� *
Password+�� 5:   
   -   5         ��Name$ LoginButton��5:      $��1��5;      $��3��5<      $��40(�5=      $��20,20,20,20q�5>      $��Login��5?         ButtonStyle#��[  5@      5A      5C      5D      