   M S B A M L   `   `   `  ���� I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  '    !DBServerClient.Pages.TestViewPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:DBServerClient.Pages       N� Title$  TestViewPage�� N� 
Foreground
 �P�� N� 
Background �	#FF49BCD9.���  � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��100* ��� $
��100* ��� $��* ��� $��20 � � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� $��1��$��1��$��20(� �� Padding$ 0,0,20,0q�	Test Name�� -    ��Name$ TestNameTextBox��$��2��$��1��$	��255��$��20(�$��
ExtraLight"��� -    ��Name$ TestNameListBox��$��2��$��2��$	��100��$
��Auto=�$
��Auto=����� .R��� $��20(����� �� -    ��Name$ TestSearchButton��$��3��$��1��$��20(�   ButtonStyle#��[  .��Search�� $��3��$��1��$��20(�$ 0,0,0,20q�$��Selected Test:���� -   	 ��Name$	 SelectedTestLabel��$ 0,0,0,20q�$��3��$��2��$��2��$��20(��� -   $ GetTestButton��$��4��$��3��$��0,0,0,20q�$��20(�#��[  .��
Get Test�� $��4��$��1��$��20(�$��Test:��&   System.Windows.Controls.DataGrid  -   
  Name$
 
QADataGrid��$��0,0,0,20q�   AutoGenerateColumns . ���	#FF49BCD9   
IsReadOnly . $
��Auto=�$
��Auto=�$��Stretch=�$��Stretch=�   AlternatingRowBackground �	#FF56DDFF$
��auto��$��4��$��4��$��2������ �� $��5��$��1��$��20(�$��Test Users:��  -   $
 UsersDataGrid�� .  �	#FF56DDFF���	#FF49BCD9 . $��Stretch=�$��Stretch=�$
��Auto=�$
��Auto=�$��5��$��4��$��2������ 