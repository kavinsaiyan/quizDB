   M S B A M L   `   `   `  ���� B  >quizWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quizWPF.PagesquizWPF.Pages  &     quizWPF.Pages.QuestionAnswerPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:quizWPF.Pages       N� Title$  QuestionAnswerPage�� N� 
Background �	#FF49BCD9.���� $
��Auto=�$
��Auto=�.���  � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� $
��Auto=�$
��Auto=�   ScrollViewerStyle#���   $��1��$��1��.���� -    ��Name$ Question��$��Question��$��20(�$��0,0,0,0q�	� -    	�Name$ AnswerButton0�� d� 	IsChecked$ FalseY�$��20(�$��30��$��2��$��1��$��	40,30,0,0q�.��	Answer0	� -   $ AnswerButton1��$ FalseY�$��20(�$��30��$��3��$��1��$��40,0,0,0q�.��	Answer1	� -   $ AnswerButton2��$ FalseY�$��20(�$��30��$��40,0,0,0q�$��4��$��1��.��	Answer2	� -   $ AnswerButton3��$ FalseY�$��20(�$��30��$��5��$��1��$��40,0,0,0q�.��	Answer3� $��Bottom=�$��0,0,0,0q�$��6��$��1��$��4�� �� $
��auto ��� $��* ��� $
��auto ��� $��* ��� $
��auto �.+��� -    ��Name$ PreviousQuestionButton��$	��120��$��40��  ButtonStyle#���  $��Previous��$��26(�$��0��$��0,0,0,0q��� -   $ SubmitTestButton��$	��120��$��40��$��0,0,0,0q�#���  $��Submit��$��26(�$��2��{�.  �� -   $ NextQuestionButton��$	��120��$��40��$��0,0,0,0q�#���  $
��Next��$��4��$��26(�