   M S B A M L   `   `   `  ����I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  5      '    !DBServerClient.Pages.TestViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DBServerClient.Pages     5        N� Title$  TestViewPage��5	       N� 
Foreground
 �P�� N� 
Background �	#FF49BCD9.��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5"   
   �� $��1��6   $��1��5#      $��20(�5$       �� Padding$ 0,0,20,0q�5%      	Test Name5'      �� 5*   
   -   5         ��Name$ TestNameTextBox��5*      $��2��5+      $��1��5,      $	��255��5-      $��20(�5.      $��
ExtraLight"�5/      �� 52   
   -   5         ��Name$ TestNameListBox��52      $��2��53      $��2��54      $	��100��55      $
��Auto=�56      $
��Auto=�57      ��59      �� 5:      .R�5;      �� $��20(�5<      ��5=      �� 5>      5@      �� 5C   
   -   5         ��Name$ TestSearchButton��5C      $��3��5D      $��1��5E      $��20(�5F         ButtonStyle#��[  5G      .��5H   4   Search5I      �� 5L   
   $��3��6   $��1��5M      $��20(�5N      $ 0,0,0,20q�5O      $��Selected Test:��5P      �� 5Q   
   -   5        	 ��Name$	 SelectedTestLabel��5Q      $ 0,0,0,20q�5R      $��3��5S      $��2��5T      $��2��5U      $��20(�5V      �� 5X   
   -   5        $ GetTestButton��5X      $��4��5Y      $��3��5Z      $��0,0,0,20q�5[      $��20(�5\      #��[  5]      .��5^   1   
Get Test5`      �� 5c   
   $��4��6   $��1��5d      $��20(�5e      $��Test:��5f      &   System.Windows.Controls.DataGrid  5g   
   -   5        
  Name$
 
QADataGrid��5h      $��0,0,0,20q�5g         AutoGenerateColumns . ���	#FF49BCD9   
IsReadOnly . $
��Auto=�5l      $
��Auto=�5m      $��Stretch=�5n      $��Stretch=�5o         AlternatingRowBackground �	#FF56DDFF$
��auto��5r      $��4��5s      $��4��6   $��2��5t      ��5q      �� 5u      �� 5x   
   $��5��6   $��1��5y      $��20(�5z      $��Test Users:��5{        5|   
   -   5        $
 UsersDataGrid��5|       .  �	#FF56DDFF���	#FF49BCD9 . $��Stretch=�5�      $��Stretch=�5�      $
��Auto=�5�      $
��Auto=�5�      $��5��5�      $��4��6   $��2��5�      ��5�      �� 5�      5�      5�      