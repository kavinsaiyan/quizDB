   M S B A M L   `   `   `  ���� I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  &     DBServerClient.Pages.EnterQAPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:DBServerClient.Pages       N� Title$  EnterQAPage�� N� 
Background �	#FF49BCD9 N� 
Foreground
 �P��.���� $
��Auto=�$
��Auto=�.���  � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� -    ��Name$ QuestionTextBlock��$��1��$��1��$��Question Number:0��$��20(� �� Padding$ 5,5,5,5q��� $��2��$��1��$
��Auto=�$	��100��$	��520��$��4��.���� -    ��Name$ QuestionTextBox��$��20(����� *
Question+�� $��3��$��1��$��	Option :1��$��20(�$ 10,10,10,10q��� $��3��$��2��$
��Auto=�$	��100��$	��100��$��3��$��	10,10,0,0q�.���� -   $ Option1TextBox��$��20(����� *	Answer1+�� $��4��$��1��$��	Option :2��$��20(�$ 10,10,10,10q��� $��4��$��2��$
��Auto=�$	��100��$	��100��$��3��$��	10,10,0,0q�.���� -   $ Option2TextBox��$��20(����� *	Answer2+�� $��5��$��1��$��	Option :3��$��20(�$ 10,10,10,10q��� $��5��$��2��$
��Auto=�$	��100��$	��100��$��3��$��	10,10,0,0q�.���� -   $ Option3TextBox��$��20(����� *	Answer3+�� $��6��$��1��$��	Option :4��$��20(�$ 10,10,10,10q��� $��6��$��2��$
��Auto=�$	��100��$	��100��$��3��$��	10,10,0,0q�.���� -   $ Option4TextBox��$��20(����� *	Answer4+��  �� Orientation$ 
Horizontal=�$��7��$��4��$��1��.+��� $��Set correct option:��$ 0,0,30,0q�$��20(�	� -   	 	�Name$	 Option1RadioButton��$��1��$��20(�$��	30,0,30,0q�
���P��	� -   $	 Option2RadioButton��$��2��$��20(�$��	30,0,30,0q�
���P��	� -	   $	 Option3RadioButton��$��3��$��20(�$��	30,0,30,0q�
���P��	� -
   $	 Option4RadioButton��$��4��$��20(�$��	30,0,30,0q�
���P��� $��8��$��1��$��4�� �� $
��auto ��� $��* ��� $
��auto ��� $��* ��� $
��auto �.+��� -   
 ��Name$
 PreviousButton��$��0��$��20(�$��10,10,10,10q�$��40��$��
 Previous ��   ButtonStyle#��[  �� -   $
 UploadButton��$��2��$��20(�$��10,10,10,10q�$��40��$��
  Upload  ��#��[  �� -   $
 
NextButton��$��5��$��20(�$��10,10,10,10q�$��40��$��    Next    ��#��[  