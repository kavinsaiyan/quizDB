   M S B A M L   `   `   `  ����I  EDBServerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DBServerClient.PagesDBServerClient.Pages  5      $    DBServerClient.Pages.StartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DBServerClient.Pages     5        N� Title$  	StartPage��5	       N� 
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
   �� $��1��6   $��1��5      $��Select Database Type��5       $��40(�5!       �� Padding$ 20,20,20,20q�5"      �� 5$   
   -   5         ��Name$ OnlineDB��5$      $��1��5%      $��2��5&      $��40(�5'      $��20,20,20,20q�5(      $��Online(Provided)��5)         ButtonStyle#��[  5*      5+      �� 5-   
   -   5        $ 	OfflineDB��5-      $��1��5.      $��3��5/      $��40(�50      $��20,20,20,20q�51      $��Offline(Custom)��52      #��[  53      54      56      57      