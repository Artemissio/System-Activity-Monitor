   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      l hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5      P LSystemActivityMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SystemActivityMonitor.ViewsSystemActivityMonitor.Views 5      0   *SystemActivityMonitor.Views.StatisticsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9System&clr-namespace:System;assembly=mscorlib     5      �cht{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SystemActivityMonitor.Views     5      ���#F9F9FA  � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value   СheckmarkButton��%�  '��       &	  �    �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��
 ���� 6+   �� 5       � �� �#4171b66+   �� 5       � ��$ Latha)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	��0.4q�6!   ���#4171b6#��z��6M   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� �#4171b66?   �� 5   "    � ��
 �����6?   5      P� 5        � �� . . �5!   "   ��  � �� �#32568b6?   �� 5"   "    � ��
 �����6?   5#      5&      5(      5)      �� 5+   
   " ��6(   .�5,      ��  �@�OverridesDefaultStyle . 66   �� 5-       � �� �#4171b66+   �� 5.       � �� �#FFFFFF6+   �� 5/       � ��$ Latha)�6+   �� 50       � ��$
 Bold"�6+   �� 51       � �� 52      �� 53      " ��6&   .R�54      �� $	��0.4q�6!   ���#4171b6#��z��6M   ._�55      �� $��Center=�6/   $��Center=�6L   56       58      P� 59       �@J�IsMouseOver . . �5:   "   ��  � �� �#32568b6?   �� 5;   "    � ��
 �����6?   5<      P� 5>       � �� . . �5?   "   ��  � �� �#87a6d46?   �� 5@   "    � ��
 �����6?   5A      5D      5F      5G      5H      .��5I      �  � ColumnDefinitions 5J   
   �� 5K      $��0.25* �6   �� 5L      $
��0.4* �6   �� 5M      	 � RowDefinitions	 5P   
   �� 5Q      $��10 �6   �� 5R      $��40 �6   �� 5S      $��40 �6   �� 5T      $��40 �6   �� 5U      .+�5X   
   �� -   5        
 ��Name$
 LoadWindowsData��5X      $��0��6*   $��1��6:   $��Top Open Windows��6G   �� 5Y   
   -   5        $
 LoadMostLoadedProcesses��5Y      $��0��62   $��2��6B   $��Top Load Processes��6O   �� 5[   
   $��1��6   $��1��6   $	��Top=�6o   
���   �$��Latha)�6�   ��6-   �� *
MenuText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5]   
   $��1��6   $��1��6   $��5 2 30 2q�6q   $��Bottom=�5^       �� 	MaxLength$ 2��6-   ��5]   /   ��  �� Path$ Amount�$ PropertyChanged=�5^   -   (  "System.Windows.Controls.DatePicker  5`   
   $��2��6   $��1��6"   $��5q�6b   $��Center=�5a         SelectedDate 5`   2   �� $
 Date� �� Mode$ TwoWay=�y�5a   -   �� *DatePickerVisibility+$ PropertyChanged=��� 5c   
   -   5        $
 LoadData��5c      $��1��6#   $��1��63   $��Bottom=�6@   $��20��6[   $��20��6f   $��Right=�6r   $	��✔��5d      $��0 0 5 2q�6   #��[  6.   {�6W   �� $ ValidAmount�$ PropertyChanged=��� 5f   
   $��3��6   $��1��6    $��Center=�60   ���#4171b6$	��5 0q�6`    �� Text$ Select Period��6m   
���   � �� SelectedValuePath$ Value��5g   P    �� DisplayMemberPath$	 Key��6j   ��6&   �� *PeriodsDictionary+ �� SelectedValue 5h      �� *SelectedPeriod+$ TwoWay=�$ PropertyChanged=�y�5i      �� *DatePickerVisibility+$ PropertyChanged=�&   System.Windows.Controls.DataGrid  5k   
      AutoGenerateColumns .     	RowHeight$ 20Q�6/      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .     
IsReadOnly . $��Stretch=�5m      $��Stretch=�61   $��1��5n      $��3��6e   $��5q�6v   ��5m   M   �� $ TopList�$ PropertyChanged=���5n   #   �� *	GridRow+$ PropertyChanged=�   Columns 5o      0  *System.Windows.Controls.DataGridTextColumn  5p      ,  &System.Windows.Controls.DataGridColumn   Header$ Amount��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.31* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� $ Amount�6U     5q      $ Title��6%   $ 0.69* 6S    64   �� $ Title�6S   5s      >  8System.Windows.Controls.DataVisualization.Charting.Chart  5u   
   $��3��5w      $��1��6$   $��4��61   y�5u      �� *WindowsChartVisibility+$ PropertyChanged=�    Title  5v      �� $ 
HeaderText�$ PropertyChanged=�!   Series! 5y      E  ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  ?	  9System.Windows.Controls.DataVisualization.Charting.Series" 	  Title$" Windows��6#   H
  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries# 
  ItemsSource# 63   �� $ TopList�$ PropertyChanged=�$ 
  DependentValueBinding$ 5z   #   �� $ Amount�% 
  IndependentValueBinding% 6Q   �� $ Title�5{      5}        5   
   $��3��5�      $��1��6$   $��4��61   y�5      �� * LoadedProcessesChartVisibility+$ PropertyChanged=�  5�      �� $ 
HeaderText�$ PropertyChanged=�! 5�      B  <System.Windows.Controls.DataVisualization.Charting.PieSeries  # 6    �� $ TopList�$ PropertyChanged=�$ 5�       �� $ Amount�% 6N   �� $ Title�5�      5�      5�      5�      