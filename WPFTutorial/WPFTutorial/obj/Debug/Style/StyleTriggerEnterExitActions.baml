   M S B A M L   `   `   `  ����  WPFTutorial4    .WPFTutorial.Style.StyleTriggerEnterExitActions   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$"  StyleTriggerEnterExitActions��5   	   $	��200��6.   $	��200��6;    � UseLayoutRounding . .��5      � .+�5   
   �� 
������$	��100��6(   $	��100��64   
����+����5      �� 5       �� 
TargetType" ��6    �� Triggers 5	      P� 5
       P� Property �@J�IsMouseOver P� Value .  N� EnterActions 5      �� 5   "   .��5   &   �� .��5   *   t�  g� Duration$ 	0:0:0.400D�6=   	 t� To$ 3X�6R   	 �� TargetProperty$	 BorderThickness�6Y   W� 5   *   $ 	0:0:0.300D�6:   	
 W� To$	
 125X�6O   $	 Height�6X   W� 5   *   $ 	0:0:0.300D�6:   $	
 125X�6O   $	 Width�6X   5   '   5   #    N� ExitActions 5      �� 5   "   .��5   &   �� .��5   *   t� $ 	0:0:0.250D�6=   $ 0X�6R   $	 BorderThickness�6Y   W� 5   *   $ 	0:0:0.150D�6:   $	
 100X�6O   $	 Height�6X   W� 5   *   $ 	0:0:0.150D�6:   $	
 100X�6O   $	 Width�6X   5   '   5   #   5      5      5!      5"      5#      