   M S B A M L   `   `   `  ����P  LSystemActivityMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SystemActivityMonitor.ViewsSystemActivityMonitor.Views  5   	   *    $SystemActivityMonitor.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:SystemActivityMonitor.Views     5   	     � Title$  MainView��5   	   $	��450��6   $	��800��6'   $	��450��63   $	��800��6C    � WindowStartupLocation$ CenterScreen=�5	   	   ���#F9F9FA � 	Resources 5
         
Statistics �� ImageSource  
MainButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value  StatisticsButton��%�  &	        &	 (     &	 �    �� 5   
   $ Statistics.png��6(   �� 5   
   " ��6#   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � �� �#D3EDE86+   �� 5       � �� �#3C71686+   �� 5       � ��$ Latha)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	��0.4q�6!   ���#3C7168#��z��6M   ._�5      �� $��Center=�6/   $��Center=�6L   5       5       P� 5!      	 �@J�IsMouseOver
 . . �5"   "   ��  � �� �#4FAA846?   �� 5#   "    � ��
 �����6?   5$      P� 5&      	 � ��
 . . �5'   "   ��  � �� �#3C71686?   �� 5(   "    � ��
 �����6?   5)      5,      5.      5/      �� 51   
   " ��6)   .�52      ��  �@�OverridesDefaultStyle . 66   �� 53       � �� �#4171b66+   �� 54       � �� �#FFFFFF6+   �� 55       � ��$ Latha)�6+   �� 56       � ��$
 Bold"�6+   �� 57       � �� 58      �� 59      " ��6&   .R�5:      �� $	��0.4q�6!   ���#4171b6#��z��6M   ._�5;      �� $��Center=�6/   $��Center=�6L   5<       5>      P� 5?      	 �@J�IsMouseOver
 . . �5@   "   ��  � �� �#32568b6?   �� 5A   "    � ��
 �����6?   5B      P� 5D      	 � ��
 . . �5E   "   ��  � �� �#87a6d46?   �� 5F   "    � ��
 �����6?   5G      5J      5L      5M      5N      .��5O      �  � ColumnDefinitions 5P   
   �� 5Q      $��3 �6   �� 5R      �� 5S      �� 5T      �� 5U      �� 5V      �� 5W      $��70 �6   �� 5X      $��3 �6    � RowDefinitions 5[   
   �� 5\      $��30 �6   �� 5]      $��10 �6   �� 5^      �� 5_      $��10 �6   .+�5b   
   �� -   5         ��Name$ LoadProcesses��5b      $��	Processes��6(   $��1��6<   $��0��6L   #��[ 6Y   �� 5c   
   -   5        $ LoadProductivity��5c      $��Productivity��6+   $��3��6B   $��0��6R   #��[ 6_   �� 5d   
   -   5        $ LoadWindows��5d      $��Windows��6&   $��2��68   $��0��6H   #��[ 6U   �� 5f   
   -   5        $ LoadStatistics��5f      $��6��6)   $��0��69   #��[ 6F   $��Stretch=�5g      $��Stretch=�6/   $��
Statistics��6K   �� 5i   
   -   5        $ LoadKeyboard��5i      $��Keyboard��6'   $��4��6:   $��0��6J   #��[ 6W   �� 5l   
   -   5         ��Name$ 
ActiveItem��5l      $��1��6-   $��2��6=   $��6��6J   5m      5n      