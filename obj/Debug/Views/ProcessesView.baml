   M S B A M L   `   `   `  ����P  LSystemActivityMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SystemActivityMonitor.ViewsSystemActivityMonitor.Views  5      /    )SystemActivityMonitor.Views.ProcessesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SystemActivityMonitor.Views     5      Kbinding9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5      ���#F9F9FA.��5
      � .+�5   
   &   System.Windows.Controls.DataGrid      AutoGenerateColumns  .     	RowHeight$ 20Q�6/      CanUserAddRows .     CanUserDeleteRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6o      CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .     
IsReadOnly . $��Stretch=�5      $��Stretch=�61   ��6M   �� *	Processes+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ Id�  5      $
 Process Name��6%    6;   �� $ ProcessName�  5      $
 Process Window��6%    6=   �� $ MainWindowTitle�  5      $
 
Started At��6%    69   �� $ 	StartTime�  5      $
 Threads��6%    66   �� $ Threads.Count�  5      $
 Processor Time��6%    6=   �� $ TotalProcessorTime�  5      $
 Memory��6%    65   �� $ PeakWorkingSet64�5      5      5      