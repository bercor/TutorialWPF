   M S B A M L   `   `   `  ����F  BWPFTutorial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DGGroupSortFilterExampleDGGroupSortFilterExample  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   )    #DGGroupSortFilterExample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8local&clr-namespace:DGGroupSortFilterExample     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$%  Group, Sort, and Filter Example��5   	   $	��575��61   $	��525��6>    � 	Resources 5      0   *DGGroupSortFilterExample.CompleteConverter   completeConverter$   DGGroupSortFilterExample.Tasks 	 tasks  cvsTasks �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%;  &	        &	      &	 &     7    5   
   6"     5	   
   6   �� 5
   
   -   5        8    5        5      $ ProjectName��6&     5      $ Complete��6&     5      $ DueDate��6&    5        5      $ ProjectName��6+     5      $ Complete��6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      	   CanUserAddRows	 .  ��5      �� 
 �� Source#
 [  �� 
GroupStyle 5       (  "System.Windows.Controls.GroupStyle  5"         ContainerStyle 5#      �� 5$       �� 
TargetType" ��6    .�5%      ��  �� Property � �� �� Value$ 0,0,0,5q�67   �� 5&       � �� 5'   "   �� 5(   &    �� 
TargetType" ��66   .R�5)   *   9�  9� 
IsExpanded . ���	#FF112255���	#FF002255���	#FFEEEEEE$��1,1,1,5q�6�   ��5*   .   ]� 5+   2   .+�5,   6   �� $
��Bold"�6@   $��5,0,0,0q�6m   $	��100��6~   ��6R   ��  �� Path$
 Name�6~   �� 5-   6   $
��Bold"�6@   ��6R   �� $ 	ItemCount�5.   3   ��50   .   �� 51   2   53   +   54   '   56      57      59        5;         HeaderTemplate 5<      �� 5=      .R�5>      ]� 
����ح�.+�5?   "   �� 
����  �$��30,0,0,0q�6�   $	��100��6�   ��6,   �� $
 Name� �� 	Converter# [  6�   �� 5@   "   
����  ���6,   �� $ 	ItemCount�6L   5A      5B      5D         RowStyle 5F      �� 5G      )  #System.Windows.Controls.DataGridRow"  6   .�5H      ��  � ��
 �   �63   �� 5I       � ��
 �����63   5J      5L      �� 5M   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5N      �� $�� Filter completed items ��6   $��Center=�68   �� 5O      -   5         ��Name$ cbCompleteFilter��5O      $��Center=�61   5P   8   �� 5Q      -   5        $��Remove Groups��5Q      $��10,2,2,2q�6-   6?   �� 5R      -   5        $��Group by Project/Status��5R      $��2q�67   6B   5S      5T      5U      