   M S B A M L   `   `   `  ����I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  5      '    !DBServerClient.Pages.RegisterPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DBServerClient.Pages     5        N� Title$  RegisterPage��5	       N� 
Background �	#FF49BCD9 N� 
Foreground
 �P��.��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5!   
   �� $��1��6   $��1��5"      $
��Name��5#      $��40(�5$       �� Padding$ 20,20,20,20q�5%      �� 5'   
   -   5         ��Name$ NameTextBox��5'      $��1��5(      $��2��5)      $	��330��5*      $��40(�5+      $��10,10,10,10q�5,      ��5-      �� *Name+�� 5/   
   $��2��6   $��1��50      $��Location��51      $��40(�52      $ 20,20,20,20q�53      �� 55   
   -   5        $ LocationTextBox��55      $��2��56      $��2��57      $��40(�58      $	��330��59      $��10,10,10,10q�5:      ��5;      �� *
Location+�� 5=   
   $��3��6   $��1��5>      $��Password��5?      $��40(�5@      $ 20,20,20,20q�5A      �� 5C   
   -   5        $ PasswordTextBox��5C      $��3��5D      $��2��5E      $��40(�5F      $	��330��5G      $��10,10,10,10q�5H      ��5I      �� *
Password+�� 5L   
   -   5         ��Name$ RegisterButton��5L      $��1��5M      $��4��5N      $��40(�5O      $��20,20,20,20q�5P      $��Register��5Q         ButtonStyle#��[  5R      5S      5U      5V      