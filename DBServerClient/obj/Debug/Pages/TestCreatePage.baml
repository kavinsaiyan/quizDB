   M S B A M L   `   `   `  ����I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  5      )    #DBServerClient.Pages.TestCreatePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DBServerClient.Pages     5        N� Title$  TestCreatePage��5	       N� 
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
   �� $��1��6   $��1��5      $��	Test Name��5       $��30(�5!       �� Padding$ 20,20,20,20q�5"      �� 5$   
   -   5         ��Name$ TestNameTextBox��5$      $��1��5%      $��2��5&      $	��280��5'      $��30(�5(      $��10,10,10,10q�5)      ��5*      �� *
TestName+�� 5,   
   $��2��6   $��1��5-      $��Duration��5.      $��30(�5/      $ 20,20,20,20q�50      �� 52   
   -   5        $ DurationTextBox��52      $��2��53      $��2��54      $	��280��55      $��30(�56      $��10,10,10,10q�57      ��58      �� *
Duration+59      �� 5;   
   -   5        $��3��5;      $��1��5<      $��No Of Questions��5=      $��30(�5>      $ 20,20,20,20q�5?      5@      �� 5B   
   -   5        $ NoOfQuestionsTextBox��5B      $��3��5C      $��2��5D      $	��280��5E      $��30(�5F      $��10,10,10,10q�5G      ��5H      �� *NoOfQuestions+�� 5J   
   -   5         ��Name$ CreateTestButton��5J      $��1��5K      $��4��5L      $��30(�5M      $��20,20,20,20q�5N      $��Create Test��5O         ButtonStyle#��[  5P      5Q      5R      5S      