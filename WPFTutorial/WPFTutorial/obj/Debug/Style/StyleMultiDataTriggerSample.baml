   M S B A M L   `   `   `  ����  WPFTutorial3    -WPFTutorial.Style.StyleMultiDataTriggerSample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  StyleMultiDataTriggerSample��5   	   $	��150��6-   $	��200��6:   .��5      �� $��Center=�6   $��Center=�6.   .+�5   
   �� -   5        $��cbSampleYes��5      $	��Yes��6&   �� 5   
   -   5        $��cbSampleSure��5      $��I'm sure��6'   �� 5   
   $��Center=�6   $��0,20,0,0q�61   $��28(�6C   ��5	      �� 5
       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 
Unverified��6-   �� 5       � ��
 �  ��63    �� Triggers 5      ^� 5       ^� 
Conditions 5      �� 5   "    �� Binding 6,   ��  �� ElementName$ cbSampleYes�� �� Path$ 	IsChecked�	 �� Value	 True6h   �� 5   "    6,   �� $ cbSampleSure��$ 	IsChecked�	 True6i   .0�5      ��  � ��$ Verified��65   �� 5       � ��
 � � �6;   5      5      5      5      5      