   M S B A M L   `   `   `  ���� I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  )    #DBServerClient.Pages.TestCreatePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:DBServerClient.Pages       N� Title$  TestCreatePage�� N� 
Background �	#FF49BCD9 N� 
Foreground
 �P��.���  � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� $��1��$��1��$��	Test Name��$��30(� �� Padding$ 20,20,20,20q��� -    ��Name$ TestNameTextBox��$��1��$��2��$	��280��$��30(�$��10,10,10,10q����� *
TestName+�� $��2��$��1��$��Duration��$��30(�$ 20,20,20,20q��� -   $ DurationTextBox��$��2��$��2��$	��280��$��30(�$��10,10,10,10q����� *
Duration+�� -   $��3��$��1��$��No Of Questions��$��30(�$ 20,20,20,20q��� -   $ NoOfQuestionsTextBox��$��3��$��2��$	��280��$��30(�$��10,10,10,10q����� *NoOfQuestions+�� -    ��Name$ CreateTestButton��$��1��$��4��$��30(�$��20,20,20,20q�$��Create Test��   ButtonStyle#��[  